namespace RFID_AttendanceSystem
{
    partial class RegistrationWindow
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
            label1 = new Label();
            txtBoxStudId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBoxName = new TextBox();
            txtBoxRFID = new TextBox();
            txtBoxProgram = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox2 = new PictureBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnBrowse = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 43);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 1;
            label2.Text = "Student Registration";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(369, 103);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // txtBoxStudId
            // 
            txtBoxStudId.Anchor = AnchorStyles.None;
            txtBoxStudId.Location = new Point(369, 121);
            txtBoxStudId.Name = "txtBoxStudId";
            txtBoxStudId.Size = new Size(323, 23);
            txtBoxStudId.TabIndex = 2;
            txtBoxStudId.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(369, 147);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(369, 191);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "RFID Tag";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(369, 235);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 5;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(369, 279);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 6;
            label6.Text = "Date";
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.None;
            txtBoxName.Location = new Point(369, 165);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(323, 23);
            txtBoxName.TabIndex = 7;
            // 
            // txtBoxRFID
            // 
            txtBoxRFID.Anchor = AnchorStyles.None;
            txtBoxRFID.Location = new Point(369, 209);
            txtBoxRFID.Name = "txtBoxRFID";
            txtBoxRFID.Size = new Size(323, 23);
            txtBoxRFID.TabIndex = 8;
            // 
            // txtBoxProgram
            // 
            txtBoxProgram.Anchor = AnchorStyles.None;
            txtBoxProgram.Location = new Point(369, 253);
            txtBoxProgram.Name = "txtBoxProgram";
            txtBoxProgram.Size = new Size(323, 23);
            txtBoxProgram.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(369, 306);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(323, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Location = new Point(80, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 209);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new Point(250, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.Location = new Point(331, 390);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 34);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.Location = new Point(412, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.None;
            btnBrowse.Location = new Point(80, 306);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(245, 23);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // RegistrationWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 511);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnBrowse);
            Controls.Add(btnSave);
            Controls.Add(pictureBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtBoxProgram);
            Controls.Add(txtBoxRFID);
            Controls.Add(txtBoxName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBoxStudId);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationWindow";
            Text = "RegistrationWindow";
            Load += RegistrationWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtBoxStudId;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBoxName;
        private TextBox txtBoxRFID;
        private TextBox txtBoxProgram;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox2;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnBrowse;
    }
}