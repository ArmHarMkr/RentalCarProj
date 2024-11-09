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
    public partial class LoadingBar : Form
    {
        public LoadingBar()
        {
            InitializeComponent();
            progressBarLoading.Style = ProgressBarStyle.Continuous;
            progressBarLoading.Minimum = 0;
            progressBarLoading.Maximum = 100;
        }

        public async Task ShowLoading()
        {
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(30);
                progressBarLoading.Value = i;
            }
        }

        private void LoadingBar_Load(object sender, EventArgs e)
        {

        }
    }
}
