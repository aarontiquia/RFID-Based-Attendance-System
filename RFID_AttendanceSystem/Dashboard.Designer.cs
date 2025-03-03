namespace RFID_AttendanceSystem
{
    partial class Dashboard
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
            panelSideMenu = new Panel();
            btnLogout = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnLiveView = new Button();
            btnRegistration = new Button();
            btnDashboard = new Button();
            panelLogo = new Panel();
            panelDashboard = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(10, 50, 57);
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Controls.Add(btnSettings);
            panelSideMenu.Controls.Add(btnReports);
            panelSideMenu.Controls.Add(btnLiveView);
            panelSideMenu.Controls.Add(btnRegistration);
            panelSideMenu.Controls.Add(btnDashboard);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Margin = new Padding(3, 2, 3, 2);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(219, 511);
            panelSideMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 476);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(219, 35);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Arial", 9F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = Properties.Resources.setting;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 315);
            btnSettings.Margin = new Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(219, 43);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Arial", 9F);
            btnReports.ForeColor = Color.White;
            btnReports.Image = Properties.Resources.file__1_;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 272);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(219, 43);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLiveView
            // 
            btnLiveView.Cursor = Cursors.Hand;
            btnLiveView.Dock = DockStyle.Top;
            btnLiveView.FlatAppearance.BorderSize = 0;
            btnLiveView.FlatStyle = FlatStyle.Flat;
            btnLiveView.Font = new Font("Arial", 9F);
            btnLiveView.ForeColor = Color.White;
            btnLiveView.Image = Properties.Resources.website;
            btnLiveView.ImageAlign = ContentAlignment.MiddleLeft;
            btnLiveView.Location = new Point(0, 229);
            btnLiveView.Margin = new Padding(3, 2, 3, 2);
            btnLiveView.Name = "btnLiveView";
            btnLiveView.Size = new Size(219, 43);
            btnLiveView.TabIndex = 3;
            btnLiveView.Text = "Live View";
            btnLiveView.UseVisualStyleBackColor = true;
            btnLiveView.Click += btnLiveView_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.Cursor = Cursors.Hand;
            btnRegistration.Dock = DockStyle.Top;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistration.Font = new Font("Arial", 9F);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Image = Properties.Resources.add_user__1_;
            btnRegistration.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistration.Location = new Point(0, 186);
            btnRegistration.Margin = new Padding(3, 2, 3, 2);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(219, 43);
            btnRegistration.TabIndex = 2;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial", 9F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 143);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(219, 43);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(10, 50, 57);
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(219, 143);
            panelLogo.TabIndex = 1;
            // 
            // panelDashboard
            // 
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(219, 0);
            panelDashboard.Margin = new Padding(3, 2, 3, 2);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(747, 511);
            panelDashboard.TabIndex = 1;
            panelDashboard.Paint += panelDashboard_Paint;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 103);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 511);
            Controls.Add(panelDashboard);
            Controls.Add(panelSideMenu);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnLiveView;
        private Button btnRegistration;
        private Button btnDashboard;
        private Panel panelLogo;
        private Button btnReports;
        private Button btnSettings;
        private Panel panelDashboard;
        private Button btnLogout;
        private Label label1;
        private PictureBox pictureBox1;
    }
}