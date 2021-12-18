
namespace StockSystem
{
    partial class AddStock
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTani = new System.Windows.Forms.TextBox();
            this.lblTani = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbType5 = new System.Windows.Forms.RadioButton();
            this.rdbType4 = new System.Windows.Forms.RadioButton();
            this.rdbType3 = new System.Windows.Forms.RadioButton();
            this.rdbType2 = new System.Windows.Forms.RadioButton();
            this.rdbType1 = new System.Windows.Forms.RadioButton();
            this.rdbType0 = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtID.Location = new System.Drawing.Point(95, 44);
            this.txtID.MaxLength = 4;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 19);
            this.txtID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTani);
            this.groupBox1.Controls.Add(this.lblTani);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.lblNum);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(66, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "追加在庫入力";
            // 
            // txtTani
            // 
            this.txtTani.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTani.Location = new System.Drawing.Point(285, 235);
            this.txtTani.MaxLength = 10;
            this.txtTani.Name = "txtTani";
            this.txtTani.Size = new System.Drawing.Size(100, 19);
            this.txtTani.TabIndex = 13;
            this.txtTani.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTani_KeyDown);
            // 
            // lblTani
            // 
            this.lblTani.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTani.Location = new System.Drawing.Point(223, 235);
            this.lblTani.Name = "lblTani";
            this.lblTani.Size = new System.Drawing.Size(56, 19);
            this.lblTani.TabIndex = 14;
            this.lblTani.Text = "単位";
            this.lblTani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNum
            // 
            this.txtNum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNum.Location = new System.Drawing.Point(95, 235);
            this.txtNum.MaxLength = 7;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 19);
            this.txtNum.TabIndex = 12;
            // 
            // lblNum
            // 
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Location = new System.Drawing.Point(33, 235);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(56, 19);
            this.lblNum.TabIndex = 12;
            this.lblNum.Text = "数量";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(33, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "期限";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbType5);
            this.groupBox2.Controls.Add(this.rdbType4);
            this.groupBox2.Controls.Add(this.rdbType3);
            this.groupBox2.Controls.Add(this.rdbType2);
            this.groupBox2.Controls.Add(this.rdbType1);
            this.groupBox2.Controls.Add(this.rdbType0);
            this.groupBox2.Location = new System.Drawing.Point(33, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分類";
            // 
            // rdbType5
            // 
            this.rdbType5.AutoSize = true;
            this.rdbType5.Location = new System.Drawing.Point(200, 41);
            this.rdbType5.Name = "rdbType5";
            this.rdbType5.Size = new System.Drawing.Size(54, 16);
            this.rdbType5.TabIndex = 10;
            this.rdbType5.TabStop = true;
            this.rdbType5.Text = "その他";
            this.rdbType5.UseVisualStyleBackColor = true;
            // 
            // rdbType4
            // 
            this.rdbType4.AutoSize = true;
            this.rdbType4.Location = new System.Drawing.Point(106, 41);
            this.rdbType4.Name = "rdbType4";
            this.rdbType4.Size = new System.Drawing.Size(57, 16);
            this.rdbType4.TabIndex = 9;
            this.rdbType4.TabStop = true;
            this.rdbType4.Text = "お菓子";
            this.rdbType4.UseVisualStyleBackColor = true;
            // 
            // rdbType3
            // 
            this.rdbType3.AutoSize = true;
            this.rdbType3.Location = new System.Drawing.Point(12, 41);
            this.rdbType3.Name = "rdbType3";
            this.rdbType3.Size = new System.Drawing.Size(47, 16);
            this.rdbType3.TabIndex = 8;
            this.rdbType3.TabStop = true;
            this.rdbType3.Text = "果物";
            this.rdbType3.UseVisualStyleBackColor = true;
            // 
            // rdbType2
            // 
            this.rdbType2.AutoSize = true;
            this.rdbType2.Location = new System.Drawing.Point(200, 18);
            this.rdbType2.Name = "rdbType2";
            this.rdbType2.Size = new System.Drawing.Size(47, 16);
            this.rdbType2.TabIndex = 7;
            this.rdbType2.TabStop = true;
            this.rdbType2.Text = "野菜";
            this.rdbType2.UseVisualStyleBackColor = true;
            // 
            // rdbType1
            // 
            this.rdbType1.AutoSize = true;
            this.rdbType1.Location = new System.Drawing.Point(106, 18);
            this.rdbType1.Name = "rdbType1";
            this.rdbType1.Size = new System.Drawing.Size(35, 16);
            this.rdbType1.TabIndex = 6;
            this.rdbType1.TabStop = true;
            this.rdbType1.Text = "魚";
            this.rdbType1.UseVisualStyleBackColor = true;
            // 
            // rdbType0
            // 
            this.rdbType0.AutoSize = true;
            this.rdbType0.Checked = true;
            this.rdbType0.Location = new System.Drawing.Point(12, 19);
            this.rdbType0.Name = "rdbType0";
            this.rdbType0.Size = new System.Drawing.Size(35, 16);
            this.rdbType0.TabIndex = 5;
            this.rdbType0.TabStop = true;
            this.rdbType0.Text = "肉";
            this.rdbType0.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtName.Location = new System.Drawing.Point(95, 84);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 19);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(33, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "名前";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblID.Location = new System.Drawing.Point(33, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 19);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 700);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbType5;
        private System.Windows.Forms.RadioButton rdbType4;
        private System.Windows.Forms.RadioButton rdbType3;
        private System.Windows.Forms.RadioButton rdbType2;
        private System.Windows.Forms.RadioButton rdbType1;
        private System.Windows.Forms.RadioButton rdbType0;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTani;
        private System.Windows.Forms.Label lblTani;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
    }
}