namespace RFID_AttendanceSystem
{
    partial class Reports
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
            panel1 = new Panel();
            aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            poisonDropDownButton1 = new ReaLTaiizor.Controls.PoisonDropDownButton();
            label3 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnExport = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(aloneTextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 41);
            panel1.TabIndex = 0;
            // 
            // aloneTextBox1
            // 
            aloneTextBox1.BackColor = Color.Transparent;
            aloneTextBox1.EnabledCalc = true;
            aloneTextBox1.Font = new Font("Segoe UI", 9F);
            aloneTextBox1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneTextBox1.Location = new Point(10, 9);
            aloneTextBox1.MaxLength = 32767;
            aloneTextBox1.MultiLine = false;
            aloneTextBox1.Name = "aloneTextBox1";
            aloneTextBox1.ReadOnly = false;
            aloneTextBox1.Size = new Size(241, 23);
            aloneTextBox1.TabIndex = 3;
            aloneTextBox1.Text = "Search";
            aloneTextBox1.TextAlign = HorizontalAlignment.Left;
            aloneTextBox1.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Select Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(73, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Filter:";
            // 
            // poisonDropDownButton1
            // 
            poisonDropDownButton1.AutoSize = true;
            poisonDropDownButton1.Location = new Point(313, 5);
            poisonDropDownButton1.Name = "poisonDropDownButton1";
            poisonDropDownButton1.Size = new Size(152, 25);
            poisonDropDownButton1.TabIndex = 7;
            poisonDropDownButton1.Text = "poisonDropDownButton1";
            poisonDropDownButton1.UseSelectable = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 9);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Filter:";
            // 
            // panel2
            // 
            panel2.Controls.Add(poisonDropDownButton1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 35);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(731, 396);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Student ID";
            Column1.Name = "Column1";
            Column1.Width = 87;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Program";
            Column3.Name = "Column3";
            Column3.Width = 78;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Time In";
            Column4.Name = "Column4";
            Column4.Width = 72;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Time Out";
            Column5.Name = "Column5";
            Column5.Width = 82;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Status";
            Column6.Name = "Column6";
            Column6.Width = 64;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(644, 9);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 472);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Reports";
            Text = "Reports";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private ReaLTaiizor.Controls.PoisonDropDownButton poisonDropDownButton1;
        private Label label3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnExport;
    }
}