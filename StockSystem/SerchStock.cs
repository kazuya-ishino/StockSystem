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
    public partial class SerchStock : StockSystemForm
    {
        #region プロパティ

        private Type type;

        /// <summary>
        /// INIファイルデータ
        /// </summary>
        private string[] IniFileData
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
        #endregion

        #region コンストラクタ
        public SerchStock()
        {
            InitializeComponent();
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
                this.FormTitle = "在庫一覧";

                // ボタン状態
                this.ButtonF1Enable = true;   // 削除
                this.ButtonF2Enable = true;   // 追加
                this.ButtonF3Enable = true;   // メンテナンス
                this.ButtonF4Enable = false;  // 確定
                this.ButtonF5Enable = true;   // 戻る

                // イベントの追加
                this.btnF1.Click += new EventHandler(BtnF1_Click);  // 削除
                this.btnF2.Click += new EventHandler(BtnF2_Click);  // 追加
                this.btnF3.Click += new EventHandler(BtnF3_Click);  // 変更

                // データグリッドビューの表示列の設定
                this.dgvSerchStock.ColumnCount = CommonFunc.IniDatanum;
                this.dgvSerchStock.RowCount = 99;

                // データグリッドビュー列ヘッダー定義
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_ID].HeaderText = CommonFunc.DGV_ID;      // ID
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_NAME].HeaderText = CommonFunc.DGV_NAME;  // 名前
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_TYPE].HeaderText = CommonFunc.DGV_TYPE;  // 種類
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_DATE].HeaderText = CommonFunc.DGV_DATE;  // 日付
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_NUM].HeaderText = CommonFunc.DGV_NUM;    // 数量

                // データグリッドビュー列幅調整
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_ID].Width = 100;      // ID
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_NAME].Width = 215;  // 名前
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_TYPE].Width = 100;  // 種類
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_DATE].Width = 120;  // 日付
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_NUM].Width = 100;    // 数量

                // データグリッドビューアライメント設定
                this.dgvSerchStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_ID].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;      // ID
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_NAME].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;  // 名前
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_TYPE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;  // 種類
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_DATE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;  // 日付
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_NUM].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;    // 数量

                // 列表示非表示設定
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_DATA_NUM].Visible = false;
                this.dgvSerchStock.Columns[CommonFunc.DGV_NUMBER_TANI].Visible = false;

                //ユーザーがセルを編集できないようにする
                dgvSerchStock.EditMode = DataGridViewEditMode.EditProgrammatically;

                //セルを選択すると行全体が選択されるようにする
                dgvSerchStock.MultiSelect = false;
                dgvSerchStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
        private void SerchStock_Load(object sender, EventArgs e)
        {

            try
            {
                // デザインプロパティ設定
                SetDesignPropaty();

                // 表示処理
                DisplaySerch();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 削除イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnF1_Click(object sender, EventArgs e)
        {
            string[] dataArray = new string[dgvSerchStock.RowCount];
            FileImport fileImport = new FileImport(CommonFunc.INIPath, null);

            try
            {
                // 選択グリッドの行を削除する
                dgvSerchStock.Rows.RemoveAt(dgvSerchStock.CurrentRow.Index);

                // 削除後のデータを配列に格納
                dataArray = GetArrayData();

                // 削除されたデータをINIファイルからも削除する
                fileImport.DelIniFile(dataArray);

                // 再描画
                DisplaySerch();
                AllDisplay();

            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 追加イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnF2_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock(this.DataNum, this.IDArray);
            try
            {
                // 追加ウィンドウを呼び出し
                addStock.Show();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnF3_Click(object sender, EventArgs e)
        {
            string id = string.Empty;
            string name = string.Empty;
            Type type = Type.meet;
            string date = string.Empty;
            string num = string.Empty;
            string tani = string.Empty;
            CommonFunc commonFunc = new CommonFunc();
            string[] dataArray = new string[dgvSerchStock.RowCount];

            try
            {
                if (dgvSerchStock.CurrentRow.Cells[CommonFunc.DGV_NUMBER_ID].Value != null)
                {
                    // 現在フォーカスのあるデータを引数に呼び出し
                    id = dgvSerchStock.CurrentRow.Cells[CommonFunc.DGV_NUMBER_ID].Value.ToString();
                    name = dgvSerchStock.CurrentRow.Cells[CommonFunc.DGV_NUMBER_NAME].Value.ToString();
                    type = commonFunc.TypeChangeNameToType(dgvSerchStock.CurrentRow.Cells[CommonFunc.DGV_NUMBER_TYPE].Value.ToString());
                    date = dgvSerchStock.CurrentRow.Cells[CommonFunc.DGV_NUMBER_DATE].Value.ToString();
                    num = dgvSerchStock.CurrentRow.Cells[CommonFunc.DGV_NUMBER_DATA_NUM].Value.ToString();
                    tani = dgvSerchStock.CurrentRow.Cells[CommonFunc.DGV_NUMBER_TANI].Value.ToString();
                }

                // 全データをカンマ区切りしたデータを取得
                dataArray = GetArrayData();
                ChangeStock changeStock = new ChangeStock(id, name, type, date, num, tani, this.DataNum, Convert.ToInt32(dgvSerchStock.CurrentRow.Index), dataArray, dgvSerchStock.CurrentRow.Index);

                // 追加ウィンドウを呼び出し
                changeStock.Show();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 行追加イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvSerchStock_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                if (dgv.RowHeadersVisible)
                {
                    //行番号を描画する範囲を決定する
                    Rectangle rect = new Rectangle(
                        e.RowBounds.Left, e.RowBounds.Top,
                        dgv.RowHeadersWidth, e.RowBounds.Height);
                    rect.Inflate(-2, -2);
                    //行番号を描画する
                    TextRenderer.DrawText(e.Graphics,
                        (e.RowIndex + 1).ToString(),
                        e.InheritedRowStyle.Font,
                        rect,
                        e.InheritedRowStyle.ForeColor,
                        TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 検索ボタン押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSerch_Click(object sender, EventArgs e)
        {
            try
            {
                // テキストボックス入力値により絞り込み
                ConditionsDisplaySerch(this.txtID.Text, this.txtName.Text);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 全検索ボタン押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtAllSerch_Click(object sender, EventArgs e)
        {
            try
            {
                // 全てを表示
                DisplaySerch();
                AllDisplay();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Formアクティブイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvSerchStock_Actived(object sender, EventArgs e)
        {
            try
            {
                // 全てを表示
                DisplaySerch();
                AllDisplay();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region プライベートメソッド
        /// <summary>
        /// 検索処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdbType_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // 保留
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 検索処理
        /// </summary>
        private void DisplaySerch()
        {
            FileImport fileImport = new FileImport(CommonFunc.INIPath, null);
            CommonFunc commonFunc = new CommonFunc();
            //string[] dataArray = new string[CommonFunc.IniDatanum];
            string[] dataArray = null;
            try
            {
                // INIファイルから在庫データを読み込み
                if (fileImport.CheckIniFile())
                {
                    // INIファイルからデータを取得
                    this.IniFileData = fileImport.GetIniFle(CommonFunc.IniSection, CommonFunc.IniKey, CommonFunc.INIPath + CommonFunc.IniFileName);
                    this.IDArray = new string[this.IniFileData.Length];

                    // 取得データをデータグリッドビューに表示
                    for (int gridrow = 0; gridrow < this.IniFileData.Length; gridrow++)
                    {
                        if (this.IniFileData[gridrow] == string.Empty)
                        {
                            // データ数を保持しておく
                            this.DataNum = gridrow + 1;
                            break;
                        }

                        // カンマ区切りデータをばらす
                        dataArray = this.IniFileData[gridrow].Split(',');

                        // 数量の生データをとるためにdataArray.Length + 1する
                        for (int gridcell = 0; gridcell < dataArray.Length + 1; gridcell++)
                        {
                            if (gridcell != 6)
                            {
                                this.dgvSerchStock.Rows[gridrow].Cells[gridcell].Value = dataArray[gridcell];
                            }

                            if (gridcell == 0)
                            {
                                // IDは追加画面で使うので保持する
                                this.IDArray[gridrow] = this.dgvSerchStock.Rows[gridrow].Cells[CommonFunc.DGV_NUMBER_ID].Value.ToString();
                            }

                            // 種類は変換して表示
                            if (gridcell == CommonFunc.DGV_NUMBER_TYPE)
                            {
                                this.dgvSerchStock.Rows[gridrow].Cells[gridcell].Value = commonFunc.TypeChangeValueToName(this.dgvSerchStock.Rows[gridrow].Cells[gridcell].Value.ToString());
                            }
                            // 日付けは"/"区切りで表示
                            else if (gridcell == CommonFunc.DGV_NUMBER_DATE)
                            {
                                //this.dgvSerchStock.Rows[gridrow].Cells[gridcell].Value = commonFunc.ChangeDate(this.dgvSerchStock.Rows[gridrow].Cells[gridcell].Value.ToString());
                                this.dgvSerchStock.Rows[gridrow].Cells[gridcell].Value = this.dgvSerchStock.Rows[gridrow].Cells[gridcell].Value.ToString();
                            }
                            // 数量はカンマ区切り
                            else if (gridcell == CommonFunc.DGV_NUMBER_NUM)
                            {
                                this.dgvSerchStock.Rows[gridrow].Cells[gridcell].Value = String.Format("{0:#,0}", Convert.ToInt64(this.dgvSerchStock.Rows[gridrow].Cells[gridcell].Value));
                            }
                            // 数量に単位をつける
                            else if (gridcell == CommonFunc.DGV_NUMBER_TANI)
                            {
                                this.dgvSerchStock.Rows[gridrow].Cells[CommonFunc.DGV_NUMBER_NUM].Value = this.dgvSerchStock.Rows[gridrow].Cells[CommonFunc.DGV_NUMBER_NUM].Value.ToString() + dgvSerchStock.Rows[gridrow].Cells[CommonFunc.DGV_NUMBER_TANI].Value.ToString();
                            }
                            // 数量(生データ)
                            else if (gridcell == CommonFunc.DGV_NUMBER_DATA_NUM)
                            {
                                this.dgvSerchStock.Rows[gridrow].Cells[CommonFunc.DGV_NUMBER_DATA_NUM].Value = dataArray[4];
                            }
                        }
                    }
                }
                else
                {
                    // INIファイルが存在しません
                    MessageBox.Show(CommonFunc.NoIniFile);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 絞り込み表示
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">名前</param>
        /// <param name="type">種類</param>
        private void ConditionsDisplaySerch(string id, string name)
        {
            try
            {
                // データグリッドビュー行数分ループし、条件が一致しない場合は非表示
                for (int index = 0; index < this.dgvSerchStock.RowCount; index++)
                {
                    // データが存在しない場合はループを抜ける
                    if (this.dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_ID].Value == null)
                    {
                        break;
                    }

                    // ID
                    if (id != string.Empty)
                    {
                        if (id != this.dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_ID].Value.ToString())
                        {
                            this.dgvSerchStock.Rows[index].Visible = false;
                            continue;
                        }
                        else
                        {
                            this.dgvSerchStock.Rows[index].Visible = true;
                        }
                    }
                    else
                    {
                        this.dgvSerchStock.Rows[index].Visible = true;
                    }
                    if (name != string.Empty)
                    {
                        // 名前
                        if (name != this.dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_NAME].Value.ToString())
                        {
                            this.dgvSerchStock.Rows[index].Visible = false;
                            continue;
                        }
                        else
                        {
                            this.dgvSerchStock.Rows[index].Visible = true;
                        }
                    }
                    else
                    {
                        this.dgvSerchStock.Rows[index].Visible = true;
                    }
                    // 種類
                    if (CommonFunc.TypeChangeValueToNameEX(this.ProType) != this.dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_TYPE].Value.ToString())
                    {
                        this.dgvSerchStock.Rows[index].Visible = false;
                        continue;
                    }
                    else
                    {
                        this.dgvSerchStock.Rows[index].Visible = true;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 全て表示する
        /// </summary>
        private void AllDisplay()
        {
            try
            {
                // 全ての行を表示設定に変更
                for (int index = 0; index < this.dgvSerchStock.RowCount; index++)
                {
                    if (this.dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_ID].Value == null)
                    {
                        break;
                    }
                    else
                    {
                        this.dgvSerchStock.Rows[index].Visible = true;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// カンマ区切りのデータを取得
        /// </summary>
        private string[] GetArrayData()
        {
            string[] dataArray = new string[dgvSerchStock.RowCount];
            CommonFunc commonFunc = new CommonFunc();

            try
            {
                for (int index = 0; index < dgvSerchStock.RowCount; index++)
                {
                    if (dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_ID].Value != null)
                    {
                        // カンマ区切りで格納
                        dataArray[index] = dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_ID].Value.ToString();
                        dataArray[index] = dataArray[index] + "," + dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_NAME].Value.ToString();
                        dataArray[index] = dataArray[index] + "," + commonFunc.TypeChangeNameToValue(dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_TYPE].Value.ToString()).ToString();
                        dataArray[index] = dataArray[index] + "," + dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_DATE].Value.ToString();
                        dataArray[index] = dataArray[index] + "," + dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_DATA_NUM].Value.ToString();
                        dataArray[index] = dataArray[index] + "," + dgvSerchStock.Rows[index].Cells[CommonFunc.DGV_NUMBER_TANI].Value.ToString();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch
            {
                throw;
            }

            return dataArray;
        }

        #endregion
    }
}
