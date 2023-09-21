namespace AppLaunch
{
    partial class Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSelectCheat = new System.Windows.Forms.Label();
            this.IsAppSel = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpGameInfo = new System.Windows.Forms.GroupBox();
            this.verinfo = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.whatstat = new System.Windows.Forms.Label();
            this.chkremapp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpGameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-209, -51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 181);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(108, 67);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(277, 23);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome {username}";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectCheat
            // 
            this.lblSelectCheat.AutoSize = true;
            this.lblSelectCheat.ForeColor = System.Drawing.Color.White;
            this.lblSelectCheat.Location = new System.Drawing.Point(18, 72);
            this.lblSelectCheat.Name = "lblSelectCheat";
            this.lblSelectCheat.Size = new System.Drawing.Size(90, 13);
            this.lblSelectCheat.TabIndex = 5;
            this.lblSelectCheat.Text = "Projects available";
            // 
            // IsAppSel
            // 
            this.IsAppSel.FormattingEnabled = true;
            this.IsAppSel.Items.AddRange(new object[] {
            "Your Project Name Here"});
            this.IsAppSel.Location = new System.Drawing.Point(21, 91);
            this.IsAppSel.Name = "IsAppSel";
            this.IsAppSel.ScrollAlwaysVisible = true;
            this.IsAppSel.Size = new System.Drawing.Size(364, 82);
            this.IsAppSel.TabIndex = 6;
            this.IsAppSel.SelectedIndexChanged += new System.EventHandler(this.lstCheats_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(191, 185);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(194, 29);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpGameInfo
            // 
            this.grpGameInfo.Controls.Add(this.verinfo);
            this.grpGameInfo.Controls.Add(this.lblVersion);
            this.grpGameInfo.Controls.Add(this.lblStatusLabel);
            this.grpGameInfo.Controls.Add(this.lblGameName);
            this.grpGameInfo.Controls.Add(this.whatstat);
            this.grpGameInfo.ForeColor = System.Drawing.Color.White;
            this.grpGameInfo.Location = new System.Drawing.Point(21, 179);
            this.grpGameInfo.Name = "grpGameInfo";
            this.grpGameInfo.Size = new System.Drawing.Size(155, 82);
            this.grpGameInfo.TabIndex = 9;
            this.grpGameInfo.TabStop = false;
            this.grpGameInfo.Text = "App Infomation";
            // 
            // verinfo
            // 
            this.verinfo.AutoSize = true;
            this.verinfo.ForeColor = System.Drawing.Color.White;
            this.verinfo.Location = new System.Drawing.Point(62, 37);
            this.verinfo.Name = "verinfo";
            this.verinfo.Size = new System.Drawing.Size(40, 13);
            this.verinfo.TabIndex = 4;
            this.verinfo.Text = "1.2.3.4";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(15, 37);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version:";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.ForeColor = System.Drawing.Color.White;
            this.lblStatusLabel.Location = new System.Drawing.Point(15, 57);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.lblStatusLabel.TabIndex = 2;
            this.lblStatusLabel.Text = "Status:";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(15, 17);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(10, 13);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "-";
            // 
            // whatstat
            // 
            this.whatstat.AutoSize = true;
            this.whatstat.ForeColor = System.Drawing.Color.White;
            this.whatstat.Location = new System.Drawing.Point(51, 57);
            this.whatstat.Name = "whatstat";
            this.whatstat.Size = new System.Drawing.Size(40, 13);
            this.whatstat.TabIndex = 3;
            this.whatstat.Text = "Status:";
            // 
            // chkremapp
            // 
            this.chkremapp.AutoSize = true;
            this.chkremapp.ForeColor = System.Drawing.Color.White;
            this.chkremapp.Location = new System.Drawing.Point(21, 267);
            this.chkremapp.Name = "chkremapp";
            this.chkremapp.Size = new System.Drawing.Size(143, 17);
            this.chkremapp.TabIndex = 11;
            this.chkremapp.Text = "Remember app selection";
            this.chkremapp.UseVisualStyleBackColor = true;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(401, 295);
            this.Controls.Add(this.chkremapp);
            this.Controls.Add(this.grpGameInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.IsAppSel);
            this.Controls.Add(this.lblSelectCheat);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Loader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpGameInfo.ResumeLayout(false);
            this.grpGameInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSelectCheat;
        private System.Windows.Forms.ListBox IsAppSel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpGameInfo;
        private System.Windows.Forms.CheckBox chkremapp;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label whatstat;
        private System.Windows.Forms.Label verinfo;
        private System.Windows.Forms.Label lblGameName;
    }
}