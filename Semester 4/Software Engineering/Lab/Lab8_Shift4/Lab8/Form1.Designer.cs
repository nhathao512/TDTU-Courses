namespace Lab8
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSup = new TextBox();
            txtFun = new TextBox();
            txtName = new TextBox();
            bSave = new Button();
            bEdit = new Button();
            bDel = new Button();
            txtPID = new TextBox();
            bPrint = new Button();
            groupBox2 = new GroupBox();
            bCancel = new Button();
            bAdd = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(12, 222);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(776, 216);
            grd.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 83);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Funding";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 83);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "Supervisor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 33);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "ProjectID";
            // 
            // txtSup
            // 
            txtSup.Location = new Point(113, 76);
            txtSup.Name = "txtSup";
            txtSup.Size = new Size(194, 27);
            txtSup.TabIndex = 3;
            // 
            // txtFun
            // 
            txtFun.Location = new Point(464, 76);
            txtFun.Name = "txtFun";
            txtFun.Size = new Size(297, 27);
            txtFun.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(464, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 27);
            txtName.TabIndex = 1;
            // 
            // bSave
            // 
            bSave.Location = new Point(422, 26);
            bSave.Name = "bSave";
            bSave.Size = new Size(94, 29);
            bSave.TabIndex = 3;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(311, 26);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(94, 29);
            bEdit.TabIndex = 4;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            // 
            // bDel
            // 
            bDel.Location = new Point(198, 26);
            bDel.Name = "bDel";
            bDel.Size = new Size(94, 29);
            bDel.TabIndex = 3;
            bDel.Text = "Delete";
            bDel.UseVisualStyleBackColor = true;
            // 
            // txtPID
            // 
            txtPID.Location = new Point(113, 26);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(194, 27);
            txtPID.TabIndex = 0;
            // 
            // bPrint
            // 
            bPrint.Location = new Point(646, 26);
            bPrint.Name = "bPrint";
            bPrint.Size = new Size(115, 29);
            bPrint.TabIndex = 3;
            bPrint.Text = "PrintPreview";
            bPrint.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bPrint);
            groupBox2.Controls.Add(bCancel);
            groupBox2.Controls.Add(bSave);
            groupBox2.Controls.Add(bEdit);
            groupBox2.Controls.Add(bDel);
            groupBox2.Controls.Add(bAdd);
            groupBox2.Location = new Point(12, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 61);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Functions";
            // 
            // bCancel
            // 
            bCancel.Location = new Point(536, 26);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(94, 29);
            bCancel.TabIndex = 3;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(87, 26);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(94, 29);
            bAdd.TabIndex = 2;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSup);
            groupBox1.Controls.Add(txtFun);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtPID);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Project Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSup;
        private TextBox txtFun;
        private TextBox txtName;
        private Button bSave;
        private Button bEdit;
        private Button bDel;
        private TextBox txtPID;
        private Button bPrint;
        private GroupBox groupBox2;
        private Button bCancel;
        private Button bAdd;
        private GroupBox groupBox1;
    }
}
