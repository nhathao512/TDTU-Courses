namespace Test
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
            txtSL = new TextBox();
            txtTS = new TextBox();
            txtTG = new TextBox();
            txtMS = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grp2 = new GroupBox();
            button2 = new Button();
            txtTim = new TextBox();
            b = new Button();
            button5 = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            bDEL = new Button();
            button1 = new Button();
            grp3 = new GroupBox();
            grd = new DataGridView();
            grp1.SuspendLayout();
            grp2.SuspendLayout();
            grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(txtSL);
            grp1.Controls.Add(txtTS);
            grp1.Controls.Add(txtTG);
            grp1.Controls.Add(txtMS);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(17, 15);
            grp1.Name = "grp1";
            grp1.Size = new Size(769, 115);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "Thông tin Sách";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(500, 69);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(263, 27);
            txtSL.TabIndex = 7;
            // 
            // txtTS
            // 
            txtTS.Location = new Point(500, 29);
            txtTS.Name = "txtTS";
            txtTS.Size = new Size(263, 27);
            txtTS.TabIndex = 6;
            // 
            // txtTG
            // 
            txtTG.Location = new Point(77, 73);
            txtTG.Name = "txtTG";
            txtTG.Size = new Size(302, 27);
            txtTG.TabIndex = 5;
            // 
            // txtMS
            // 
            txtMS.Location = new Point(77, 26);
            txtMS.Name = "txtMS";
            txtMS.Size = new Size(302, 27);
            txtMS.TabIndex = 4;
            txtMS.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 76);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 32);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Sách";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Tác Giả";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Sách";
            label1.Click += label1_Click;
            // 
            // grp2
            // 
            grp2.Controls.Add(button2);
            grp2.Controls.Add(txtTim);
            grp2.Controls.Add(button6);
            grp2.Controls.Add(button5);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(button1);
            grp2.Location = new Point(17, 136);
            grp2.Name = "grp2";
            grp2.Size = new Size(763, 87);
            grp2.TabIndex = 1;
            grp2.TabStop = false;
            grp2.Text = "Chức Năng";
            // 
            // button2
            // 
            button2.Location = new Point(686, 37);
            button2.Name = "button2";
            button2.Size = new Size(71, 29);
            button2.TabIndex = 6;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(461, 37);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(129, 27);
            txtTim.TabIndex = 5;
            // 
            // button6
            // 
            button6.Location = new Point(602, 37);
            button6.Name = "button6";
            button6.Size = new Size(67, 30);
            button6.TabIndex = 2;
            button6.Text = "PDF";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(383, 35);
            button5.Name = "bTim";
            button5.Size = new Size(72, 30);
            button5.TabIndex = 4;
            button5.Text = "Tìm Kiếm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += bTim_Click;
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(286, 35);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(73, 30);
            bSAVE.TabIndex = 3;
            bSAVE.Text = "Lưu";
            bSAVE.UseVisualStyleBackColor = true;
            bSAVE.Click += bSAVE_Click;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(197, 35);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(65, 30);
            bEDIT.TabIndex = 2;
            bEDIT.Text = "Sửa";
            bEDIT.UseVisualStyleBackColor = true;
            bEDIT.Click += bEDIT_Click;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(102, 35);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(69, 30);
            bDEL.TabIndex = 1;
            bDEL.Text = "Xóa";
            bDEL.UseVisualStyleBackColor = true;
            bDEL.Click += bDEL_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 35);
            button1.Name = "button1";
            button1.Size = new Size(71, 30);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grp3
            // 
            grp3.Controls.Add(grd);
            grp3.Location = new Point(17, 231);
            grp3.Name = "grp3";
            grp3.Size = new Size(757, 207);
            grp3.TabIndex = 2;
            grp3.TabStop = false;
            grp3.Text = "Danh sách Sách";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(6, 26);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(747, 170);
            grd.TabIndex = 0;
            grd.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grp3);
            Controls.Add(grp2);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            grp2.ResumeLayout(false);
            grp2.PerformLayout();
            grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTS;
        private TextBox txtTG;
        private TextBox txtMS;
        private TextBox txtSL;
        private GroupBox grp2;
        private Button button6;
        private Button button5;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private Button button1;
        private GroupBox grp3;
        private DataGridView grd;
        private TextBox txtTIM;
        private Button button2;
    }
}
