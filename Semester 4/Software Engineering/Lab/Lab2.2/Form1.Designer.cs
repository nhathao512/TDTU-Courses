namespace Lab2._2
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
            grp1 = new GroupBox();
            kinhphi = new TextBox();
            tenDT = new TextBox();
            lable4 = new Label();
            lable3 = new Label();
            msDeTai = new TextBox();
            label2 = new Label();
            lable1 = new Label();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            bDEL = new Button();
            button1 = new Button();
            grp2 = new GroupBox();
            grd = new DataGridView();
            CNDT = new TextBox();
            grp1.SuspendLayout();
            groupBox2.SuspendLayout();
            grp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(CNDT);
            grp1.Controls.Add(kinhphi);
            grp1.Controls.Add(tenDT);
            grp1.Controls.Add(lable4);
            grp1.Controls.Add(lable3);
            grp1.Controls.Add(msDeTai);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(lable1);
            grp1.Location = new Point(23, 25);
            grp1.Name = "grp1";
            grp1.Size = new Size(762, 106);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "Thông tin đề tài";
            grp1.Enter += groupBox1_Enter;
            // 
            // kinhphi
            // 
            kinhphi.Location = new Point(501, 59);
            kinhphi.Name = "kinhphi";
            kinhphi.Size = new Size(237, 27);
            kinhphi.TabIndex = 7;
            // 
            // tenDT
            // 
            tenDT.Location = new Point(501, 26);
            tenDT.Name = "tenDT";
            tenDT.Size = new Size(237, 27);
            tenDT.TabIndex = 6;
            // 
            // lable4
            // 
            lable4.AutoSize = true;
            lable4.Location = new Point(382, 62);
            lable4.Name = "lable4";
            lable4.Size = new Size(63, 20);
            lable4.TabIndex = 5;
            lable4.Text = "Kinh phí";
            lable4.Click += label4_Click;
            // 
            // lable3
            // 
            lable3.AutoSize = true;
            lable3.Location = new Point(382, 32);
            lable3.Name = "lable3";
            lable3.Size = new Size(74, 20);
            lable3.TabIndex = 4;
            lable3.Text = "Tên đề tài";
            // 
            // msDeTai
            // 
            msDeTai.Location = new Point(150, 26);
            msDeTai.Name = "msDeTai";
            msDeTai.Size = new Size(182, 27);
            msDeTai.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 62);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Chủ nhiệm đề tài";
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(15, 32);
            lable1.Name = "lable1";
            lable1.Size = new Size(91, 20);
            lable1.TabIndex = 0;
            lable1.Text = "Mã số đề tài";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(bSAVE);
            groupBox2.Controls.Add(bEDIT);
            groupBox2.Controls.Add(bDEL);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(23, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(761, 61);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // button6
            // 
            button6.Location = new Point(664, 16);
            button6.Name = "button6";
            button6.Size = new Size(91, 32);
            button6.TabIndex = 5;
            button6.Text = "Xem in";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(548, 17);
            button5.Name = "button5";
            button5.Size = new Size(91, 32);
            button5.TabIndex = 4;
            button5.Text = "Hủy";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(436, 17);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(91, 32);
            bSAVE.TabIndex = 3;
            bSAVE.Text = "Lưu";
            bSAVE.UseVisualStyleBackColor = true;
            bSAVE.Click += bSAVE_Click;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(322, 16);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(91, 32);
            bEDIT.TabIndex = 2;
            bEDIT.Text = "Sửa ";
            bEDIT.UseVisualStyleBackColor = true;
            bEDIT.Click += bEDIT_Click;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(213, 17);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(91, 32);
            bDEL.TabIndex = 1;
            bDEL.Text = "Xóa";
            bDEL.UseVisualStyleBackColor = true;
            bDEL.Click += bDEL_Click;
            // 
            // button1
            // 
            button1.Location = new Point(102, 17);
            button1.Name = "button1";
            button1.Size = new Size(91, 32);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grp2
            // 
            grp2.Controls.Add(grd);
            grp2.Location = new Point(23, 204);
            grp2.Name = "grp2";
            grp2.Size = new Size(759, 234);
            grp2.TabIndex = 2;
            grp2.TabStop = false;
            grp2.Text = "Danh sách đề tài";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(12, 26);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(741, 202);
            grd.TabIndex = 0;
            grd.Click += grd_Click;
            // 
            // CNDT
            // 
            CNDT.Location = new Point(150, 59);
            CNDT.Name = "CNDT";
            CNDT.Size = new Size(182, 27);
            CNDT.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grp2);
            Controls.Add(groupBox2);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            groupBox2.ResumeLayout(false);
            grp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private Label lable1;
        private TextBox kinhphi;
        private TextBox tenDT;
        private Label lable4;
        private Label lable3;
        private TextBox msDeTai;
        private Label label2;
        private GroupBox groupBox2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private GroupBox grp2;
        private DataGridView grd;
        private TextBox CNDT;
    }
}
