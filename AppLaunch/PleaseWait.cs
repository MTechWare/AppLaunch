using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppLaunch
{
    public partial class PleaseWait : Form
    {
        public PleaseWait()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            tmrLoad.Interval = 2000;
            tmrLoad.Start();

            this.CenterToScreen();
        }
        bool stop = false;

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            if (stop)
            {
                tmrLoad.Stop();
                this.Hide();
                Login updater = new Login();
                updater.ShowDialog();
                this.Close();
            }
            stop = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
