namespace RentalCarProj.Forms
{
    partial class OldRentBtn : Form
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
            components = new System.ComponentModel.Container();
            dataGridViewRents = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            SearchBtn = new Button();
            label4 = new Label();
            SearchTextBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRents
            // 
            dataGridViewRents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRents.Location = new Point(12, 139);
            dataGridViewRents.Name = "dataGridViewRents";
            dataGridViewRents.Size = new Size(527, 204);
            dataGridViewRents.TabIndex = 1;
            dataGridViewRents.CellContentClick += dataGridViewRents_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Location = new Point(166, 349);
            button1.Name = "button1";
            button1.Size = new Size(198, 59);
            button1.TabIndex = 2;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(399, 92);
            button2.Name = "button2";
            button2.Size = new Size(140, 34);
            button2.TabIndex = 3;
            button2.Text = "Finish Rent";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(255, 255, 192);
            SearchBtn.Location = new Point(399, 52);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(140, 34);
            SearchBtn.TabIndex = 16;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 80);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 15;
            label4.Text = "Search Rent";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(112, 80);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(268, 23);
            SearchTextBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(90, 9);
            label3.Name = "label3";
            label3.Size = new Size(350, 40);
            label3.TabIndex = 24;
            label3.Text = "Rental Car Management";
            // 
            // OldRentBtn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(596, 442);
            Controls.Add(label3);
            Controls.Add(SearchBtn);
            Controls.Add(label4);
            Controls.Add(SearchTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewRents);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OldRentBtn";
            Text = "You All Rents";
            Load += OldRentBtn_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRents;
        private Button button1;
        private Button button2;
        private Button SearchBtn;
        private Label label4;
        private TextBox SearchTextBox;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}