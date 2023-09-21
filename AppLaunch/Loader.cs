using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using AppLaunch.Properties;

namespace AppLaunch
{
    public partial class Loader : Form
    {
        private string username;

        public Loader(string loginName)
        {
           this.username = loginName;

            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            chkremapp.Checked = AppLaunch.Properties.Settings.Default.rememberApp;

            if (IsAppSel.SelectedIndex == -1 && IsAppSel.Items.Count > 0)
            {
                IsAppSel.SelectedIndex = 0;

                btnLoad.Enabled = true;
            }

            if (AppLaunch.Properties.Settings.Default.rememberApp)
            {
                IsAppSel.SelectedIndex = Settings.Default.selectedApp;
            }


            lblWelcome.Text = lblWelcome.Text.Replace("{username}", username);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string appanme;

        private void lstCheats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsAppSel.SelectedItem.ToString() == "Your Project Name Here")
            {
                lblGameName.Text = "You App Name";
                lblVersion.Text = "Version: ";
                verinfo.Text = "1.2.3.4";
                verinfo.ForeColor = Color.Yellow;
                whatstat.Text = "Beta Access";
                whatstat.ForeColor = Color.LimeGreen;
                appanme = "app.exe";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (chkremapp.Checked && IsAppSel.Items.Count > 0)
            {
                AppLaunch.Properties.Settings.Default.selectedApp = IsAppSel.SelectedIndex;
            }
            else
            {
                AppLaunch.Properties.Settings.Default.selectedApp = 0;
            }
            AppLaunch.Properties.Settings.Default.rememberApp = chkremapp.Checked;
            AppLaunch.Properties.Settings.Default.Save();

            this.Hide();
            PleaseWait inject = new PleaseWait();
            inject.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
