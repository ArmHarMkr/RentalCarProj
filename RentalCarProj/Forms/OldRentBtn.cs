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
    public partial class OldRentBtn : Form
    {
        public OldRentBtn()
        {
            InitializeComponent();
        }

        private async void OldRentBtn_Load(object sender, EventArgs e)
        {
            dataGridViewRents.AutoGenerateColumns = false;
            dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "RentSerialNumber" });
            dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Rent Price", DataPropertyName = "RentPrice" });
            dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Car" });
            dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Start Time", DataPropertyName = "RentStartTime" });
            dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Is Finished", DataPropertyName = "IsFinished" });

            dataGridViewRents.CellFormatting += DataGridViewRents_CellFormatting;

            // Load the user's rentals
            using (var Context = new AppDbContext())
            {
                var rentList = await Context.Rents.Include(x => x.RentUser).Include(x => x.Car)
                    .Where(x => x.RentUser.Id == CurrentUser.Id).ToListAsync();
                dataGridViewRents.DataSource = rentList;
            }

            // Initialize and start the timer
            timer1.Interval = 60000;
            timer1.Tick += RentalCheckTimer_Tick;
            timer1.Tick += RentalCheckTimer_Tick;
            timer1.Start();
        }

        private async void RentalCheckTimer_Tick(object sender, EventArgs e)
        {
            using (var Context = new AppDbContext())
            {
                // Get all active rentals for the current user that haven't been marked as finished
                var activeRents = await Context.Rents
                    .Where(x => x.RentUser.Id == CurrentUser.Id && !x.IsFinished)
                    .ToListAsync();

                bool rentalsUpdated = false;

                foreach (var rent in activeRents)
                {
                    // Calculate the expiration time
                    DateTime expirationTime = rent.RentStartTime.AddDays(rent.RentDuration);

                    // If the current time is past the expiration time, mark the rental as finished
                    if (DateTime.Now >= expirationTime)
                    {
                        rent.IsFinished = true;
                        Context.Rents.Update(rent);
                        rentalsUpdated = true;
                    }
                }

                // Save changes if any rentals were updated
                if (rentalsUpdated)
                {
                    await Context.SaveChangesAsync();

                    // Refresh the DataGridView
                    var rentList = await Context.Rents.Include(x => x.RentUser).Include(x => x.Car)
                        .Where(x => x.RentUser.Id == CurrentUser.Id).ToListAsync();
                    dataGridViewRents.DataSource = rentList;
                }
            }
        }



        private void DataGridViewRents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewRents.Columns[e.ColumnIndex].HeaderText == "Car" && e.Value == null)
            {
                var rent = dataGridViewRents.Rows[e.RowIndex].DataBoundItem as RentEntity;
                e.Value = rent?.Car?.CarName;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            RentCar rentCar = new();
            rentCar.Show();
            Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var Context = new AppDbContext())
                {
                    RentEntity? rent = await Context.Rents.FirstOrDefaultAsync(x => x.RentSerialNumber == SelectedRent.RentSerialNumber);
                    if (rent == null)
                    {
                        MessageBox.Show("No rent found");
                        return;
                    }
                    if (!rent.IsFinished)
                    {
                        MessageBox.Show("The money will not be returned back");
                        rent.IsFinished = true;
                        Context.Rents.Update(rent);
                        await Context.SaveChangesAsync();
                        OldRentBtn oldRent = new();
                        oldRent.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("The Rent is already finished");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            using (var Context = new AppDbContext())
            {
                RentEntity? rent = await Context.Rents.Include(x => x.RentUser).Include(x => x.Car).FirstOrDefaultAsync(x => x.RentSerialNumber.ToString() == SearchTextBox.Text);
                if (rent == null)
                {
                    MessageBox.Show("No rent found");
                }

                dataGridViewRents.AutoGenerateColumns = false;
                dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "RentSerialNumber" });
                dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Rent Price", DataPropertyName = "RentPrice" });
                dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Car" });
                dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Start Time", DataPropertyName = "RentStartTime" });
                dataGridViewRents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Is Finished", DataPropertyName = "IsFinished" });

                dataGridViewRents.CellFormatting += DataGridViewRents_CellFormatting;

                dataGridViewRents.DataSource = new List<RentEntity> { rent };
                SelectedRent.RentSerialNumber = rent.RentSerialNumber;
            }

        }

        private void dataGridViewRents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}