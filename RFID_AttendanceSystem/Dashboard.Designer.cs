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
            panel2 = new Panel();
            panelSideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = SystemColors.ControlDark;
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
            btnLogout.Dock = DockStyle.Bottom;
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
            btnSettings.Dock = DockStyle.Top;
            btnSettings.Location = new Point(0, 331);
            btnSettings.Margin = new Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(219, 47);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.Location = new Point(0, 284);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(219, 47);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLiveView
            // 
            btnLiveView.Dock = DockStyle.Top;
            btnLiveView.Location = new Point(0, 237);
            btnLiveView.Margin = new Padding(3, 2, 3, 2);
            btnLiveView.Name = "btnLiveView";
            btnLiveView.Size = new Size(219, 47);
            btnLiveView.TabIndex = 3;
            btnLiveView.Text = "Live View";
            btnLiveView.UseVisualStyleBackColor = true;
            btnLiveView.Click += btnLiveView_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.Dock = DockStyle.Top;
            btnRegistration.Location = new Point(0, 190);
            btnRegistration.Margin = new Padding(3, 2, 3, 2);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(219, 47);
            btnRegistration.TabIndex = 2;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnReports_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(0, 143);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(219, 47);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnRegistration_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(219, 143);
            panelLogo.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(219, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(747, 511);
            panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 511);
            Controls.Add(panel2);
            Controls.Add(panelSideMenu);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panelSideMenu.ResumeLayout(false);
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
        private Panel panel2;
        private Button btnLogout;
    }
}