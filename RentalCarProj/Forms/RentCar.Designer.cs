namespace RentalCarProj
{
    partial class RentCar
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
            LogOutBtn = new Button();
            RentCarBtn = new Button();
            label4 = new Label();
            SearchTextBox = new TextBox();
            ShowOldRentBtn = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            DayAmountTextBox = new TextBox();
            label2 = new Label();
            BalanceLabel = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(12, 182);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.Size = new Size(636, 273);
            dataGridViewCars.TabIndex = 0;
            dataGridViewCars.CellContentClick += dataGridViewCars_CellContentClick;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.FromArgb(255, 128, 128);
            LogOutBtn.Location = new Point(237, 461);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(178, 42);
            LogOutBtn.TabIndex = 1;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // RentCarBtn
            // 
            RentCarBtn.BackColor = Color.FromArgb(128, 255, 128);
            RentCarBtn.Location = new Point(362, 142);
            RentCarBtn.Name = "RentCarBtn";
            RentCarBtn.Size = new Size(140, 34);
            RentCarBtn.TabIndex = 13;
            RentCarBtn.Text = "Rent";
            RentCarBtn.UseVisualStyleBackColor = false;
            RentCarBtn.Click += RentCarBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 12;
            label4.Text = "Search Car";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(104, 110);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(252, 23);
            SearchTextBox.TabIndex = 11;
            // 
            // ShowOldRentBtn
            // 
            ShowOldRentBtn.BackColor = Color.FromArgb(255, 192, 128);
            ShowOldRentBtn.Location = new Point(508, 138);
            ShowOldRentBtn.Name = "ShowOldRentBtn";
            ShowOldRentBtn.Size = new Size(140, 34);
            ShowOldRentBtn.TabIndex = 14;
            ShowOldRentBtn.Text = "Show old rent";
            ShowOldRentBtn.UseVisualStyleBackColor = false;
            ShowOldRentBtn.Click += ShowOldRentBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 151);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 16;
            label1.Text = "Rent Day Amount";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Location = new Point(362, 101);
            button1.Name = "button1";
            button1.Size = new Size(140, 34);
            button1.TabIndex = 18;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Location = new Point(508, 101);
            button2.Name = "button2";
            button2.Size = new Size(140, 34);
            button2.TabIndex = 19;
            button2.Text = "Show All";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DayAmountTextBox
            // 
            DayAmountTextBox.Location = new Point(159, 153);
            DayAmountTextBox.Name = "DayAmountTextBox";
            DayAmountTextBox.Size = new Size(197, 23);
            DayAmountTextBox.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 21;
            label2.Text = "Balance:";
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            BalanceLabel.Location = new Point(101, 66);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(64, 25);
            BalanceLabel.TabIndex = 22;
            BalanceLabel.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(175, 9);
            label3.Name = "label3";
            label3.Size = new Size(350, 40);
            label3.TabIndex = 23;
            label3.Text = "Rental Car Management";
            // 
            // RentCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(668, 511);
            Controls.Add(label3);
            Controls.Add(BalanceLabel);
            Controls.Add(label2);
            Controls.Add(DayAmountTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ShowOldRentBtn);
            Controls.Add(RentCarBtn);
            Controls.Add(label4);
            Controls.Add(SearchTextBox);
            Controls.Add(LogOutBtn);
            Controls.Add(dataGridViewCars);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RentCar";
            Text = "RentCar";
            Load += RentCar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCars;
        private Button LogOutBtn;
        private Button RentCarBtn;
        private Label label4;
        private TextBox SearchTextBox;
        private Button ShowOldRentBtn;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox DayAmountTextBox;
        private Label label2;
        private Label BalanceLabel;
        private Label label3;
    }
}