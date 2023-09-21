using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppLaunch
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            txtUsername.Text = AppLaunch.Properties.Settings.Default.username;
            txtPassword.Text = AppLaunch.Properties.Settings.Default.password;
            chkRemember.Checked = AppLaunch.Properties.Settings.Default.remember;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chkRemember.Checked)
            {
                AppLaunch.Properties.Settings.Default.username = txtUsername.Text.Trim();
                AppLaunch.Properties.Settings.Default.password = txtPassword.Text;
            }
            else
            {
                AppLaunch.Properties.Settings.Default.username = String.Empty;
                AppLaunch.Properties.Settings.Default.password = String.Empty;
            }

            AppLaunch.Properties.Settings.Default.remember = chkRemember.Checked;

            AppLaunch.Properties.Settings.Default.Save();

            this.Hide();
            Loader loader = new Loader(txtUsername.Text.Trim());
            loader.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
