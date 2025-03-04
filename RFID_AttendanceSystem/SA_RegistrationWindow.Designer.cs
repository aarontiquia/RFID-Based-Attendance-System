namespace RFID_AttendanceSystem
{
    partial class SA_RegistrationWindow
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
            btnCancelSA = new Button();
            btnBrowseSA = new Button();
            btnSaveSA = new Button();
            pictureBox2 = new PictureBox();
            dateTimePicker1SA = new DateTimePicker();
            txtBoxDepartmentSA = new TextBox();
            txtBoxRFIDSA = new TextBox();
            txtBoxNameSA = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtBoxStudIdSA = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelSA
            // 
            btnCancelSA.Anchor = AnchorStyles.Bottom;
            btnCancelSA.Cursor = Cursors.Hand;
            btnCancelSA.Font = new Font("Arial", 9F);
            btnCancelSA.ForeColor = Color.Firebrick;
            btnCancelSA.Location = new Point(366, 376);
            btnCancelSA.Name = "btnCancelSA";
            btnCancelSA.Size = new Size(105, 34);
            btnCancelSA.TabIndex = 28;
            btnCancelSA.Text = "Cancel";
            btnCancelSA.UseVisualStyleBackColor = true;
            // 
            // btnBrowseSA
            // 
            btnBrowseSA.Anchor = AnchorStyles.None;
            btnBrowseSA.Cursor = Cursors.Hand;
            btnBrowseSA.Font = new Font("Arial", 9F);
            btnBrowseSA.Location = new Point(59, 300);
            btnBrowseSA.Name = "btnBrowseSA";
            btnBrowseSA.Size = new Size(245, 23);
            btnBrowseSA.TabIndex = 26;
            btnBrowseSA.Text = "Browse";
            btnBrowseSA.UseVisualStyleBackColor = true;
            // 
            // btnSaveSA
            // 
            btnSaveSA.Anchor = AnchorStyles.Bottom;
            btnSaveSA.Cursor = Cursors.Hand;
            btnSaveSA.Font = new Font("Arial", 9F);
            btnSaveSA.ForeColor = Color.Green;
            btnSaveSA.Location = new Point(227, 376);
            btnSaveSA.Name = "btnSaveSA";
            btnSaveSA.Size = new Size(105, 34);
            btnSaveSA.TabIndex = 27;
            btnSaveSA.Text = "Save";
            btnSaveSA.UseVisualStyleBackColor = true;
            btnSaveSA.Click += btnSaveSA_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Location = new Point(59, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 209);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // dateTimePicker1SA
            // 
            dateTimePicker1SA.Anchor = AnchorStyles.None;
            dateTimePicker1SA.Cursor = Cursors.Hand;
            dateTimePicker1SA.Location = new Point(348, 300);
            dateTimePicker1SA.Name = "dateTimePicker1SA";
            dateTimePicker1SA.Size = new Size(323, 23);
            dateTimePicker1SA.TabIndex = 24;
            // 
            // txtBoxDepartmentSA
            // 
            txtBoxDepartmentSA.Anchor = AnchorStyles.None;
            txtBoxDepartmentSA.Cursor = Cursors.IBeam;
            txtBoxDepartmentSA.Font = new Font("Arial", 9F);
            txtBoxDepartmentSA.Location = new Point(348, 247);
            txtBoxDepartmentSA.Name = "txtBoxDepartmentSA";
            txtBoxDepartmentSA.Size = new Size(323, 21);
            txtBoxDepartmentSA.TabIndex = 23;
            // 
            // txtBoxRFIDSA
            // 
            txtBoxRFIDSA.Anchor = AnchorStyles.None;
            txtBoxRFIDSA.Cursor = Cursors.IBeam;
            txtBoxRFIDSA.Font = new Font("Arial", 9F);
            txtBoxRFIDSA.Location = new Point(348, 203);
            txtBoxRFIDSA.Name = "txtBoxRFIDSA";
            txtBoxRFIDSA.Size = new Size(323, 21);
            txtBoxRFIDSA.TabIndex = 22;
            // 
            // txtBoxNameSA
            // 
            txtBoxNameSA.Anchor = AnchorStyles.None;
            txtBoxNameSA.Cursor = Cursors.IBeam;
            txtBoxNameSA.Font = new Font("Arial", 9F);
            txtBoxNameSA.Location = new Point(348, 159);
            txtBoxNameSA.Name = "txtBoxNameSA";
            txtBoxNameSA.Size = new Size(323, 21);
            txtBoxNameSA.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F);
            label6.Location = new Point(348, 273);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 20;
            label6.Text = "Date";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(348, 185);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 18;
            label4.Text = "RFID Tag";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(348, 141);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 17;
            label3.Text = "Name";
            // 
            // txtBoxStudIdSA
            // 
            txtBoxStudIdSA.Anchor = AnchorStyles.None;
            txtBoxStudIdSA.Cursor = Cursors.IBeam;
            txtBoxStudIdSA.Font = new Font("Arial", 9F);
            txtBoxStudIdSA.Location = new Point(348, 115);
            txtBoxStudIdSA.Name = "txtBoxStudIdSA";
            txtBoxStudIdSA.Size = new Size(323, 21);
            txtBoxStudIdSA.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(348, 97);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 15;
            label1.Text = "Employee ID";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.close;
            button1.Location = new Point(694, 7);
            button1.Name = "button1";
            button1.Size = new Size(31, 28);
            button1.TabIndex = 2;
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(166, 18);
            label2.TabIndex = 1;
            label2.Text = "Employee Registration";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F);
            label5.Location = new Point(348, 229);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 19;
            label5.Text = "Department";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 43);
            panel1.TabIndex = 14;
            // 
            // SA_RegistrationWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 472);
            Controls.Add(btnCancelSA);
            Controls.Add(btnBrowseSA);
            Controls.Add(btnSaveSA);
            Controls.Add(pictureBox2);
            Controls.Add(dateTimePicker1SA);
            Controls.Add(txtBoxDepartmentSA);
            Controls.Add(txtBoxRFIDSA);
            Controls.Add(txtBoxNameSA);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBoxStudIdSA);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SA_RegistrationWindow";
            Text = "SA_RegistrationWindow";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelSA;
        private Button btnBrowseSA;
        private Button btnSaveSA;
        private PictureBox pictureBox2;
        private DateTimePicker dateTimePicker1SA;
        private TextBox txtBoxDepartmentSA;
        private TextBox txtBoxRFIDSA;
        private TextBox txtBoxNameSA;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txtBoxStudIdSA;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label5;
        private Panel panel1;
    }
}