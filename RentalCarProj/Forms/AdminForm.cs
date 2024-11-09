using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        /*        private async void AdminForm_Load(object sender, EventArgs e)
                {
                    dataGridViewCars.AutoGenerateColumns = false;
                    dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "CarSerialNumber" });
                    dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "CarName" });
                    dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price per day", DataPropertyName = "RentPricePerDay" });
                    dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Available", DataPropertyName = "IsAvailable" });
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                    {
                        Name = "Image",
                        HeaderText = "Car Image",
                        ImageLayout = DataGridViewImageCellLayout.Zoom // Adjust image layout as needed
                    };
                    dataGridViewCars.Columns.Add(imageColumn);

                    using (var Context = new AppDbContext())
                    {
                        var carList = await Context.Cars.ToListAsync();
                        dataGridViewCars.DataSource = carList;
                    }
                }
        */

        private async void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridViewCars.AutoGenerateColumns = false;

            // Add columns for car properties
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "CarSerialNumber" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "CarName" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price per day", DataPropertyName = "RentPricePerDay" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Available", DataPropertyName = "IsAvailable" });

            // Add an image column
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Car Image",
                Name = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom // Adjust image layout if needed
            };
            dataGridViewCars.Columns.Add(imageColumn);

            // Load cars from the database
            using (var Context = new AppDbContext())
            {
                var carList = await Context.Cars.ToListAsync();

                // Populate rows with car data and images
                foreach (var car in carList)
                {
                    // Load the image from the file path
                    Image carImage = null;
                    if (!string.IsNullOrEmpty(car.ImagePath) && System.IO.File.Exists(car.ImagePath))
                    {
                        carImage = Image.FromFile(car.ImagePath);
                    }

                    // Add the car data and image to the DataGridView
                    dataGridViewCars.Rows.Add(car.CarSerialNumber, car.CarName, car.RentPricePerDay, car.IsAvailable, carImage);
                }
            }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login login = new();
            login.Show();
            Close();
        }

        private string imageFilePath;
        private async void AddBtn_Click(object sender, EventArgs e)
        {
            /*      if (!ModelTextBox.Text.IsNullOrEmpty() &&
                      ModelTextBox.Text.Length >= 4 &&
                      !PriceTextBox.Text.IsNullOrEmpty() &&
                      PriceTextBox.Text.Length >= 1)
                  {
                      using (var Context = new AppDbContext())
                      {
                          int lastNum = 0;
                          if (await Context.Cars.AnyAsync())
                          {
                              lastNum = await Context.Cars.OrderBy(x => x.CarSerialNumber).Select(x => x.CarSerialNumber).LastAsync();
                              lastNum++;
                          }
                          CarEntity car = new()
                          {
                              CarName = ModelTextBox.Text,
                              IsAvailable = true,
                              RentPricePerDay = int.Parse(PriceTextBox.Text),
                              CarSerialNumber = lastNum,
                          };
                          Context.Cars.Add(car);
                          await Context.SaveChangesAsync();
                          AdminForm adminForm = new();
                          adminForm.Show();
                          Close();
                      }
                  }
                  else
                  {
                      MessageBox.Show("Input valid data!");
                  }*/

            if (!string.IsNullOrEmpty(ModelTextBox.Text) &&
    ModelTextBox.Text.Length >= 4 &&
    !string.IsNullOrEmpty(PriceTextBox.Text) &&
    PriceTextBox.Text.Length >= 1 &&
    imageFilePath != null) // Check if image is selected
            {
                using (var context = new AppDbContext())
                {
                    int lastNum = 0;
                    if (await context.Cars.AnyAsync())
                    {
                        lastNum = await context.Cars.OrderBy(x => x.CarSerialNumber)
                                                    .Select(x => x.CarSerialNumber)
                                                    .LastAsync();
                        lastNum++;
                    }

                    // Save image to a local folder in the project directory
                    string imagesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CarImages");
                    Directory.CreateDirectory(imagesDirectory);  // Ensure directory exists
                    string fileName = $"{Guid.NewGuid()}{Path.GetExtension(imageFilePath)}";
                    string savePath = Path.Combine(imagesDirectory, fileName);
                    File.Copy(imageFilePath, savePath);

                    CarEntity car = new()
                    {
                        CarName = ModelTextBox.Text,
                        IsAvailable = true,
                        RentPricePerDay = int.Parse(PriceTextBox.Text),
                        CarSerialNumber = lastNum,
                        ImagePath = Path.Combine("CarImages", fileName) // Store relative path
                    };

                    context.Cars.Add(car);
                    await context.SaveChangesAsync();

                    AdminForm adminForm = new();
                    adminForm.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Input valid data and select an image!");
            }
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            using (var Context = new AppDbContext())
            {
                CarEntity? partCar = await Context.Cars.FirstOrDefaultAsync(x => x.CarSerialNumber.ToString() == SearchTextBox.Text);
                if (partCar != null)
                {
                    SelectedCar.CarSerialNumber = partCar.CarSerialNumber;
                    ModelTextBox.Text = partCar.CarName;
                    PriceTextBox.Text = partCar.RentPricePerDay.ToString();
                }
                else
                {
                    MessageBox.Show("No Car found. Try again");
                }
            }
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (SelectedCar.CarSerialNumber != null)
            {
                if (ModelTextBox.Text.Length >= 4 && PriceTextBox.Text.Length >= 1)
                {
                    using (var Context = new AppDbContext())
                    {
                        CarEntity selectedCar = await Context.Cars.FirstOrDefaultAsync(x => x.CarSerialNumber == SelectedCar.CarSerialNumber);
                        if (selectedCar != null)
                        {
                            selectedCar.CarName = ModelTextBox.Text;
                            selectedCar.RentPricePerDay = int.Parse(PriceTextBox.Text);
                            Context.Cars.Update(selectedCar);
                            await Context.SaveChangesAsync();
                            AdminForm adminForm = new();
                            adminForm.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No Car found. Try again");
                            AdminForm adminForm = new();
                            adminForm.Show();
                            Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Car found. Try again");
                AdminForm adminForm = new();
                adminForm.Show();
                Close();
            }
        }

        private async void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (SelectedCar.CarSerialNumber != null)
            {
                using (var Context = new AppDbContext())
                {
                    CarEntity selectedCar = await Context.Cars.FirstOrDefaultAsync(x => x.CarSerialNumber == SelectedCar.CarSerialNumber);
                    if (selectedCar != null)
                    {
                        if (!selectedCar.IsAvailable)
                        {
                            MessageBox.Show("The car is already in use");
                        }
                        else
                        {
                            Context.Cars.Remove(selectedCar);
                            await Context.SaveChangesAsync();
                            AdminForm adminForm = new();
                            adminForm.Show();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Car found. Try again");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Car found. Try again");
                AdminForm adminForm = new();
                adminForm.Show();
                Close();
            }
        }

        private void OldRentBtn_Click(object sender, EventArgs e)
        {
            AdminAllRents adminAllRents = new AdminAllRents();
            adminAllRents.Show();
            Close();
        }

        private void AllUsersBtn_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers();
            allUsers.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormForTest formForTest = new();
            formForTest.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageFilePath = openFileDialog.FileName;
                }
            }
        }
    }
}