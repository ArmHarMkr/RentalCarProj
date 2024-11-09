namespace RentalCarProj.Forms
{
    partial class LoadingBar : Form
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
            progressBarLoading = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // progressBarLoading
            // 
            progressBarLoading.Location = new Point(12, 157);
            progressBarLoading.Name = "progressBarLoading";
            progressBarLoading.Size = new Size(530, 31);
            progressBarLoading.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(180, 31);
            label1.Name = "label1";
            label1.Size = new Size(182, 40);
            label1.TabIndex = 1;
            label1.Text = "LOADING...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(143, 93);
            label2.Name = "label2";
            label2.Size = new Size(236, 40);
            label2.TabIndex = 2;
            label2.Text = "GETTING DATA";
            // 
            // LoadingBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(564, 225);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBarLoading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingBar";
            Text = "Loading...";
            Load += LoadingBar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBarLoading;
        private Label label1;
        private Label label2;
    }
}