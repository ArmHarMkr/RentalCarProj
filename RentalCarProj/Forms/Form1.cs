using Microsoft.EntityFrameworkCore;
using RentalCarProj.Classes;
using RentalCarProj.Entities;
using RentalCarProj.Forms;

namespace RentalCarProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var Context = new AppDbContext())
            {
                if (!Context.AppUsers.Any(x => x.Email == EmailTextBox.Text))
                {
                    var isValidEmail = ValidityCheker.CheckEmail(EmailTextBox.Text);
                    if (!isValidEmail)
                    {
                        MessageBox.Show("Invalid Email");
                    }

                    var isValidName = ValidityCheker.CheckName(FullNameTextBox.Text);
                    if (!isValidName)
                    {
                        MessageBox.Show("Invalid Name");
                    }

                    var isValidPassword = ValidityCheker.CheckPassword(PasswordTextBox.Text);
                    if (!isValidPassword)
                    {
                        MessageBox.Show("Invalid password");
                    }


                    if (isValidEmail && isValidName && isValidPassword)
                    {
                        int lastNum = 0;
                        if (await Context.AppUsers.AnyAsync())
                        {
                            lastNum = await Context.AppUsers.OrderBy(x => x.SerialNumber).Select(x => x.SerialNumber).LastAsync();
                            lastNum++;
                        }

                        var appUser = new AppUser();
                        appUser.Email = EmailTextBox.Text;
                        appUser.Name = FullNameTextBox.Text;
                        appUser.Password = PasswordTextBox.Text;
                        appUser.SerialNumber = lastNum;
                        Context.AppUsers.Add(appUser);
                        await Context.SaveChangesAsync();
                        CurrentUser.Id = appUser.Id;
                        CurrentUser.Email = EmailTextBox.Text;
                        CurrentUser.FullName = FullNameTextBox.Text;
                        CurrentUser.AppUser = appUser;

                        using (var loadingBar = new LoadingBar())
                        {
                            loadingBar.Show();
                            await loadingBar.ShowLoading();
                        }

                        var targetForm = new RentCar();
                        targetForm.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Email is already registered");
                }
            }
        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormForTest testForm = new Forms.FormForTest();
            testForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            FormForTest form = new Forms.FormForTest();
            form.Show();
        }
    }
}
