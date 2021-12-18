using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockSystem
{
    public partial class StockSystemForm : Form
    {
        #region プロパティ

        // タイトル
        private string formTitle;

        // ボタン有効設定
        private bool flagButtunEnable;

        /// <summary>
        /// フォームタイトル
        /// </summary>
        public string FormTitle
        {
            get
            {
                return this.formTitle;
            }
            set
            {
                this.formTitle = value;
                this.lblTitle.Text = this.formTitle;
            }
        }

        /// <summary>
        /// 画面タイトル
        /// </summary>
        public string LabelTitle
        {
            get
            {
                return this.LabelTitle;
            }
            set
            {
                this.lblTitle.Text = this.LabelTitle;
            }
        }

        /// <summary>
        /// F1ボタンタイトル
        /// </summary>
        public string ButtonF1Title
        {
            get
            {
                return this.ButtonF1Title;
            }
            set
            {
                this.btnF1.Text = this.ButtonF1Title;
            }
        }

        /// <summary>
        /// F2ボタンタイトル
        /// </summary>
        public string ButtonF2Title
        {
            get
            {
                return this.ButtonF2Title;
            }
            set
            {
                this.btnF1.Text = this.ButtonF2Title;
            }
        }

        /// <summary>
        /// F3ボタンタイトル
        /// </summary>
        public string ButtonF3Title
        {
            get
            {
                return this.ButtonF3Title;
            }
            set
            {
                this.btnF1.Text = this.ButtonF3Title;
            }
        }

        /// <summary>
        /// F4ボタンタイトル
        /// </summary>
        public string ButtonF4Title
        {
            get
            {
                return this.ButtonF4Title;
            }
            set
            {
                this.btnF1.Text = this.ButtonF4Title;
            }
        }

        /// <summary>
        /// F5ボタンタイトル
        /// </summary>
        //public string ButtonF5Title
        //{
        //    get
        //    {
        //        return this.ButtonF5Title;
        //    }
        //    set
        //    {
        //        this.btnF1.Text = this.ButtonF5Title;
        //    }
        //}
        /// <summary>
        /// F5ボタンタイトル
        /// </summary>
        public string ButtonF5Title { get; set; }

        /// <summary>
        /// F1ボタン活性
        /// </summary>
        public bool ButtonF1Enable
        {
            get
            {
                return this.flagButtunEnable;
            }
            set
            {
                this.flagButtunEnable = value;
                this.btnF1.Enabled = this.flagButtunEnable;
            }
        }

        /// <summary>
        /// F2ボタン活性
        /// </summary>
        public bool ButtonF2Enable
        {
            get
            {
                return this.flagButtunEnable;
            }
            set
            {
                this.flagButtunEnable = value;
                this.btnF2.Enabled = this.flagButtunEnable;
            }
        }

        /// <summary>
        /// F3ボタン活性
        /// </summary>
        public bool ButtonF3Enable
        {
            get
            {
                return this.flagButtunEnable;
            }
            set
            {
                this.flagButtunEnable = value;
                this.btnF3.Enabled = this.flagButtunEnable;
            }
        }

        /// <summary>
        /// F4ボタン活性
        /// </summary>
        public bool ButtonF4Enable
        {
            get
            {
                return this.flagButtunEnable;
            }
            set
            {
                this.flagButtunEnable = value;
                this.btnF4.Enabled = this.flagButtunEnable;
            }
        }

        /// <summary>
        /// F5ボタン活性
        /// </summary>
        public bool ButtonF5Enable
        {
            get
            {
                return this.flagButtunEnable;
            }
            set
            {
                this.flagButtunEnable = value;
                this.btnF5.Enabled = this.flagButtunEnable;
            }
        }

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StockSystemForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ロードイベント
        /// </summary>
        private void StockSystemForm_Load(object sender, EventArgs e)
        {
            // Formのサイズを指定しておく(ここで指定しないとサイズが変わらないため)
            this.Size = new Size(900, 600);

            // 継承先からもらったボタンの値をセット
            this.ButtonF5Title = StockSystem.CommonFunc.F12Text;
        }

        /// <summary>
        /// テストイベント
        /// </summary>
        private void test_Click(object sender, EventArgs e)
        {
            //AddStock addstock = new AddStock();
            //addstock.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerchStock serchStock = new SerchStock();
            serchStock.Show();
        }

        /// <summary>
        /// 戻るイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnF5_Click(object sender, EventArgs e)
        {
            // 現在アクティブな画面を閉じる
            this.Close();
        }

        /// <summary>
        /// ファンクションキーイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StockSystemForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnF1.PerformClick();
                    break;
                case Keys.F2:
                    btnF2.PerformClick();
                    break;
                case Keys.F3:
                    btnF3.PerformClick();
                    break;
                case Keys.F4:
                    btnF4.PerformClick();
                    break;
                case Keys.F5:
                    btnF5.PerformClick();
                    break;
            }
        }
    }
}
