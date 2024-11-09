namespace RentalCarProj.Forms
{
    partial class AdminAllRents : Form
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
            GoBackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(12, 21);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.Size = new Size(557, 240);
            dataGridViewCars.TabIndex = 11;
            // 
            // GoBackBtn
            // 
            GoBackBtn.BackColor = Color.FromArgb(255, 128, 128);
            GoBackBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoBackBtn.ForeColor = SystemColors.ControlLight;
            GoBackBtn.Location = new Point(123, 278);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(331, 61);
            GoBackBtn.TabIndex = 15;
            GoBackBtn.Text = "Go Back";
            GoBackBtn.UseVisualStyleBackColor = false;
            GoBackBtn.Click += GoBackBtn_Click;
            // 
            // AdminAllRents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(581, 351);
            Controls.Add(GoBackBtn);
            Controls.Add(dataGridViewCars);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminAllRents";
            Text = "AdminAllRents";
            Load += AdminAllRents_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCars;
        private Button GoBackBtn;
    }
}