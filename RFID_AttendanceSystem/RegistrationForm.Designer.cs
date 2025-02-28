namespace RFID_AttendanceSystem
{
    partial class RegistrationForm
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
            label2 = new Label();
            panel2 = new Panel();
            btnCreateNew = new Button();
            dataGridView1 = new DataGridView();
            colStudId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colRFIDtag = new DataGridViewTextBoxColumn();
            colProgram = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 47);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 14);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 0;
            label2.Text = "Student Registration";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCreateNew);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 33);
            panel2.TabIndex = 1;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(3, 2);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(104, 30);
            btnCreateNew.TabIndex = 0;
            btnCreateNew.Text = "Create New";
            btnCreateNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colStudId, colName, colRFIDtag, colProgram, colDate, colEdit, colDelete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(731, 392);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colStudId
            // 
            colStudId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colStudId.HeaderText = "Student ID";
            colStudId.Name = "colStudId";
            colStudId.Width = 85;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            // 
            // colRFIDtag
            // 
            colRFIDtag.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colRFIDtag.HeaderText = "RFID Tag";
            colRFIDtag.Name = "colRFIDtag";
            colRFIDtag.Width = 75;
            // 
            // colProgram
            // 
            colProgram.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colProgram.HeaderText = "Program";
            colProgram.Name = "colProgram";
            colProgram.Width = 76;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEdit.HeaderText = "";
            colEdit.Name = "colEdit";
            colEdit.Width = 21;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDelete.HeaderText = "";
            colDelete.Name = "colDelete";
            colDelete.Width = 21;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 472);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button btnCreateNew;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colStudId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colRFIDtag;
        private DataGridViewTextBoxColumn colProgram;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}