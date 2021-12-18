using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSystem
{
    public partial class AddStock : StockSystemForm
    {
        #region プロパティ
        /// <summary>
        /// 種類
        /// </summary>
        private Type type;

        /// <summary>
        /// データ数
        /// </summary>
        private int DataNum
        {
            get;
            set;
        }

        /// <summary>
        /// ID
        /// </summary>
        private string[] IDArray
        {
            get;
            set;
        }

        /// <summary>
        /// 種類プロパティ
        /// </summary>
        private Type ProType
        {
            get
            {
                if (rdbType0.Checked == true)
                {
                    this.type = Type.meet;
                }
                else if (rdbType1.Checked == true)
                {
                    this.type = Type.fish;
                }
                else if (rdbType2.Checked == true)
                {
                    this.type = Type.vegetable;
                }
                else if (rdbType3.Checked == true)
                {
                    this.type = Type.fruit;
                }
                else if (rdbType4.Checked == true)
                {
                    this.type = Type.snack;
                }
                else
                {
                    this.type = Type.other;
                }
                return this.type;
            }
            set
            {
                this.type = ProType;
            }
        }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="dataNum">データ数</param>
        public AddStock(int dataNum, string[] ID)
        {
            this.DataNum = dataNum;
            this.IDArray = ID;
            InitializeComponent();
        }

        /// <summary>
        /// デザインプロパティ設定
        /// </summary>
        private void SetDesignPropaty()
        {
            try
            {
                // タイトルの設定
                this.FormTitle = "在庫追加";

                // ボタン状態
                this.ButtonF1Enable = false;   // 削除
                this.ButtonF2Enable = false;   // 追加
                this.ButtonF3Enable = false;   // メンテナンス
                this.ButtonF4Enable = true;    // 確定
                this.ButtonF5Enable = true;    // 戻る

                // イベントの追加
                btnF4.Click += new EventHandler(BtnF4_Click);  // 確定

                // Formのサイズを指定しておく(ここで指定しないとサイズが変わらないため)
                //this.Size = new Size(870, 739);
            }
            catch
            {
                throw;
            }
        }

        #region イベント

        /// <summary>
        /// ロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStock_Load(object sender, EventArgs e)
        {
            try
            {
                // デザインプロパティ設定
                SetDesignPropaty();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 確定イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnF4_Click(object sender, EventArgs e)
        {

            try
            {
                // 確定処理
                Fix();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// KeyDownイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtTani_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // 確定処理
                    Fix();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region プライベートメソッド

        /// <summary>
        /// 重複チェック
        /// </summary>
        private bool CheckDuplicate()
        {
            bool duplicateFlag = true;

            try
            {
                for (int index = 0; index < this.IDArray.Length; index++)
                {
                    if (this.txtID.Text == this.IDArray[index])
                    {
                        duplicateFlag = false;
                        break;
                    }
                }
            }
            catch
            {
                throw;
            }
            return duplicateFlag;
        }

        /// <summary>
        /// 確定処理
        /// </summary>
        private void Fix()
        {
            FileImport fileImport = new FileImport(CommonFunc.INIPath, null);
            try
            {
                // ID重複チェック
                if (CheckDuplicate())
                {
                    // INIファイルが存在するか
                    if (fileImport.CheckIniFile())
                    {
                        // INIファイルへ追加
                        fileImport.CreateIniFile(txtID.Text, txtName.Text, this.ProType, dateTimePicker1.Text, txtNum.Text, txtTani.Text, this.DataNum);
                    }
                    else
                    {
                        // INIファイルが存在しません
                        MessageBox.Show(CommonFunc.NoIniFile);
                        return;
                    }

                }
                else
                {
                    // IDが重複しています
                    MessageBox.Show(CommonFunc.IDDuplicate);
                    return;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                this.Close();
            }
        }
        #endregion
    }
}
