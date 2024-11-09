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
    public partial class Login : Form   
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var Context = new AppDbContext())
            {
                if (EmailTextBox.Text == "admin@admin.com" && PasswordTextBox.Text == "Admin1234")
                {
                    AdminForm admin = new();
                    CurrentUser.Email = "admin@admin.com";
                    CurrentUser.FullName = "Admin Admin";
                    CurrentUser.Id = "Admin123";
                    using (var loadingBar = new LoadingBar())
                    {
                        loadingBar.Show();
                        await loadingBar.ShowLoading();
                    }

                    admin.Show();
                    Close();
                    this.Hide();
                }
                else
                {
                    if (Context.AppUsers.Any(x => x.Email == EmailTextBox.Text))
                    {
                        var user = await Context.AppUsers.FirstOrDefaultAsync(x => x.Email == EmailTextBox.Text);
                        if (user != null)
                        {
                            if (user.Password == PasswordTextBox.Text)
                            {
                                CurrentUser.Id = user.Id;
                                CurrentUser.Email = user.Email;
                                CurrentUser.FullName = user.Name;
                                CurrentUser.AppUser = user;
                                using (var loadingBar = new LoadingBar())
                                {
                                    loadingBar.Show();
                                    await loadingBar.ShowLoading();
                                }

                                var targetForm = new RentCar();
                                targetForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Email or Password are wrong");
                                EmailTextBox.Text = "";
                                PasswordTextBox.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email or Password are wrong");
                            EmailTextBox.Text = "";
                            PasswordTextBox.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No User Found");
                    }
                }
            }
        }

        private void GoToRegister_Click(object sender, EventArgs e)
        {
            Form1 form = new();
            form.Show();
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new();
            form.Show();
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
