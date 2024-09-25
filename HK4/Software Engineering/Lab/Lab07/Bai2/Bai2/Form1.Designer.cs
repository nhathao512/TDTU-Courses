namespace Bai2
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
            maKhoa = new TextBox();
            label7 = new Label();
            gt = new ComboBox();
            NS = new DateTimePicker();
            txtDC = new TextBox();
            txtQQ = new TextBox();
            tenSV = new TextBox();
            maSV = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grp2 = new GroupBox();
            bCANCEL = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            bDEL = new Button();
            bADD = new Button();
            grp3 = new GroupBox();
            grd = new DataGridView();
            grp1.SuspendLayout();
            grp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(maKhoa);
            grp1.Controls.Add(label7);
            grp1.Controls.Add(gt);
            grp1.Controls.Add(NS);
            grp1.Controls.Add(txtDC);
            grp1.Controls.Add(txtQQ);
            grp1.Controls.Add(tenSV);
            grp1.Controls.Add(maSV);
            grp1.Controls.Add(label6);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(15, 15);
            grp1.Name = "grp1";
            grp1.Size = new Size(778, 157);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "Thông tin sinh viên";
            // 
            // maKhoa
            // 
            maKhoa.Location = new Point(111, 130);
            maKhoa.Name = "maKhoa";
            maKhoa.Size = new Size(245, 27);
            maKhoa.TabIndex = 13;
            maKhoa.TextChanged += maKhoa_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 130);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 12;
            label7.Text = "Mã Khoa";
            // 
            // gt
            // 
            gt.FormattingEnabled = true;
            gt.Location = new Point(496, 96);
            gt.Name = "gt";
            gt.Size = new Size(245, 28);
            gt.TabIndex = 11;
            // 
            // NS
            // 
            NS.Location = new Point(111, 64);
            NS.Name = "NS";
            NS.Size = new Size(245, 27);
            NS.TabIndex = 10;
            // 
            // txtDC
            // 
            txtDC.Location = new Point(111, 97);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(245, 27);
            txtDC.TabIndex = 9;
            // 
            // txtQQ
            // 
            txtQQ.Location = new Point(496, 64);
            txtQQ.Name = "txtQQ";
            txtQQ.Size = new Size(245, 27);
            txtQQ.TabIndex = 8;
            // 
            // tenSV
            // 
            tenSV.Location = new Point(496, 28);
            tenSV.Name = "tenSV";
            tenSV.Size = new Size(245, 27);
            tenSV.TabIndex = 7;
            tenSV.TextChanged += tenSV_TextChanged;
            // 
            // maSV
            // 
            maSV.Location = new Point(111, 32);
            maSV.Name = "maSV";
            maSV.Size = new Size(245, 27);
            maSV.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 96);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 5;
            label6.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 96);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 64);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Quê Quán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 64);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 35);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên SV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // grp2
            // 
            grp2.Controls.Add(bCANCEL);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(bADD);
            grp2.Location = new Point(15, 172);
            grp2.Name = "grp2";
            grp2.Size = new Size(779, 66);
            grp2.TabIndex = 1;
            grp2.TabStop = false;
            grp2.Text = "Chức Năng";
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(647, 26);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(94, 31);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Hủy";
            bCANCEL.UseVisualStyleBackColor = true;
            bCANCEL.Click += bCANCEL_Click;
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(479, 26);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(94, 31);
            bSAVE.TabIndex = 3;
            bSAVE.Text = "Lưu";
            bSAVE.UseVisualStyleBackColor = true;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(329, 26);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(94, 31);
            bEDIT.TabIndex = 2;
            bEDIT.Text = "Sửa";
            bEDIT.UseVisualStyleBackColor = true;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(172, 26);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(94, 31);
            bDEL.TabIndex = 1;
            bDEL.Text = "Xóa";
            bDEL.UseVisualStyleBackColor = true;
            // 
            // bADD
            // 
            bADD.Location = new Point(15, 26);
            bADD.Name = "bADD";
            bADD.Size = new Size(94, 31);
            bADD.TabIndex = 0;
            bADD.Text = "Thêm";
            bADD.UseVisualStyleBackColor = true;
            bADD.Click += bADD_Click;
            // 
            // grp3
            // 
            grp3.Location = new Point(15, 244);
            grp3.Name = "grp3";
            grp3.Size = new Size(780, 290);
            grp3.TabIndex = 2;
            grp3.TabStop = false;
            grp3.Text = "Thông tin";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(28, 270);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(761, 258);
            grd.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 546);
            Controls.Add(grd);
            Controls.Add(grp3);
            Controls.Add(grp2);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            grp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox gt;
        private DateTimePicker NS;
        private TextBox txtDC;
        private TextBox txtQQ;
        private TextBox tenSV;
        private TextBox maSV;
        private Label label6;
        private GroupBox grp2;
        private Button bCANCEL;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private Button bADD;
        private GroupBox grp3;
        private DataGridView grd;
        private TextBox maKhoa;
        private Label label7;
    }
}
