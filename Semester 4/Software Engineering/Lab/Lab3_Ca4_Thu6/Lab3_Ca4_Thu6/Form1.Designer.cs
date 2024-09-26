namespace Lab3_Ca4_Thu6
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bPDF = new System.Windows.Forms.Button();
            this.bTC = new System.Windows.Forms.Button();
            this.cbHT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bPDF);
            this.groupBox1.Controls.Add(this.bTC);
            this.groupBox1.Controls.Add(this.cbHT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(807, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // bPDF
            // 
            this.bPDF.Location = new System.Drawing.Point(644, 31);
            this.bPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPDF.Name = "bPDF";
            this.bPDF.Size = new System.Drawing.Size(144, 32);
            this.bPDF.TabIndex = 2;
            this.bPDF.Text = "To PDF";
            this.bPDF.UseVisualStyleBackColor = true;
            this.bPDF.Click += new System.EventHandler(this.bPDF_Click);
            // 
            // bTC
            // 
            this.bTC.Location = new System.Drawing.Point(492, 26);
            this.bTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bTC.Name = "bTC";
            this.bTC.Size = new System.Drawing.Size(144, 32);
            this.bTC.TabIndex = 2;
            this.bTC.Text = "Tất cả";
            this.bTC.UseVisualStyleBackColor = true;
            this.bTC.Click += new System.EventHandler(this.bTC_Click);
            // 
            // cbHT
            // 
            this.cbHT.FormattingEnabled = true;
            this.cbHT.Location = new System.Drawing.Point(142, 28);
            this.cbHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHT.Name = "cbHT";
            this.cbHT.Size = new System.Drawing.Size(313, 28);
            this.cbHT.TabIndex = 1;
            this.cbHT.SelectedIndexChanged += new System.EventHandler(this.cbHT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quê quán";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grd);
            this.groupBox2.Location = new System.Drawing.Point(23, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(807, 531);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(15, 29);
            this.grd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.Size = new System.Drawing.Size(774, 500);
            this.grd.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "KP < 10 triệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bPDF;
        private System.Windows.Forms.Button bTC;
        private System.Windows.Forms.ComboBox cbHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button button1;
    }
}

