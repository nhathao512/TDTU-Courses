namespace WinFormsApp1
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
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            grd = new DataGridView();
            grp1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(button2);
            grp1.Controls.Add(button1);
            grp1.Location = new Point(11, 17);
            grp1.Name = "grp1";
            grp1.Size = new Size(777, 89);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "Chức năng";
            // 
            // button2
            // 
            button2.Location = new Point(462, 43);
            button2.Name = "button2";
            button2.Size = new Size(309, 34);
            button2.TabIndex = 1;
            button2.Text = "Mã Phiếu Mượn";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 38);
            button1.Name = "button1";
            button1.Size = new Size(236, 39);
            button1.TabIndex = 0;
            button1.Text = "Ngày Mượn <= Ngày Trả";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grd);
            groupBox2.Location = new Point(11, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(775, 322);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(12, 25);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(759, 275);
            grd.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private DataGridView grd;
    }
}
