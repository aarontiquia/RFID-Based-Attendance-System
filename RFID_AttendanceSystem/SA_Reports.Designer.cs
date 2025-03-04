namespace RFID_AttendanceSystem
{
    partial class SA_Reports
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
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            btnExport = new Button();
            dateTimePicker1 = new DateTimePicker();
            poisonDropDownButton1 = new ReaLTaiizor.Controls.PoisonDropDownButton();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Select Date:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.search__2_;
            button1.Location = new Point(220, 10);
            button1.Name = "button1";
            button1.Size = new Size(33, 23);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Arial", 9F);
            textBox1.Location = new Point(12, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 21);
            textBox1.TabIndex = 5;
            // 
            // btnExport
            // 
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Arial", 12F);
            btnExport.ForeColor = Color.White;
            btnExport.Image = Properties.Resources.export;
            btnExport.ImageAlign = ContentAlignment.MiddleRight;
            btnExport.Location = new Point(636, 8);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(90, 28);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.TextAlign = ContentAlignment.MiddleLeft;
            btnExport.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(73, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
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
            // panel2
            // 
            panel2.Controls.Add(poisonDropDownButton1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 35);
            panel2.TabIndex = 5;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnExport);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 43);
            panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(731, 394);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Student ID";
            Column1.Name = "Column1";
            Column1.Width = 85;
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
            Column3.Width = 76;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Time In";
            Column4.Name = "Column4";
            Column4.Width = 70;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Time Out";
            Column5.Name = "Column5";
            Column5.Width = 80;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Status";
            Column6.Name = "Column6";
            Column6.Width = 62;
            // 
            // SA_Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 472);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SA_Reports";
            Text = "SA_Reports";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Button btnExport;
        private DateTimePicker dateTimePicker1;
        private ReaLTaiizor.Controls.PoisonDropDownButton poisonDropDownButton1;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}