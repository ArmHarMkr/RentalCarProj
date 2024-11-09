namespace RentalCarProj.Forms
{
    partial class AllUsers : Form
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
            SearchBtn = new Button();
            label4 = new Label();
            SearchTextBox = new TextBox();
            dataGridViewUsers = new DataGridView();
            textBox1 = new TextBox();
            label = new Label();
            GiveMoneyBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(255, 255, 128);
            SearchBtn.Location = new Point(281, 15);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(140, 40);
            SearchBtn.TabIndex = 14;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 28);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 13;
            label4.Text = "Search by Serial Number";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(12, 58);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(252, 23);
            SearchTextBox.TabIndex = 12;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 142);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(753, 273);
            dataGridViewUsers.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(513, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 15;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(513, 28);
            label.Name = "label";
            label.Size = new Size(110, 15);
            label.TabIndex = 16;
            label.Text = "Give Money to User";
            // 
            // GiveMoneyBtn
            // 
            GiveMoneyBtn.BackColor = Color.FromArgb(128, 255, 128);
            GiveMoneyBtn.Location = new Point(556, 79);
            GiveMoneyBtn.Name = "GiveMoneyBtn";
            GiveMoneyBtn.Size = new Size(140, 40);
            GiveMoneyBtn.TabIndex = 17;
            GiveMoneyBtn.Text = "Give Money";
            GiveMoneyBtn.UseVisualStyleBackColor = false;
            GiveMoneyBtn.Click += GiveMoneyBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(281, 421);
            button1.Name = "button1";
            button1.Size = new Size(255, 69);
            button1.TabIndex = 18;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(281, 61);
            button2.Name = "button2";
            button2.Size = new Size(140, 40);
            button2.TabIndex = 19;
            button2.Text = "Show All Users";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AllUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(GiveMoneyBtn);
            Controls.Add(label);
            Controls.Add(textBox1);
            Controls.Add(SearchBtn);
            Controls.Add(label4);
            Controls.Add(SearchTextBox);
            Controls.Add(dataGridViewUsers);
            Name = "AllUsers";
            Text = "AllUsers";
            Load += AllUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchBtn;
        private Label label4;
        private TextBox SearchTextBox;
        private DataGridView dataGridViewUsers;
        private TextBox textBox1;
        private Label label;
        private Button GiveMoneyBtn;
        private Button button1;
        private Button button2;
    }
}