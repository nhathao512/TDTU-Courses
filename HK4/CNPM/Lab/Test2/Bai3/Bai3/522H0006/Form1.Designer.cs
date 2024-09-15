namespace _522H0006
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.grp4 = new System.Windows.Forms.GroupBox();
            this.ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.maSachMuon = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ngayTra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.maDGMuon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CHITIET = new System.Windows.Forms.Button();
            this.SHOW = new System.Windows.Forms.Button();
            this.BMUON = new System.Windows.Forms.Button();
            this.BMUONMOI = new System.Windows.Forms.Button();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            this.grp4.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd2);
            this.groupBox1.Location = new System.Drawing.Point(93, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 323);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mượn sách";
            // 
            // grd2
            // 
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd2.Location = new System.Drawing.Point(13, 26);
            this.grd2.Name = "grd2";
            this.grd2.RowHeadersWidth = 51;
            this.grd2.RowTemplate.Height = 29;
            this.grd2.Size = new System.Drawing.Size(872, 284);
            this.grd2.TabIndex = 0;
            this.grd2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd2_CellClick);
            // 
            // grp4
            // 
            this.grp4.Controls.Add(this.ngayMuon);
            this.grp4.Controls.Add(this.maSachMuon);
            this.grp4.Controls.Add(this.txtMaPM);
            this.grp4.Controls.Add(this.label1);
            this.grp4.Controls.Add(this.ngayTra);
            this.grp4.Controls.Add(this.label2);
            this.grp4.Controls.Add(this.maDGMuon);
            this.grp4.Controls.Add(this.label6);
            this.grp4.Controls.Add(this.label5);
            this.grp4.Controls.Add(this.label4);
            this.grp4.Location = new System.Drawing.Point(93, 12);
            this.grp4.Name = "grp4";
            this.grp4.Size = new System.Drawing.Size(900, 142);
            this.grp4.TabIndex = 12;
            this.grp4.TabStop = false;
            this.grp4.Text = "Mượn sách";
            // 
            // ngayMuon
            // 
            this.ngayMuon.Location = new System.Drawing.Point(192, 100);
            this.ngayMuon.Name = "ngayMuon";
            this.ngayMuon.Size = new System.Drawing.Size(242, 27);
            this.ngayMuon.TabIndex = 5;
            this.ngayMuon.Leave += new System.EventHandler(this.ngayMuon_Leave);
            // 
            // maSachMuon
            // 
            this.maSachMuon.Location = new System.Drawing.Point(574, 26);
            this.maSachMuon.Name = "maSachMuon";
            this.maSachMuon.Size = new System.Drawing.Size(242, 27);
            this.maSachMuon.TabIndex = 4;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(192, 26);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(242, 27);
            this.txtMaPM.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã phiếu mượn";
            // 
            // ngayTra
            // 
            this.ngayTra.Location = new System.Drawing.Point(574, 95);
            this.ngayTra.Name = "ngayTra";
            this.ngayTra.Size = new System.Drawing.Size(242, 27);
            this.ngayTra.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày trả";
            // 
            // maDGMuon
            // 
            this.maDGMuon.Location = new System.Drawing.Point(192, 59);
            this.maDGMuon.Name = "maDGMuon";
            this.maDGMuon.Size = new System.Drawing.Size(242, 27);
            this.maDGMuon.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã độc giả";
            // 
            // CHITIET
            // 
            this.CHITIET.Location = new System.Drawing.Point(638, 18);
            this.CHITIET.Name = "CHITIET";
            this.CHITIET.Size = new System.Drawing.Size(123, 50);
            this.CHITIET.TabIndex = 10;
            this.CHITIET.Text = "DS chi tiết phiếu mượn";
            this.CHITIET.UseVisualStyleBackColor = true;
            this.CHITIET.Click += new System.EventHandler(this.CHITIET_Click);
            // 
            // SHOW
            // 
            this.SHOW.Location = new System.Drawing.Point(454, 24);
            this.SHOW.Name = "SHOW";
            this.SHOW.Size = new System.Drawing.Size(104, 39);
            this.SHOW.TabIndex = 9;
            this.SHOW.Text = "DS Mượn";
            this.SHOW.UseVisualStyleBackColor = true;
            this.SHOW.Click += new System.EventHandler(this.SHOW_Click);
            // 
            // BMUON
            // 
            this.BMUON.Location = new System.Drawing.Point(255, 26);
            this.BMUON.Name = "BMUON";
            this.BMUON.Size = new System.Drawing.Size(123, 35);
            this.BMUON.TabIndex = 6;
            this.BMUON.Text = "Mượn";
            this.BMUON.UseVisualStyleBackColor = true;
            this.BMUON.Click += new System.EventHandler(this.BMUON_Click);
            // 
            // BMUONMOI
            // 
            this.BMUONMOI.Location = new System.Drawing.Point(82, 26);
            this.BMUONMOI.Name = "BMUONMOI";
            this.BMUONMOI.Size = new System.Drawing.Size(104, 35);
            this.BMUONMOI.TabIndex = 10;
            this.BMUONMOI.Text = "Tạo mới";
            this.BMUONMOI.UseVisualStyleBackColor = true;
            this.BMUONMOI.Click += new System.EventHandler(this.BMUONMOI_Click);
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.CHITIET);
            this.grp2.Controls.Add(this.SHOW);
            this.grp2.Controls.Add(this.BMUONMOI);
            this.grp2.Controls.Add(this.BMUON);
            this.grp2.Location = new System.Drawing.Point(93, 164);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(897, 80);
            this.grp2.TabIndex = 14;
            this.grp2.TabStop = false;
            this.grp2.Text = "Chức năng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 585);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            this.grp4.ResumeLayout(false);
            this.grp4.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView grd2;
        private GroupBox grp4;
        private Button SHOW;
        private Button BMUON;
        private DateTimePicker ngayMuon;
        private TextBox maSachMuon;
        private TextBox maDGMuon;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button CHITIET;
        private DateTimePicker ngayTra;
        private Label label2;
        private TextBox txtMaPM;
        private Label label1;
        private Button BMUONMOI;
        private GroupBox grp2;
    }
}