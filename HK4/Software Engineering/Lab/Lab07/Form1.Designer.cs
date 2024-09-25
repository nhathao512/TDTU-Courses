namespace Lab07
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
            txtSDT = new TextBox();
            txtTK = new TextBox();
            txtDD = new TextBox();
            txtMK = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            bCANCEL = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            bDEL = new Button();
            bADD = new Button();
            groupBox3 = new GroupBox();
            grd = new DataGridView();
            grp1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(txtSDT);
            grp1.Controls.Add(txtTK);
            grp1.Controls.Add(txtDD);
            grp1.Controls.Add(txtMK);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(20, 15);
            grp1.Name = "grp1";
            grp1.Size = new Size(735, 127);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "Thông tin Khoa";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(492, 90);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(232, 27);
            txtSDT.TabIndex = 7;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(492, 41);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(232, 27);
            txtTK.TabIndex = 6;
            txtTK.TextChanged += txtTK_TextChanged;
            // 
            // txtDD
            // 
            txtDD.Location = new Point(112, 86);
            txtDD.Name = "txtDD";
            txtDD.Size = new Size(268, 27);
            txtDD.TabIndex = 5;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(112, 41);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(268, 27);
            txtMK.TabIndex = 4;
            txtMK.TextChanged += txtMK_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 93);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 44);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 93);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Địa Điểm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Khoa";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bCANCEL);
            groupBox2.Controls.Add(bSAVE);
            groupBox2.Controls.Add(bEDIT);
            groupBox2.Controls.Add(bDEL);
            groupBox2.Controls.Add(bADD);
            groupBox2.Location = new Point(20, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(735, 77);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(606, 32);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(106, 29);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Hủy";
            bCANCEL.UseVisualStyleBackColor = true;
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(463, 32);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(106, 29);
            bSAVE.TabIndex = 3;
            bSAVE.Text = "Lưu";
            bSAVE.UseVisualStyleBackColor = true;
            bSAVE.Click += bSAVE_Click;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(311, 32);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(106, 29);
            bEDIT.TabIndex = 2;
            bEDIT.Text = "Sửa";
            bEDIT.UseVisualStyleBackColor = true;
            bEDIT.Click += bEDIT_Click;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(168, 32);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(106, 29);
            bDEL.TabIndex = 1;
            bDEL.Text = "Xóa";
            bDEL.UseVisualStyleBackColor = true;
            bDEL.Click += bDEL_Click;
            // 
            // bADD
            // 
            bADD.Location = new Point(23, 32);
            bADD.Name = "bADD";
            bADD.Size = new Size(106, 29);
            bADD.TabIndex = 0;
            bADD.Text = "Thêm";
            bADD.UseVisualStyleBackColor = true;
            bADD.Click += bADD_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(20, 236);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(735, 292);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khoa";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(14, 26);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(715, 264);
            grd.TabIndex = 0;
            grd.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private TextBox txtSDT;
        private TextBox txtTK;
        private TextBox txtDD;
        private TextBox txtMK;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button bCANCEL;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private Button bADD;
        private GroupBox groupBox3;
        private DataGridView grd;
    }
}
