namespace Lab09
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
            txtPID = new ComboBox();
            txtIP = new TextBox();
            distance = new TextBox();
            txtSID = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            grp2 = new GroupBox();
            bAll = new Button();
            bPRINT = new Button();
            label1 = new Label();
            grp3 = new GroupBox();
            grp1 = new GroupBox();
            result = new TextBox();
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
            grd.Size = new Size(611, 249);
            grd.TabIndex = 0;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // txtPID
            // 
            txtPID.FormattingEnabled = true;
            txtPID.Items.AddRange(new object[] { "Hà Nội", "Sài Gòn" });
            txtPID.Location = new Point(102, 60);
            txtPID.Margin = new Padding(3, 4, 3, 4);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(178, 28);
            txtPID.TabIndex = 2;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(411, 22);
            txtIP.Margin = new Padding(3, 4, 3, 4);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(178, 27);
            txtIP.TabIndex = 1;
            // 
            // distance
            // 
            distance.Location = new Point(102, 98);
            distance.Margin = new Padding(3, 4, 3, 4);
            distance.Name = "distance";
            distance.Size = new Size(178, 27);
            distance.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 29);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 0;
            label2.Text = "InternshipPlace";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 106);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 0;
            label5.Text = "Distance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 68);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 0;
            label4.Text = "Results";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 68);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "ProjectID";
            label3.Click += label3_Click;
            // 
            // grp2
            // 
            grp2.Controls.Add(bAll);
            grp2.Controls.Add(bPRINT);
            grp2.Location = new Point(12, 162);
            grp2.Margin = new Padding(3, 4, 3, 4);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(3, 4, 3, 4);
            grp2.Size = new Size(623, 76);
            grp2.TabIndex = 10;
            grp2.TabStop = false;
            grp2.Text = "Functions";
            // 
            // bAll
            // 
            bAll.Location = new Point(102, 22);
            bAll.Name = "bAll";
            bAll.Size = new Size(118, 40);
            bAll.TabIndex = 6;
            bAll.Text = "All";
            bAll.UseVisualStyleBackColor = true;
            bAll.Click += bAll_Click;
            // 
            // bPRINT
            // 
            bPRINT.Location = new Point(353, 22);
            bPRINT.Margin = new Padding(3, 4, 3, 4);
            bPRINT.Name = "bPRINT";
            bPRINT.Size = new Size(127, 40);
            bPRINT.TabIndex = 5;
            bPRINT.Text = "Print";
            bPRINT.UseVisualStyleBackColor = true;
            bPRINT.Click += bPRINT_Click;
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
            grp3.Location = new Point(9, 249);
            grp3.Margin = new Padding(3, 4, 3, 4);
            grp3.Name = "grp3";
            grp3.Padding = new Padding(3, 4, 3, 4);
            grp3.Size = new Size(626, 330);
            grp3.TabIndex = 11;
            grp3.TabStop = false;
            grp3.Text = "Student's list";
            // 
            // grp1
            // 
            grp1.Controls.Add(result);
            grp1.Controls.Add(txtPID);
            grp1.Controls.Add(txtIP);
            grp1.Controls.Add(distance);
            grp1.Controls.Add(txtSID);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(12, 13);
            grp1.Margin = new Padding(3, 4, 3, 4);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(3, 4, 3, 4);
            grp1.Size = new Size(623, 144);
            grp1.TabIndex = 9;
            grp1.TabStop = false;
            grp1.Text = "Student information";
            // 
            // result
            // 
            result.Location = new Point(411, 63);
            result.Name = "result";
            result.Size = new Size(178, 27);
            result.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 543);
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
        private ComboBox txtPID;
        private TextBox txtIP;
        private TextBox distance;
        private TextBox txtSID;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox grp2;
        private Button bAll;
        private Button bPRINT;
        private Label label1;
        private GroupBox grp3;
        private GroupBox grp1;
        private TextBox result;
    }
}
