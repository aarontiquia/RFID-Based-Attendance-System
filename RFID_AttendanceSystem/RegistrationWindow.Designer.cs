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
            button1 = new Button();
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
            btnCancel = new Button();
            btnBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 50, 57);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 43);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.close;
            button1.Location = new Point(709, 7);
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
            label2.Size = new Size(149, 18);
            label2.TabIndex = 1;
            label2.Text = "Student Registration";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(369, 103);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // txtBoxStudId
            // 
            txtBoxStudId.Anchor = AnchorStyles.None;
            txtBoxStudId.Cursor = Cursors.IBeam;
            txtBoxStudId.Font = new Font("Arial", 9F);
            txtBoxStudId.Location = new Point(369, 121);
            txtBoxStudId.Name = "txtBoxStudId";
            txtBoxStudId.Size = new Size(323, 21);
            txtBoxStudId.TabIndex = 2;
            txtBoxStudId.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(369, 147);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(369, 191);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "RFID Tag";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F);
            label5.Location = new Point(369, 235);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 5;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F);
            label6.Location = new Point(369, 279);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 6;
            label6.Text = "Date";
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.None;
            txtBoxName.Cursor = Cursors.IBeam;
            txtBoxName.Font = new Font("Arial", 9F);
            txtBoxName.Location = new Point(369, 165);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(323, 21);
            txtBoxName.TabIndex = 7;
            // 
            // txtBoxRFID
            // 
            txtBoxRFID.Anchor = AnchorStyles.None;
            txtBoxRFID.Cursor = Cursors.IBeam;
            txtBoxRFID.Font = new Font("Arial", 9F);
            txtBoxRFID.Location = new Point(369, 209);
            txtBoxRFID.Name = "txtBoxRFID";
            txtBoxRFID.Size = new Size(323, 21);
            txtBoxRFID.TabIndex = 8;
            // 
            // txtBoxProgram
            // 
            txtBoxProgram.Anchor = AnchorStyles.None;
            txtBoxProgram.Cursor = Cursors.IBeam;
            txtBoxProgram.Font = new Font("Arial", 9F);
            txtBoxProgram.Location = new Point(369, 253);
            txtBoxProgram.Name = "txtBoxProgram";
            txtBoxProgram.Size = new Size(323, 21);
            txtBoxProgram.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Location = new Point(369, 306);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(323, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(80, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 209);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Arial", 9F);
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(250, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Arial", 9F);
            btnCancel.ForeColor = Color.Firebrick;
            btnCancel.Location = new Point(389, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.None;
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.Font = new Font("Arial", 9F);
            btnBrowse.Location = new Point(80, 306);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(245, 23);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // RegistrationWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 511);
            ControlBox = false;
            Controls.Add(btnCancel);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnCancel;
        private Button btnBrowse;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}