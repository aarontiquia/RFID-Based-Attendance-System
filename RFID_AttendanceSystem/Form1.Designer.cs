namespace RFID_AttendanceSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            aloneTextBox2 = new ReaLTaiizor.Controls.AloneTextBox();
            smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            foxLinkLabel1 = new ReaLTaiizor.Controls.FoxLinkLabel();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.None;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(70, 79);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(387, 46);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "RFID Attendance System";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1088, 508);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // aloneTextBox1
            // 
            aloneTextBox1.Anchor = AnchorStyles.None;
            aloneTextBox1.BackColor = Color.Transparent;
            aloneTextBox1.EnabledCalc = true;
            aloneTextBox1.Font = new Font("Segoe UI", 9F);
            aloneTextBox1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneTextBox1.Location = new Point(144, 184);
            aloneTextBox1.MaxLength = 32767;
            aloneTextBox1.MultiLine = false;
            aloneTextBox1.Name = "aloneTextBox1";
            aloneTextBox1.ReadOnly = false;
            aloneTextBox1.Size = new Size(239, 37);
            aloneTextBox1.TabIndex = 2;
            aloneTextBox1.Text = "Username";
            aloneTextBox1.TextAlign = HorizontalAlignment.Left;
            aloneTextBox1.UseSystemPasswordChar = false;
            // 
            // aloneTextBox2
            // 
            aloneTextBox2.Anchor = AnchorStyles.None;
            aloneTextBox2.BackColor = Color.Transparent;
            aloneTextBox2.EnabledCalc = true;
            aloneTextBox2.Font = new Font("Segoe UI", 9F);
            aloneTextBox2.ForeColor = Color.FromArgb(124, 133, 142);
            aloneTextBox2.Location = new Point(144, 251);
            aloneTextBox2.MaxLength = 32767;
            aloneTextBox2.MultiLine = false;
            aloneTextBox2.Name = "aloneTextBox2";
            aloneTextBox2.ReadOnly = false;
            aloneTextBox2.Size = new Size(239, 37);
            aloneTextBox2.TabIndex = 3;
            aloneTextBox2.Text = "Password";
            aloneTextBox2.TextAlign = HorizontalAlignment.Left;
            aloneTextBox2.UseSystemPasswordChar = false;
            // 
            // smallLabel1
            // 
            smallLabel1.Anchor = AnchorStyles.None;
            smallLabel1.AutoSize = true;
            smallLabel1.BackColor = Color.Transparent;
            smallLabel1.Font = new Font("Segoe UI", 8F);
            smallLabel1.ForeColor = Color.FromArgb(142, 142, 142);
            smallLabel1.Location = new Point(284, 303);
            smallLabel1.Name = "smallLabel1";
            smallLabel1.Size = new Size(99, 13);
            smallLabel1.TabIndex = 4;
            smallLabel1.Text = "Forgot Password?";
            // 
            // foxLinkLabel1
            // 
            foxLinkLabel1.Anchor = AnchorStyles.None;
            foxLinkLabel1.BackColor = Color.Transparent;
            foxLinkLabel1.DownColor = Color.FromArgb(255, 149, 0);
            foxLinkLabel1.EnabledCalc = true;
            foxLinkLabel1.Font = new Font("Segoe UI", 10F);
            foxLinkLabel1.ForeColor = Color.FromArgb(0, 149, 221);
            foxLinkLabel1.Location = new Point(342, 261);
            foxLinkLabel1.Name = "foxLinkLabel1";
            foxLinkLabel1.OverColor = Color.FromArgb(23, 140, 229);
            foxLinkLabel1.Size = new Size(33, 18);
            foxLinkLabel1.TabIndex = 5;
            foxLinkLabel1.Text = "Show";
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.None;
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(185, 349);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(143, 36);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "Login";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 508);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(bigLabel1);
            panel2.Controls.Add(aloneTextBox1);
            panel2.Controls.Add(materialButton1);
            panel2.Controls.Add(foxLinkLabel1);
            panel2.Controls.Add(smallLabel1);
            panel2.Controls.Add(aloneTextBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 508);
            panel2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 508);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox2;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ReaLTaiizor.Controls.FoxLinkLabel foxLinkLabel1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private Panel panel1;
        private Panel panel2;
    }
}
