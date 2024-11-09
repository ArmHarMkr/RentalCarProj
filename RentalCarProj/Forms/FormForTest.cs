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
    public partial class FormForTest : Form
    {
        public FormForTest()
        {
            InitializeComponent();
            Load += FormForTest_Load;
        }

        private void FormForTest_Load(object sender, EventArgs e)
        {
            // Set form properties
            this.Text = "Rental Car Management";
            this.Size = new Size(800, 600);
            this.BackColor = Color.LightGray;

            // Create a header label
            Label headerLabel = new Label();
            headerLabel.Text = "Rental Car Management";
            headerLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            headerLabel.ForeColor = Color.DarkSlateGray;
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(300, 10);
            this.Controls.Add(headerLabel);

            // Create a search label
            Label searchLabel = new Label();
            searchLabel.Text = "Search by Car Serial Number";
            searchLabel.Font = new Font("Arial", 10, FontStyle.Regular);
            searchLabel.Location = new Point(50, 60);
            this.Controls.Add(searchLabel);

            // Create a search textbox
            TextBox searchTextBox = new TextBox();
            searchTextBox.Location = new Point(250, 55);
            searchTextBox.Size = new Size(200, 30);
            this.Controls.Add(searchTextBox);

            // Create a search button
            Button searchButton = new Button();
            searchButton.Text = "Search";
            searchButton.Location = new Point(500, 50);
            searchButton.Size = new Size(100, 30);
            searchButton.BackColor = Color.LightSteelBlue;
            searchButton.Click += (s, args) => { MessageBox.Show("Search functionality clicked!"); };
            this.Controls.Add(searchButton);

            // Create a "Show All" button
            Button showAllButton = new Button();
            showAllButton.Text = "Show All";
            showAllButton.Location = new Point(620, 50);
            showAllButton.Size = new Size(100, 30);
            showAllButton.BackColor = Color.LightSteelBlue;
            showAllButton.Click += (s, args) => { MessageBox.Show("Show All functionality clicked!"); };
            this.Controls.Add(showAllButton);

            // Create a DataGridView to display rents
            DataGridView dataGridViewRents = new DataGridView();
            dataGridViewRents.Location = new Point(50, 100);
            dataGridViewRents.Size = new Size(700, 300);
            dataGridViewRents.BackgroundColor = Color.White;
            dataGridViewRents.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewRents.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridViewRents.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewRents.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewRents.RowsDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            this.Controls.Add(dataGridViewRents);

            // Create a "Rent" button
            Button rentButton = new Button();
            rentButton.Text = "Rent";
            rentButton.Location = new Point(50, 420);
            rentButton.Size = new Size(100, 40);
            rentButton.BackColor = Color.LightGreen;
            rentButton.Click += (s, args) => { MessageBox.Show("Rent functionality clicked!"); };
            this.Controls.Add(rentButton);

            // Create a "Show Old Rents" button
            Button showOldRentsButton = new Button();
            showOldRentsButton.Text = "Show Old Rents";
            showOldRentsButton.Location = new Point(200, 420);
            showOldRentsButton.Size = new Size(120, 40);
            showOldRentsButton.BackColor = Color.LightCoral;
            showOldRentsButton.Click += (s, args) => { MessageBox.Show("Show Old Rents functionality clicked!"); };
            this.Controls.Add(showOldRentsButton);

            // Create a "Log Out" button
            Button logoutButton = new Button();
            logoutButton.Text = "Log Out";
            logoutButton.Location = new Point(650, 420);
            logoutButton.Size = new Size(100, 40);
            logoutButton.BackColor = Color.IndianRed;
            logoutButton.Click += (s, args) => { MessageBox.Show("Logout functionality clicked!"); };
            this.Controls.Add(logoutButton);

            // Create a label for displaying available balance or user info
            Label balanceLabel = new Label();
            balanceLabel.Text = "You have: $500";  // Example text
            balanceLabel.Font = new Font("Arial", 10, FontStyle.Italic);
            balanceLabel.Location = new Point(650, 20);
            balanceLabel.AutoSize = true;
            this.Controls.Add(balanceLabel);
        }
    }
}