namespace Lab3
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
            gb1 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            dt = new ComboBox();
            label4 = new Label();
            stu = new ComboBox();
            label3 = new Label();
            button6 = new Button();
            button5 = new Button();
            cndt = new ComboBox();
            label2 = new Label();
            bPDF = new Button();
            button1 = new Button();
            cbHT = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            grd = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            gb1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(button8);
            gb1.Controls.Add(button7);
            gb1.Controls.Add(dt);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(stu);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(button6);
            gb1.Controls.Add(button5);
            gb1.Controls.Add(cndt);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(bPDF);
            gb1.Controls.Add(button1);
            gb1.Controls.Add(cbHT);
            gb1.Controls.Add(label1);
            gb1.Location = new Point(9, 20);
            gb1.Name = "gb1";
            gb1.Size = new Size(774, 186);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Tìm kiếm";
            gb1.Enter += groupBox1_Enter;
            // 
            // button8
            // 
            button8.Location = new Point(482, 145);
            button8.Name = "button8";
            button8.Size = new Size(111, 28);
            button8.TabIndex = 13;
            button8.Text = "Tất cả";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(482, 110);
            button7.Name = "button7";
            button7.Size = new Size(111, 28);
            button7.TabIndex = 12;
            button7.Text = "Tất cả";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dt
            // 
            dt.FormattingEnabled = true;
            dt.Location = new Point(146, 145);
            dt.Name = "dt";
            dt.Size = new Size(308, 28);
            dt.TabIndex = 11;
            dt.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 145);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "Đề tài";
            label4.Click += label4_Click;
            // 
            // stu
            // 
            stu.FormattingEnabled = true;
            stu.Location = new Point(146, 110);
            stu.Name = "stu";
            stu.Size = new Size(308, 28);
            stu.TabIndex = 9;
            stu.SelectedIndexChanged += comboBox1_SelectedIndexChanged_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 110);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Sinh Viên";
            // 
            // button6
            // 
            button6.Location = new Point(622, 71);
            button6.Name = "button6";
            button6.Size = new Size(111, 28);
            button6.TabIndex = 7;
            button6.Text = "Xem in";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(482, 70);
            button5.Name = "button5";
            button5.Size = new Size(111, 28);
            button5.TabIndex = 6;
            button5.Text = "Tất cả";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // cndt
            // 
            cndt.FormattingEnabled = true;
            cndt.Location = new Point(146, 71);
            cndt.Name = "cndt";
            cndt.Size = new Size(308, 28);
            cndt.TabIndex = 5;
            cndt.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 4;
            label2.Text = "Chủ nhiệm đề tài";
            label2.Click += label2_Click;
            // 
            // bPDF
            // 
            bPDF.Location = new Point(622, 31);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(111, 28);
            bPDF.TabIndex = 3;
            bPDF.Text = "Xem in";
            bPDF.UseVisualStyleBackColor = true;
            bPDF.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(482, 32);
            button1.Name = "button1";
            button1.Size = new Size(111, 28);
            button1.TabIndex = 2;
            button1.Text = "Tất cả";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbHT
            // 
            cbHT.FormattingEnabled = true;
            cbHT.Location = new Point(146, 32);
            cbHT.Name = "cbHT";
            cbHT.Size = new Size(308, 28);
            cbHT.TabIndex = 1;
            cbHT.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Quê quán";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grd);
            groupBox2.Location = new Point(11, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(797, 271);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(15, 50);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(776, 256);
            grd.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(798, 28);
            button2.Name = "button2";
            button2.Size = new Size(143, 30);
            button2.TabIndex = 2;
            button2.Text = "KP <= 10.000.000";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(798, 64);
            button3.Name = "button3";
            button3.Size = new Size(143, 30);
            button3.TabIndex = 3;
            button3.Text = "KP <= 100.000.000";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(798, 100);
            button4.Name = "button4";
            button4.Size = new Size(143, 30);
            button4.TabIndex = 4;
            button4.Text = "KP > 100.000.000";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 518);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(gb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private Button bPDF;
        private Button button1;
        private ComboBox cbHT;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView grd;
        private Label label2;
        private ComboBox cndt;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Label label4;
        private ComboBox stu;
        private Label label3;
        private ComboBox dt;
        private Button button8;
        private Button button7;
    }
}
