using Microsoft.EntityFrameworkCore;
using RentalCarProj.Classes;
using RentalCarProj.Entities;
using RentalCarProj.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources.Tools;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarProj
{
    public partial class RentCar : Form
    {
        public RentCar()
        {
            InitializeComponent();
        }


        private async void RentCar_Load(object sender, EventArgs e)
        {
            // Set balance label color based on balance amount
            if (CurrentUser.AppUser.Balance < 0)
            {
                BalanceLabel.ForeColor = Color.Red;
            }
            else
            {
                BalanceLabel.ForeColor = Color.Green;
            }
            BalanceLabel.Text = CurrentUser.AppUser.Balance.ToString();

            // Configure DataGridView columns
            dataGridViewCars.AutoGenerateColumns = false;
            dataGridViewCars.Columns.Clear(); // Clear existing columns

            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "CarSerialNumber"
            });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "CarName"
            });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price per day",
                DataPropertyName = "RentPricePerDay"
            });

            // Add an image column
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Car Image",
                Name = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom // Adjust to fit cell size
            };
            dataGridViewCars.Columns.Add(imageColumn);

            // Load available cars from the database
            using (var Context = new AppDbContext())
            {
                var carList = await Context.Cars.Where(x => x.IsAvailable).ToListAsync();

                // Populate DataGridView rows
                foreach (var car in carList)
                {
                    // Load the car image
                    Image carImage = null;
                    if (!string.IsNullOrEmpty(car.ImagePath) && System.IO.File.Exists(car.ImagePath))
                    {
                        carImage = Image.FromFile(car.ImagePath);
                    }

                    // Add the car data and image to the DataGridView
                    dataGridViewCars.Rows.Add(car.CarSerialNumber, car.CarName, car.RentPricePerDay, carImage);
                }
            }
        }


        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login login = new();
            login.Show();
            Close();
        }

        private void ShowOldRentBtn_Click(object sender, EventArgs e)
        {
            OldRentBtn oldRent = new();
            oldRent.Show();
            Close();
        }

        private async void RentCarBtn_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                if (DayAmountTextBox.Text != string.Empty && SearchTextBox.Text != string.Empty)
                {
                    CarEntity selectedCar = await context.Cars.FirstOrDefaultAsync(x => x.CarSerialNumber == SelectedCar.CarSerialNumber);
                    if (selectedCar == null)
                    {
                        MessageBox.Show("Car not found");
                        return;
                    }

                    int lastNum = 0;
                    if (await context.Rents.AnyAsync())
                    {
                        lastNum = await context.Rents.OrderBy(x => x.RentSerialNumber).Select(x => x.RentSerialNumber).LastAsync();
                        lastNum++;
                    }

                    var existingUser = await context.AppUsers.FindAsync(CurrentUser.AppUser.Id);
                    if (existingUser == null)
                    {
                        MessageBox.Show("User  not found");
                        return;
                    }

                    RentEntity rent = new()
                    {
                        Car = selectedCar,
                        RentPrice = selectedCar.RentPricePerDay * int.Parse(DayAmountTextBox.Text),
                        RentSerialNumber = lastNum,
                        RentUser = existingUser,
                    };
                    /*if(rent.RentPrice < existingUser.Balance)
                    {
                        MessageBox.Show("You don't have enough money");
                        return;
                    }*/
                    selectedCar.IsAvailable = false;
                    await context.Rents.AddAsync(rent);
                    AppUser currentUser = CurrentUser.AppUser;
                    currentUser.Balance -= rent.RentPrice;
                    currentUser.RentedCars++;
                    await context.SaveChangesAsync();

                    RentCar rentCar = new();
                    rentCar.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Non valid data");
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var Context = new AppDbContext())
                {
                    SelectedCar.CarSerialNumber = int.Parse(SearchTextBox.Text);
                    if (SearchTextBox.Text == string.Empty)
                    {
                        var carList = await Context.Cars.Where(x => x.IsAvailable).ToListAsync();
                        dataGridViewCars.DataSource = carList;
                    }
                    CarEntity selectedCar = await Context.Cars.FirstOrDefaultAsync(x => x.CarSerialNumber == SelectedCar.CarSerialNumber);
                    if (selectedCar == null)
                    {
                        MessageBox.Show("Car not found");
                    }
                    else
                    {
                        dataGridViewCars.DataSource = new List<CarEntity> { selectedCar };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            using (var Context = new AppDbContext())
            {
                var carList = await Context.Cars.Where(x => x.IsAvailable).ToListAsync();
                dataGridViewCars.DataSource = carList;
                RentCar rentCar = new();
                rentCar.Show();
                Close();
            }

        }
    }
}