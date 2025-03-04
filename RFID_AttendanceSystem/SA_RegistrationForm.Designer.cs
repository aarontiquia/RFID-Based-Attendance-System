namespace RFID_AttendanceSystem
{
    partial class SA_RegistrationForm
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
            label2 = new Label();
            dataGridView1SA = new DataGridView();
            colStudId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colRFIDtag = new DataGridViewTextBoxColumn();
            colProgram = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            panel2 = new Panel();
            btnCreateNewSA = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1SA).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 12);
            label2.Name = "label2";
            label2.Size = new Size(166, 18);
            label2.TabIndex = 0;
            label2.Text = "Employee Registration";
            // 
            // dataGridView1SA
            // 
            dataGridView1SA.AllowUserToAddRows = false;
            dataGridView1SA.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1SA.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1SA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1SA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1SA.Columns.AddRange(new DataGridViewColumn[] { colStudId, colName, colRFIDtag, colProgram, colDate, colEdit, colDelete });
            dataGridView1SA.Dock = DockStyle.Fill;
            dataGridView1SA.EnableHeadersVisualStyles = false;
            dataGridView1SA.Location = new Point(0, 76);
            dataGridView1SA.Name = "dataGridView1SA";
            dataGridView1SA.RowHeadersVisible = false;
            dataGridView1SA.Size = new Size(800, 374);
            dataGridView1SA.TabIndex = 5;
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
            colEdit.Width = 5;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDelete.HeaderText = "";
            colDelete.Name = "colDelete";
            colDelete.Width = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCreateNewSA);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 33);
            panel2.TabIndex = 4;
            // 
            // btnCreateNewSA
            // 
            btnCreateNewSA.Cursor = Cursors.Hand;
            btnCreateNewSA.Font = new Font("Arial", 9F);
            btnCreateNewSA.Location = new Point(3, 2);
            btnCreateNewSA.Name = "btnCreateNewSA";
            btnCreateNewSA.Size = new Size(104, 30);
            btnCreateNewSA.TabIndex = 0;
            btnCreateNewSA.Text = "Create New";
            btnCreateNewSA.UseVisualStyleBackColor = true;
            btnCreateNewSA.Click += btnCreateNewSA_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 43);
            panel1.TabIndex = 3;
            // 
            // SA_RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1SA);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SA_RegistrationForm";
            Text = "SA_RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1SA).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1SA;
        private DataGridViewTextBoxColumn colStudId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colRFIDtag;
        private DataGridViewTextBoxColumn colProgram;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
        private Panel panel2;
        private Button btnCreateNewSA;
        private Panel panel1;
    }
}