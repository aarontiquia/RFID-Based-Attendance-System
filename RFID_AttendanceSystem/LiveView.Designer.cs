namespace RFID_AttendanceSystem
{
    partial class LiveView
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
            components = new System.ComponentModel.Container();
            panel3 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            button2 = new Button();
            lblDate3 = new Label();
            lblTime3 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel5 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            lblStatus2 = new Label();
            lblTime2 = new Label();
            lblDate2 = new Label();
            lblProgram2 = new Label();
            lblStudId2 = new Label();
            lblName2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            lblStatus = new Label();
            lblTime = new Label();
            lblDate = new Label();
            lblProgram = new Label();
            lblStudId = new Label();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Location = new Point(441, 91);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 339);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(731, 61);
            panel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(button2);
            panel7.Controls.Add(lblDate3);
            panel7.Controls.Add(lblTime3);
            panel7.Controls.Add(button1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(471, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(260, 61);
            panel7.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(215, 31);
            button2.Name = "button2";
            button2.Size = new Size(39, 28);
            button2.TabIndex = 9;
            button2.Text = "Min";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblDate3
            // 
            lblDate3.AutoSize = true;
            lblDate3.Font = new Font("Segoe UI", 12F);
            lblDate3.Location = new Point(55, 9);
            lblDate3.Name = "lblDate3";
            lblDate3.Size = new Size(42, 21);
            lblDate3.TabIndex = 6;
            lblDate3.Text = "Date";
            // 
            // lblTime3
            // 
            lblTime3.AutoSize = true;
            lblTime3.Font = new Font("Segoe UI", 12F);
            lblTime3.Location = new Point(139, 33);
            lblTime3.Name = "lblTime3";
            lblTime3.Size = new Size(44, 21);
            lblTime3.TabIndex = 7;
            lblTime3.Text = "Time";
            // 
            // button1
            // 
            button1.Location = new Point(215, 4);
            button1.Name = "button1";
            button1.Size = new Size(39, 28);
            button1.TabIndex = 8;
            button1.Text = "Max";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 5;
            label1.Text = "School Name";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(428, 61);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(303, 411);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 411);
            panel1.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(lblStatus2);
            panel6.Controls.Add(lblTime2);
            panel6.Controls.Add(lblDate2);
            panel6.Controls.Add(lblProgram2);
            panel6.Controls.Add(lblStudId2);
            panel6.Controls.Add(lblName2);
            panel6.Controls.Add(pictureBox2);
            panel6.Location = new Point(32, 209);
            panel6.Name = "panel6";
            panel6.Size = new Size(372, 150);
            panel6.TabIndex = 7;
            // 
            // lblStatus2
            // 
            lblStatus2.AutoSize = true;
            lblStatus2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus2.Location = new Point(156, 102);
            lblStatus2.Name = "lblStatus2";
            lblStatus2.Size = new Size(44, 15);
            lblStatus2.TabIndex = 6;
            lblStatus2.Text = "In/Out";
            lblStatus2.Click += lblStatus2_Click;
            // 
            // lblTime2
            // 
            lblTime2.AutoSize = true;
            lblTime2.Font = new Font("Segoe UI", 12F);
            lblTime2.Location = new Point(270, 118);
            lblTime2.Name = "lblTime2";
            lblTime2.Size = new Size(44, 21);
            lblTime2.TabIndex = 5;
            lblTime2.Text = "Time";
            // 
            // lblDate2
            // 
            lblDate2.AutoSize = true;
            lblDate2.Font = new Font("Segoe UI", 12F);
            lblDate2.Location = new Point(206, 97);
            lblDate2.Name = "lblDate2";
            lblDate2.Size = new Size(108, 21);
            lblDate2.TabIndex = 4;
            lblDate2.Text = "MM/DD/YYYY";
            // 
            // lblProgram2
            // 
            lblProgram2.AutoSize = true;
            lblProgram2.Location = new Point(156, 53);
            lblProgram2.Name = "lblProgram2";
            lblProgram2.Size = new Size(53, 15);
            lblProgram2.TabIndex = 3;
            lblProgram2.Text = "Program";
            // 
            // lblStudId2
            // 
            lblStudId2.AutoSize = true;
            lblStudId2.Location = new Point(156, 38);
            lblStudId2.Name = "lblStudId2";
            lblStudId2.Size = new Size(62, 15);
            lblStudId2.TabIndex = 2;
            lblStudId2.Text = "Student ID";
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblName2.Location = new Point(156, 10);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(68, 28);
            lblName2.TabIndex = 1;
            lblName2.Text = "Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 150);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(lblTime);
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(lblProgram);
            panel2.Controls.Add(lblStudId);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(32, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 145);
            panel2.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(156, 102);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(44, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "In/Out";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F);
            lblTime.Location = new Point(270, 123);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(44, 21);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F);
            lblDate.Location = new Point(206, 96);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(108, 21);
            lblDate.TabIndex = 4;
            lblDate.Text = "MM/DD/YYYY";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(156, 53);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(53, 15);
            lblProgram.TabIndex = 3;
            lblProgram.Text = "Program";
            // 
            // lblStudId
            // 
            lblStudId.AutoSize = true;
            lblStudId.Location = new Point(156, 38);
            lblStudId.Name = "lblStudId";
            lblStudId.Size = new Size(62, 15);
            lblStudId.TabIndex = 2;
            lblStudId.Text = "Student ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblName.Location = new Point(156, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 145);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // LiveView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 472);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LiveView";
            Text = "LiveView";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label lblTime3;
        private Label lblDate3;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblDate;
        private Label lblProgram;
        private Label lblStudId;
        private Label lblName;
        private Label lblTime;
        private Panel panel6;
        private Label lblStatus2;
        private Label lblTime2;
        private Label lblDate2;
        private Label lblProgram2;
        private Label lblStudId2;
        private Label lblName2;
        private PictureBox pictureBox2;
        private Label lblStatus;
        private Button button1;
        private Panel panel7;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}