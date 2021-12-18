namespace StockSystem
{
    partial class StockSystemForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnF1 = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.btnF3 = new System.Windows.Forms.Button();
            this.btnF4 = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnF1
            // 
            this.btnF1.Location = new System.Drawing.Point(27, 466);
            this.btnF1.Margin = new System.Windows.Forms.Padding(2);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(83, 77);
            this.btnF1.TabIndex = 20;
            this.btnF1.Text = "削除\r\n\r\n(F1)";
            this.btnF1.UseVisualStyleBackColor = true;
            // 
            // btnF2
            // 
            this.btnF2.Location = new System.Drawing.Point(209, 466);
            this.btnF2.Margin = new System.Windows.Forms.Padding(2);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(83, 77);
            this.btnF2.TabIndex = 21;
            this.btnF2.Text = "追加\r\n\r\n(F2)";
            this.btnF2.UseVisualStyleBackColor = true;
            // 
            // btnF3
            // 
            this.btnF3.Location = new System.Drawing.Point(398, 466);
            this.btnF3.Margin = new System.Windows.Forms.Padding(2);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(83, 77);
            this.btnF3.TabIndex = 22;
            this.btnF3.Text = "変更\r\n\r\n(F3)";
            this.btnF3.UseVisualStyleBackColor = true;
            // 
            // btnF4
            // 
            this.btnF4.Location = new System.Drawing.Point(577, 466);
            this.btnF4.Margin = new System.Windows.Forms.Padding(2);
            this.btnF4.Name = "btnF4";
            this.btnF4.Size = new System.Drawing.Size(83, 77);
            this.btnF4.TabIndex = 23;
            this.btnF4.Text = "確定\r\n\r\n(F4)";
            this.btnF4.UseVisualStyleBackColor = true;
            // 
            // btnF5
            // 
            this.btnF5.Location = new System.Drawing.Point(755, 466);
            this.btnF5.Margin = new System.Windows.Forms.Padding(2);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(83, 77);
            this.btnF5.TabIndex = 24;
            this.btnF5.Text = "戻る\r\n\r\n(F5)";
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(11, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(870, 34);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "タイトル";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(874, 554);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.btnF4);
            this.Controls.Add(this.btnF3);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.btnF1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StockSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StockSystemForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StockSystemForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnF2;
        public System.Windows.Forms.Button btnF1;
        public System.Windows.Forms.Button btnF3;
        public System.Windows.Forms.Button btnF4;
        public System.Windows.Forms.Button btnF5;
        public System.Windows.Forms.Label lblTitle;
    }
}

