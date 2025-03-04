namespace RFID_AttendanceSystem
{
    partial class SA_DashboardPanel
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
            label9 = new Label();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoEllipsis = true;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F);
            label9.Location = new Point(56, 161);
            label9.Name = "label9";
            label9.Size = new Size(96, 18);
            label9.TabIndex = 5;
            label9.Text = "Recent Logs";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Date";
            Column4.Name = "Column4";
            Column4.Width = 54;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Log";
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.Width = 41;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(60, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(615, 266);
            dataGridView1.TabIndex = 9;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Time";
            Column5.Name = "Column5";
            Column5.Width = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(3, 11);
            label8.Name = "label8";
            label8.Size = new Size(39, 18);
            label8.TabIndex = 1;
            label8.Text = "Late";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.LightSalmon;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(546, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(164, 79);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.LightCoral;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(373, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(164, 79);
            panel3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(57, 18);
            label6.TabIndex = 1;
            label6.Text = "Absent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 1;
            label4.Text = "Present";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(200, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 79);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold);
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(155, 24);
            label2.TabIndex = 1;
            label2.Text = "# of Employees";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(86, 18);
            label1.TabIndex = 1;
            label1.Text = "Employees";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(26, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 79);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F, FontStyle.Bold);
            label3.Location = new Point(3, 32);
            label3.Name = "label3";
            label3.Size = new Size(155, 24);
            label3.TabIndex = 2;
            label3.Text = "# of Employees";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15F, FontStyle.Bold);
            label5.Location = new Point(3, 32);
            label5.Name = "label5";
            label5.Size = new Size(155, 24);
            label5.TabIndex = 1;
            label5.Text = "# of Employees";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold);
            label7.Location = new Point(3, 32);
            label7.Name = "label7";
            label7.Size = new Size(155, 24);
            label7.TabIndex = 1;
            label7.Text = "# of Employees";
            // 
            // SA_DashboardPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 472);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SA_DashboardPanel";
            Text = "SA_DashboardPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column5;
        private Label label8;
        private Panel panel4;
        private Panel panel3;
        private Label label6;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label3;
    }
}