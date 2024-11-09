namespace RentalCarProj.Forms
{
    partial class AdminForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCars = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ModelTextBox = new TextBox();
            PriceTextBox = new TextBox();
            SearchTextBox = new TextBox();
            label4 = new Label();
            SearchBtn = new Button();
            AddBtn = new Button();
            EditBtn = new Button();
            RemoveBtn = new Button();
            LogOutBtn = new Button();
            OldRentBtn = new Button();
            AllUsersBtn = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(387, 27);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.Size = new Size(507, 411);
            dataGridViewCars.TabIndex = 1;
            dataGridViewCars.CellContentClick += dataGridViewCars_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 2;
            label1.Text = "Car Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 85);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 3;
            label2.Text = "Price/Day";
            label2.Click += label2_Click;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(83, 36);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(250, 25);
            ModelTextBox.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(83, 85);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(250, 25);
            PriceTextBox.TabIndex = 6;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(7, 57);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(200, 23);
            SearchTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 27);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 9;
            label4.Text = "Search by CarSerialNumber";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(255, 128, 0);
            SearchBtn.Location = new Point(222, 44);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(140, 36);
            SearchBtn.TabIndex = 10;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(192, 255, 192);
            AddBtn.ForeColor = SystemColors.ControlText;
            AddBtn.Location = new Point(7, 330);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(84, 38);
            AddBtn.TabIndex = 11;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(255, 255, 192);
            EditBtn.ForeColor = SystemColors.ControlText;
            EditBtn.Location = new Point(97, 330);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(84, 38);
            EditBtn.TabIndex = 12;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.FromArgb(255, 128, 128);
            RemoveBtn.ForeColor = SystemColors.ControlText;
            RemoveBtn.Location = new Point(188, 329);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(84, 38);
            RemoveBtn.TabIndex = 13;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.Red;
            LogOutBtn.ForeColor = SystemColors.ControlText;
            LogOutBtn.Location = new Point(188, 389);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(174, 49);
            LogOutBtn.TabIndex = 14;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // OldRentBtn
            // 
            OldRentBtn.BackColor = Color.FromArgb(128, 255, 255);
            OldRentBtn.ForeColor = SystemColors.ControlText;
            OldRentBtn.Location = new Point(278, 330);
            OldRentBtn.Name = "OldRentBtn";
            OldRentBtn.Size = new Size(84, 38);
            OldRentBtn.TabIndex = 15;
            OldRentBtn.Text = "Show Rents";
            OldRentBtn.UseVisualStyleBackColor = false;
            OldRentBtn.Click += OldRentBtn_Click;
            // 
            // AllUsersBtn
            // 
            AllUsersBtn.BackColor = Color.FromArgb(128, 128, 255);
            AllUsersBtn.ForeColor = SystemColors.ControlText;
            AllUsersBtn.Location = new Point(7, 389);
            AllUsersBtn.Name = "AllUsersBtn";
            AllUsersBtn.Size = new Size(175, 49);
            AllUsersBtn.TabIndex = 16;
            AllUsersBtn.Text = "All Users";
            AllUsersBtn.UseVisualStyleBackColor = false;
            AllUsersBtn.Click += AllUsersBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(PriceTextBox);
            groupBox1.Controls.Add(ModelTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(7, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 173);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Car Details";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(5, 124);
            button1.Name = "button1";
            button1.Size = new Size(328, 43);
            button1.TabIndex = 18;
            button1.Text = "Choose Image";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(904, 453);
            Controls.Add(groupBox1);
            Controls.Add(AllUsersBtn);
            Controls.Add(OldRentBtn);
            Controls.Add(LogOutBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(SearchBtn);
            Controls.Add(label4);
            Controls.Add(SearchTextBox);
            Controls.Add(dataGridViewCars);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCars;
        private Label label1;
        private Label label2;
        private TextBox ModelTextBox;
        private TextBox PriceTextBox;
        private TextBox SearchTextBox;
        private Label label4;
        private Button SearchBtn;
        private Button AddBtn;
        private Button EditBtn;
        private Button RemoveBtn;
        private Button LogOutBtn;
        private Button OldRentBtn;
        private Button AllUsersBtn;
        private GroupBox groupBox1;
        private Button button1;
    }
}