namespace RentalCarProj.Forms
{
    partial class Login : Form
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
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(12, 162);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(256, 23);
            PasswordTextBox.TabIndex = 21;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(12, 96);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(256, 23);
            EmailTextBox.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(58, 219);
            button1.Name = "button1";
            button1.Size = new Size(155, 53);
            button1.TabIndex = 17;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(47, 285);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(190, 21);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Have an Account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 26;
            label4.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(15, 72);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 24;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLight;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(49, 9);
            label8.Name = "label8";
            label8.Size = new Size(164, 45);
            label8.TabIndex = 23;
            label8.Text = "Car Rental";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(285, 347);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(button1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label7;
        private Label label8;
    }
}