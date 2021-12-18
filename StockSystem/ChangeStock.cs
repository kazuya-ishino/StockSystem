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
    public partial class ChangeStock : StockSystemForm
    {
        #region プロパティ

        /// <summary>
        /// 種類プロパティ
        /// </summary>
        private Type type;

        /// <summary>
        /// ID
        /// </summary>
        private string ID
        {
            get;
            set;
        }

        /// <summary>
        /// 名前
        /// </summary>
        private string StockName
        {
            get;
            set;
        }

        /// <summary>
        /// 種類
        /// </summary>
        private Type Type
        {
            get;
            set;
        }

        /// <summary>
        /// 期限
        /// </summary>
        private string Date
        {
            get;
            set;
        }

        /// <summary>
        /// 数量
        /// </summary>
        private string Num
        {
            get;
            set;
        }

        /// <summary>
        /// 単位
        /// </summary>
        private string Tani
        {
            get;
            set;
        }

        /// <summary>
        /// データ数
        /// </summary>
        private int DataNum
        {
            get;
            set;
        }

        /// <summary>
        /// 編集行
        /// </summary>
        private int ChangeRow
        {
            get;
            set;
        }

        /// <summary>
        /// データ
        /// </summary>
        private string[] DataArray
        {
            get;
            set;
        }
        /// <summary>
        /// インデックス
        /// </summary>
        private int Index
        {
            get;
            set;
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">名前</param>
        /// <param name="type">種類</param>
        /// <param name="date">期限</param>
        /// <param name="num">数量</param>
        /// <param name="tani">単位</param>
        /// <param name="changeRow">単位</param>
        /// <param name="dataArray">データ</param>
        /// <param name="index">行位置</param>
        public ChangeStock(string id, string name, Type type, string date, string num, string tani, int dataNum, int changeRow, string[] dataArray, int index)
        {
            InitializeComponent();

            // 初期化
            this.ID = id;
            this.StockName = name;
            this.Type = type;
            this.Date = date;
            this.Num = num;
            this.Tani = tani;
            this.DataNum = dataNum;
            this.ChangeRow = changeRow;
            this.DataArray = dataArray;
            this.Index = index;

            // 種類によりラジオボタンを分岐
            switch (this.Type)
            {
                case Type.meet:
                    rdbType0.Checked = true;
                    break;

                case Type.fish:
                    rdbType1.Checked = true;
                    break;

                case Type.vegetable:
                    rdbType2.Checked = true;
                    break;

                case Type.fruit:
                    rdbType3.Checked = true;
                    break;

                case Type.snack:
                    rdbType4.Checked = true;
                    break;

                case Type.other:
                    rdbType5.Checked = true;
                    break;

                default:
                    break;
            }
        }
        #endregion

        /// <summary>
        /// デザインプロパティ設定
        /// </summary>
        private void SetDesignPropaty()
        {
            try
            {
                // タイトルの設定
                this.FormTitle = "在庫変更";

                // ボタン状態
                this.ButtonF1Enable = false;   // 削除
                this.ButtonF2Enable = false;   // 追加
                this.ButtonF3Enable = false;   // メンテナンス
                this.ButtonF4Enable = true;    // 確定
                this.ButtonF5Enable = true;    // 戻る

                // イベントの追加
                btnF4.Click += new EventHandler(BtnF4_Click);  // 削除

                // テキストボックスを初期化する
                txtID.Text = this.ID;
                txtName.Text = this.StockName;
                dateTimePicker.Text = this.Date;
                txtNum.Text = this.Num;
                txtTani.Text = this.Tani;


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
        private void ChangeStock_Load(object sender, EventArgs e)
        {
            try
            {
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
            FileImport fileImport = new FileImport(CommonFunc.INIPath, null);
            CommonFunc commonFunc = new CommonFunc();

            try
            {
                // ラジオボタンのプロパティセット
                SetType();

                // 変更したインデックスのデータを書き換えて配列に格納
                for (int index = 0; index < this.DataArray.Length; index++)
                {
                    // Indexが一致したものをカンマ区切り
                    if (index == this.Index)
                    {
                        this.DataArray[index] = this.txtID.Text + "," + this.txtName.Text + ","  + commonFunc.TypeChangeTypeToValue(this.type) + "," + this.dateTimePicker.Text + "," + this.txtNum.Text + "," + this.txtTani.Text;
                        break;
                    }
                }

                // ファイル更新
                fileImport.DelIniFile(this.DataArray);

                // フォームを閉じる
                this.Close();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region プライベートメソッド

        private void SetType()
        {
            try
            {
                // 種類によりラジオボタンを分岐
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
                else if (rdbType5.Checked == true)
                {
                    this.type = Type.other;
                }
                else
                {
                    this.type = Type.meet;
                }
            }
            catch
            {
                throw;
            }
        }

        #endregion
    }
}
