using Microsoft.EntityFrameworkCore;
using RentalCarProj.Classes;
using RentalCarProj.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarProj.Forms
{
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
        }

        private async void AllUsers_Load(object sender, EventArgs e)
        {
            using (var Context = new AppDbContext())
            {
                var users = await Context.AppUsers.Where(x => x.Id != "Admin123").ToListAsync();
                dataGridViewUsers.DataSource = users;
                dataGridViewUsers.Columns["Password"].Visible = false;
            }

        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            using (var Context = new AppDbContext())
            {
                var users = await Context.AppUsers.FirstOrDefaultAsync(x => x.Id != "Admin123" && x.SerialNumber.ToString() == SearchTextBox.Text);
                if (users == null)
                {
                    MessageBox.Show("No user found");
                }
                CurrentUser.AppUser = users;
                CurrentUser.Email = users.Email;
                CurrentUser.FullName = users.Name;
                CurrentUser.Id = users.Id;
                dataGridViewUsers.DataSource = new List<AppUser> { users };
                dataGridViewUsers.Columns["Password"].Visible = false;
            }
        }

        private async void GiveMoneyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentUser.AppUser != null)
                {
                    using (var Context = new AppDbContext())
                    {
                        var user = CurrentUser.AppUser;
                        user.Balance += int.Parse(textBox1.Text);
                        Context.AppUsers.Update(user);
                        await Context.SaveChangesAsync();
                        AllUsers allUsers = new AllUsers();
                        allUsers.Show();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("No User Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm admin = new();
            admin.Show();
            Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (var Context = new AppDbContext())
            {
                var users = await Context.AppUsers.Where(x => x.Id != "Admin123").ToListAsync();
                if (users != null)
                {
                    MessageBox.Show("No user found");
                }
                dataGridViewUsers.DataSource = users;
                dataGridViewUsers.Columns["Password"].Visible = false;
            }
        }
    }
}
