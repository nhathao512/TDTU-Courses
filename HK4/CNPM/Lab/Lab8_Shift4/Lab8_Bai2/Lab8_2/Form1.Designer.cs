namespace Lab8_2
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
            grd = new DataGridView();
            dpDOB = new DateTimePicker();
            cbHT = new ComboBox();
            txtFN = new TextBox();
            txtGPA = new TextBox();
            bPRINT = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            bDEL = new Button();
            bADD = new Button();
            grp2 = new GroupBox();
            bCANCEL = new Button();
            txtSID = new TextBox();
            label1 = new Label();
            grp3 = new GroupBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            grp1 = new GroupBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            grp2.SuspendLayout();
            grp3.SuspendLayout();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(9, 26);
            grd.Margin = new Padding(3, 4, 3, 4);
            grd.Name = "grd";
            grd.RowHeadersWidth = 62;
            grd.RowTemplate.Height = 25;
            grd.Size = new Size(587, 290);
            grd.TabIndex = 0;
            // 
            // dpDOB
            // 
            dpDOB.Location = new Point(364, 61);
            dpDOB.Margin = new Padding(3, 4, 3, 4);
            dpDOB.Name = "dpDOB";
            dpDOB.Size = new Size(233, 27);
            dpDOB.TabIndex = 3;
            // 
            // cbHT
            // 
            cbHT.FormattingEnabled = true;
            cbHT.Items.AddRange(new object[] { "Hà Nội", "Sài Gòn" });
            cbHT.Location = new Point(102, 60);
            cbHT.Margin = new Padding(3, 4, 3, 4);
            cbHT.Name = "cbHT";
            cbHT.Size = new Size(178, 28);
            cbHT.TabIndex = 2;
            // 
            // txtFN
            // 
            txtFN.Location = new Point(411, 22);
            txtFN.Margin = new Padding(3, 4, 3, 4);
            txtFN.Name = "txtFN";
            txtFN.Size = new Size(178, 27);
            txtFN.TabIndex = 1;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(102, 98);
            txtGPA.Margin = new Padding(3, 4, 3, 4);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(178, 27);
            txtGPA.TabIndex = 4;
            // 
            // bPRINT
            // 
            bPRINT.Location = new Point(496, 22);
            bPRINT.Margin = new Padding(3, 4, 3, 4);
            bPRINT.Name = "bPRINT";
            bPRINT.Size = new Size(78, 40);
            bPRINT.TabIndex = 5;
            bPRINT.Text = "Print";
            bPRINT.UseVisualStyleBackColor = true;
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(327, 22);
            bSAVE.Margin = new Padding(3, 4, 3, 4);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(78, 40);
            bSAVE.TabIndex = 1;
            bSAVE.Text = "Save";
            bSAVE.UseVisualStyleBackColor = true;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(243, 22);
            bEDIT.Margin = new Padding(3, 4, 3, 4);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(78, 40);
            bEDIT.TabIndex = 3;
            bEDIT.Text = "Edit";
            bEDIT.UseVisualStyleBackColor = true;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(159, 22);
            bDEL.Margin = new Padding(3, 4, 3, 4);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(78, 40);
            bDEL.TabIndex = 2;
            bDEL.Text = "Delete";
            bDEL.UseVisualStyleBackColor = true;
            // 
            // bADD
            // 
            bADD.Location = new Point(75, 22);
            bADD.Margin = new Padding(3, 4, 3, 4);
            bADD.Name = "bADD";
            bADD.Size = new Size(78, 40);
            bADD.TabIndex = 0;
            bADD.Text = "Add";
            bADD.UseVisualStyleBackColor = true;
            // 
            // grp2
            // 
            grp2.Controls.Add(bPRINT);
            grp2.Controls.Add(bCANCEL);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(bADD);
            grp2.Location = new Point(24, 153);
            grp2.Margin = new Padding(3, 4, 3, 4);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(3, 4, 3, 4);
            grp2.Size = new Size(605, 76);
            grp2.TabIndex = 10;
            grp2.TabStop = false;
            grp2.Text = "Functions";
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(411, 22);
            bCANCEL.Margin = new Padding(3, 4, 3, 4);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(78, 40);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Cancel";
            bCANCEL.UseVisualStyleBackColor = true;
            // 
            // txtSID
            // 
            txtSID.AcceptsReturn = true;
            txtSID.Location = new Point(102, 22);
            txtSID.Margin = new Padding(3, 4, 3, 4);
            txtSID.Name = "txtSID";
            txtSID.Size = new Size(178, 27);
            txtSID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 29);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // grp3
            // 
            grp3.Controls.Add(grd);
            grp3.Location = new Point(21, 240);
            grp3.Margin = new Padding(3, 4, 3, 4);
            grp3.Name = "grp3";
            grp3.Padding = new Padding(3, 4, 3, 4);
            grp3.Size = new Size(607, 330);
            grp3.TabIndex = 11;
            grp3.TabStop = false;
            grp3.Text = "Student's list";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 29);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Fullname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 106);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 0;
            label5.Text = "GPA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 68);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 0;
            label4.Text = "DOB";
            // 
            // grp1
            // 
            grp1.Controls.Add(dpDOB);
            grp1.Controls.Add(cbHT);
            grp1.Controls.Add(txtFN);
            grp1.Controls.Add(txtGPA);
            grp1.Controls.Add(txtSID);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(24, 4);
            grp1.Margin = new Padding(3, 4, 3, 4);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(3, 4, 3, 4);
            grp1.Size = new Size(602, 144);
            grp1.TabIndex = 9;
            grp1.TabStop = false;
            grp1.Text = "Student information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 68);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Hometown";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 577);
            Controls.Add(grp2);
            Controls.Add(grp3);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            grp2.ResumeLayout(false);
            grp3.ResumeLayout(false);
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView grd;
        private DateTimePicker dpDOB;
        private ComboBox cbHT;
        private TextBox txtFN;
        private TextBox txtGPA;
        private Button bPRINT;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private Button bADD;
        private GroupBox grp2;
        private Button bCANCEL;
        private TextBox txtSID;
        private Label label1;
        private GroupBox grp3;
        private Label label2;
        private Label label5;
        private Label label4;
        private GroupBox grp1;
        private Label label3;
    }
}
