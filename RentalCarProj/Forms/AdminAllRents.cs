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
    public partial class AdminAllRents : Form
    {
        public AdminAllRents()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            Close();
        }
        private async void AdminAllRents_Load(object sender, EventArgs e)
        {
            dataGridViewCars.AutoGenerateColumns = false;
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "RentSerialNumber" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Rent Price", DataPropertyName = "RentPrice" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Car" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Start Time", DataPropertyName = "RentStartTime" });
            dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Is Finished", DataPropertyName = "IsFinished" });

            dataGridViewCars.CellFormatting += DataGridViewRents_CellFormatting;

            using (var Context = new AppDbContext())
            {
                var rentList = await Context.Rents.Include(x => x.RentUser).Include(x => x.Car).ToListAsync();
                dataGridViewCars.DataSource = rentList;
            }
        }

        private void DataGridViewRents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewCars.Columns[e.ColumnIndex].HeaderText == "Car" && e.Value == null)
            {
                var rent = dataGridViewCars.Rows[e.RowIndex].DataBoundItem as RentEntity;
                e.Value = rent?.Car?.CarName;
            }
        }
    }
}
