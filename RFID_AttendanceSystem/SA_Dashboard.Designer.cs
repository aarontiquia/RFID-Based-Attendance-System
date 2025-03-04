namespace RFID_AttendanceSystem
{
    partial class SA_Dashboard
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
            panelDashboardSA = new Panel();
            panelSideMenu = new Panel();
            btnLogoutSA = new Button();
            btnSettingsSA = new Button();
            btnReportsSA = new Button();
            btnRegistrationSA = new Button();
            btnDashboardSA = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelDashboardSA
            // 
            panelDashboardSA.Dock = DockStyle.Fill;
            panelDashboardSA.Location = new Point(219, 0);
            panelDashboardSA.Margin = new Padding(3, 2, 3, 2);
            panelDashboardSA.Name = "panelDashboardSA";
            panelDashboardSA.Size = new Size(747, 511);
            panelDashboardSA.TabIndex = 3;
            panelDashboardSA.Paint += panelDashboardSA_Paint;
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(0, 0, 64);
            panelSideMenu.Controls.Add(btnLogoutSA);
            panelSideMenu.Controls.Add(btnSettingsSA);
            panelSideMenu.Controls.Add(btnReportsSA);
            panelSideMenu.Controls.Add(btnRegistrationSA);
            panelSideMenu.Controls.Add(btnDashboardSA);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Margin = new Padding(3, 2, 3, 2);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(219, 511);
            panelSideMenu.TabIndex = 2;
            // 
            // btnLogoutSA
            // 
            btnLogoutSA.Cursor = Cursors.Hand;
            btnLogoutSA.Dock = DockStyle.Bottom;
            btnLogoutSA.FlatAppearance.BorderSize = 0;
            btnLogoutSA.FlatStyle = FlatStyle.Flat;
            btnLogoutSA.Font = new Font("Arial", 9F);
            btnLogoutSA.ForeColor = Color.White;
            btnLogoutSA.Image = Properties.Resources.logout;
            btnLogoutSA.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogoutSA.Location = new Point(0, 476);
            btnLogoutSA.Margin = new Padding(3, 2, 3, 2);
            btnLogoutSA.Name = "btnLogoutSA";
            btnLogoutSA.Size = new Size(219, 35);
            btnLogoutSA.TabIndex = 6;
            btnLogoutSA.Text = "Logout";
            btnLogoutSA.UseVisualStyleBackColor = true;
            // 
            // btnSettingsSA
            // 
            btnSettingsSA.Cursor = Cursors.Hand;
            btnSettingsSA.Dock = DockStyle.Top;
            btnSettingsSA.FlatAppearance.BorderSize = 0;
            btnSettingsSA.FlatStyle = FlatStyle.Flat;
            btnSettingsSA.Font = new Font("Arial", 9F);
            btnSettingsSA.ForeColor = Color.White;
            btnSettingsSA.Image = Properties.Resources.setting;
            btnSettingsSA.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettingsSA.Location = new Point(0, 272);
            btnSettingsSA.Margin = new Padding(3, 2, 3, 2);
            btnSettingsSA.Name = "btnSettingsSA";
            btnSettingsSA.Size = new Size(219, 43);
            btnSettingsSA.TabIndex = 5;
            btnSettingsSA.Text = "Settings";
            btnSettingsSA.UseVisualStyleBackColor = true;
            btnSettingsSA.Click += btnSettingsSA_Click;
            // 
            // btnReportsSA
            // 
            btnReportsSA.Cursor = Cursors.Hand;
            btnReportsSA.Dock = DockStyle.Top;
            btnReportsSA.FlatAppearance.BorderSize = 0;
            btnReportsSA.FlatStyle = FlatStyle.Flat;
            btnReportsSA.Font = new Font("Arial", 9F);
            btnReportsSA.ForeColor = Color.White;
            btnReportsSA.Image = Properties.Resources.file__1_;
            btnReportsSA.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportsSA.Location = new Point(0, 229);
            btnReportsSA.Margin = new Padding(3, 2, 3, 2);
            btnReportsSA.Name = "btnReportsSA";
            btnReportsSA.Size = new Size(219, 43);
            btnReportsSA.TabIndex = 4;
            btnReportsSA.Text = "Reports";
            btnReportsSA.UseVisualStyleBackColor = true;
            btnReportsSA.Click += btnReportsSA_Click;
            // 
            // btnRegistrationSA
            // 
            btnRegistrationSA.Cursor = Cursors.Hand;
            btnRegistrationSA.Dock = DockStyle.Top;
            btnRegistrationSA.FlatAppearance.BorderSize = 0;
            btnRegistrationSA.FlatStyle = FlatStyle.Flat;
            btnRegistrationSA.Font = new Font("Arial", 9F);
            btnRegistrationSA.ForeColor = Color.White;
            btnRegistrationSA.Image = Properties.Resources.add_user__1_;
            btnRegistrationSA.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrationSA.Location = new Point(0, 186);
            btnRegistrationSA.Margin = new Padding(3, 2, 3, 2);
            btnRegistrationSA.Name = "btnRegistrationSA";
            btnRegistrationSA.Size = new Size(219, 43);
            btnRegistrationSA.TabIndex = 2;
            btnRegistrationSA.Text = "Registration";
            btnRegistrationSA.UseVisualStyleBackColor = true;
            btnRegistrationSA.Click += btnRegistrationSA_Click;
            // 
            // btnDashboardSA
            // 
            btnDashboardSA.Cursor = Cursors.Hand;
            btnDashboardSA.Dock = DockStyle.Top;
            btnDashboardSA.FlatAppearance.BorderSize = 0;
            btnDashboardSA.FlatStyle = FlatStyle.Flat;
            btnDashboardSA.Font = new Font("Arial", 9F);
            btnDashboardSA.ForeColor = Color.White;
            btnDashboardSA.Image = Properties.Resources.dashboard;
            btnDashboardSA.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboardSA.Location = new Point(0, 143);
            btnDashboardSA.Margin = new Padding(3, 2, 3, 2);
            btnDashboardSA.Name = "btnDashboardSA";
            btnDashboardSA.Size = new Size(219, 43);
            btnDashboardSA.TabIndex = 1;
            btnDashboardSA.Text = "Dashboard";
            btnDashboardSA.UseVisualStyleBackColor = true;
            btnDashboardSA.Click += btnDashboardSA_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 0, 64);
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(219, 143);
            panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 102);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Super Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(77, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 66);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SA_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 511);
            Controls.Add(panelDashboardSA);
            Controls.Add(panelSideMenu);
            Name = "SA_Dashboard";
            Text = "SA_Dashboard";
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDashboardSA;
        private Panel panelSideMenu;
        private Button btnLogoutSA;
        private Button btnSettingsSA;
        private Button btnReportsSA;
        private Button btnRegistrationSA;
        private Button btnDashboardSA;
        private Panel panelLogo;
        private Label label1;
        private PictureBox pictureBox1;
    }
}