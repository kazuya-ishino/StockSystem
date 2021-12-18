
namespace StockSystem
{
    partial class SerchStock
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
            this.txtAllSerch = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbType5 = new System.Windows.Forms.RadioButton();
            this.rdbType4 = new System.Windows.Forms.RadioButton();
            this.rdbType3 = new System.Windows.Forms.RadioButton();
            this.rdbType2 = new System.Windows.Forms.RadioButton();
            this.rdbType1 = new System.Windows.Forms.RadioButton();
            this.rdbType0 = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvSerchStock = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerchStock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAllSerch);
            this.groupBox1.Controls.Add(this.btnSerch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // txtAllSerch
            // 
            this.txtAllSerch.Location = new System.Drawing.Point(605, 22);
            this.txtAllSerch.Name = "txtAllSerch";
            this.txtAllSerch.Size = new System.Drawing.Size(75, 23);
            this.txtAllSerch.TabIndex = 4;
            this.txtAllSerch.Text = "全検索";
            this.txtAllSerch.UseVisualStyleBackColor = true;
            this.txtAllSerch.Click += new System.EventHandler(this.TxtAllSerch_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(605, 54);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(75, 23);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "検索";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.BtnSerch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbType5);
            this.groupBox2.Controls.Add(this.rdbType4);
            this.groupBox2.Controls.Add(this.rdbType3);
            this.groupBox2.Controls.Add(this.rdbType2);
            this.groupBox2.Controls.Add(this.rdbType1);
            this.groupBox2.Controls.Add(this.rdbType0);
            this.groupBox2.Location = new System.Drawing.Point(286, 16);
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
            this.rdbType5.CheckedChanged += new System.EventHandler(this.RdbType_CheckedChanged);
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
            this.rdbType4.CheckedChanged += new System.EventHandler(this.RdbType_CheckedChanged);
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
            this.rdbType3.CheckedChanged += new System.EventHandler(this.RdbType_CheckedChanged);
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
            this.rdbType2.CheckedChanged += new System.EventHandler(this.RdbType_CheckedChanged);
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
            this.rdbType1.CheckedChanged += new System.EventHandler(this.RdbType_CheckedChanged);
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
            this.rdbType0.CheckedChanged += new System.EventHandler(this.RdbType_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 63);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 19);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtID.Location = new System.Drawing.Point(137, 22);
            this.txtID.MaxLength = 4;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 19);
            this.txtID.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(30, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "名前";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblID.Location = new System.Drawing.Point(30, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSerchStock
            // 
            this.dgvSerchStock.AllowUserToDeleteRows = false;
            this.dgvSerchStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerchStock.Location = new System.Drawing.Point(12, 169);
            this.dgvSerchStock.Name = "dgvSerchStock";
            this.dgvSerchStock.RowTemplate.Height = 21;
            this.dgvSerchStock.Size = new System.Drawing.Size(695, 209);
            this.dgvSerchStock.TabIndex = 1;
            this.dgvSerchStock.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvSerchStock_RowPostPaint);
            // 
            // SerchStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 554);
            this.Controls.Add(this.dgvSerchStock);
            this.Controls.Add(this.groupBox1);
            this.Name = "SerchStock";
            this.Text = "SerchStock";
            this.Activated += new System.EventHandler(this.DgvSerchStock_Actived);
            this.Load += new System.EventHandler(this.SerchStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerchStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbType5;
        private System.Windows.Forms.RadioButton rdbType4;
        private System.Windows.Forms.RadioButton rdbType3;
        private System.Windows.Forms.RadioButton rdbType2;
        private System.Windows.Forms.RadioButton rdbType1;
        private System.Windows.Forms.RadioButton rdbType0;
        private System.Windows.Forms.DataGridView dgvSerchStock;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Button txtAllSerch;
    }
}