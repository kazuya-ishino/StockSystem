using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Linq;

namespace StockSystem
{
    public class FileImport
    {
        #region プロパティ
        /// <summary>
        /// 在庫状態INIパス
        /// </summary>
        public string StockINIPath
        {
            get;
            private set;
        }

        /// <summary>
        /// メッセージファイルINIパス
        /// </summary>
        public string MessageINIPath
        {
            get;
            private set;
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="iniPath">INIファイルパス</param>
        /// <param name="messagePath">メッセージファイルパス</param>
        public FileImport(string iniPath, string messagePath)
        {
            try
            {
                // nullチェック
                if (iniPath == null)
                {
                    iniPath = "";
                }
                if (messagePath == null)
                {
                    messagePath = "";
                }

                // INIファイルパス設定
                this.StockINIPath = iniPath;
                this.MessageINIPath = messagePath;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region パブリックメソッド
        /// <summary>
        /// INIファイルの存在チェック
        /// </summary>
        public bool CheckIniFile()
        {
            bool Iniflag = false;
            try
            {
                /* ---ファイルチェック ----- */
                //path = Environment.ExpandEnvironmentVariables(path);
                if (!System.IO.Directory.Exists(this.StockINIPath))
                {
                    return Iniflag;
                }
                // ファイル名取得
                string[] files = System.IO.Directory.GetFiles(this.StockINIPath, "*");
                for (int index = 0; index < files.Length; index++)
                {
                    files[index] = System.IO.Path.GetFileName(files[index]);
                }
                if (files != null)
                {
                    Iniflag = true;
                }
                else
                {
                    // ファイルパス
                    string path = @"C:\StockSystem\INI\stock.ini";
                    // FileInfoのインスタンスを生成する
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
                    // ファイルを作成する
                    System.IO.FileStream fileStream = fileInfo.Create();
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\StockSystem\INI\stock.ini", true, System.Text.Encoding.GetEncoding("shift_jis"));
                    sw.Write("[stockdata]" + sw.NewLine);
                }
                /* ---ファイルチェック ----- */
            }
            catch
            {
                throw;
            }

            return Iniflag;
        }

        /// <summary>
        /// INIファイルにデータを追加
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">名前</param>
        /// <param name="type">種類</param>
        /// <param name="date">日付</param>
        /// <param name="num">数量</param>
        /// <param name="tani">単位</param>
        public void CreateIniFile(string id, string name, Type type, string date, string num, string tani, int datanum)
        {
            string data = string.Empty;
            CommonFunc commonFunc = new CommonFunc();
            try
            {
                // カンマ区切りで変数に格納
                data = "data" + datanum.ToString() + "=" + id + "," + name + "," + commonFunc.TypeChangeTypeToValue(type) + "," + date + "," + num + "," + tani;
                // カンマ区切りでINIファイルに追加
                System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\StockSystem\INI\stock.ini", true, System.Text.Encoding.GetEncoding("shift_jis"));
                sw.Write(data + sw.NewLine);
                //閉じる
                sw.Close();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// INIファイルのデータを削除
        /// </summary>
        /// <param name="dataArray">全データ</param>
        public void DelIniFile(string[] dataArray)
        {
            string data = string.Empty;
            CommonFunc commonFunc = new CommonFunc();
            try
            {
                // 指定ファイルを削除
                System.IO.File.Delete(@"C:\StockSystem\INI\stock.ini");

                // ファイルパス
                string path = @"C:\StockSystem\INI\stock.ini";
                // FileInfoのインスタンスを生成する
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
                // ファイルを作成する
                System.IO.FileStream fileStream = fileInfo.Create();
                // ファイルを閉じる
                fileStream.Close();
                // セクション名を挿入
                System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\StockSystem\INI\stock.ini", true, System.Text.Encoding.GetEncoding("shift_jis"));
                sw.Write("[stockdata]" + sw.NewLine);

                // ファイルにデータを追加
                for (int count = 1; count <= dataArray.Length; count++)
                {
                    if (dataArray[count - 1] != null)
                    {
                        // key名をつける
                        data = "data" + count.ToString() + "=" + dataArray[count - 1];
                        sw.Write(data + sw.NewLine);
                    }
                    else
                    {
                        break;
                    }
                }

                // ファイルを閉じる
                sw.Close();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// INIファイルから在庫データを取得
        /// </summary>
        public string[] GetIniFle(string iniSection, string iniKey, string iniPath)
        {
            string[] stockDataArry = new string[CommonFunc.Maxkeep];
            int datarow = 1;
            try
            {
                for (int row = 0; row < CommonFunc.Maxkeep; row++)
                {
                    // 空の場合はそこでデータがないとみなし終了
                    stockDataArry[row] = GetIniString(iniSection, iniKey + datarow.ToString(), iniPath);
                    if (stockDataArry[row] == string.Empty)
                    {
                        break;
                    }
                    datarow++;
                }
            }
            catch
            {
                throw;
            }
            return stockDataArry;
        }

        [DllImport("KERNEL32.DLL")]
        private static extern uint GetPrivateProfileString(
        string lpAppName,
        string lpKeyName,
        string lpDefault,
        StringBuilder lpReturnedString,
        uint nSize,
        string lpFileName);

        [DllImport("KERNEL32.DLL")]
        private static extern uint GetPrivateProfileInt(
            string lpAppName,
            string lpKeyName,
            int nDefault,
            string lpFileName);

        [DllImport("KERNEL32.DLL")]
        private static extern uint WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFileName);

        /// <summary>
        /// INIファイルから値を取得する
        /// </summary>
        /// <param name="lpSection">セッション名称</param>
        /// <param name="lpKeyName">キー名称</param>
        /// <param name="lpFileName">INIファイル名</param>
        /// <returns></returns>
        public static string GetIniString(string lpSection, string lpKeyName, string lpFileName)
        {
            System.Text.StringBuilder strValue = new System.Text.StringBuilder(1024);

            uint sLen = GetPrivateProfileString(lpSection, lpKeyName, "", strValue, 1024, lpFileName);

            return strValue.ToString();
        }

        /// <summary>
        /// INIファイルに値を書き込む
        /// </summary>
        /// <param name="lpSection">セッション名称</param>
        /// <param name="lpKeyName">キー名称</param>
        /// <param name="lpValue">セットする値</param>
        /// <param name="lpFileName">INIファイル名</param>
        /// <returns></returns>
        public static bool PutIniString(string lpSection, string lpKeyName, string lpValue, string lpFileName)
        {
            long result = WritePrivateProfileString(lpSection, lpKeyName, lpValue, lpFileName);
            return result != 0;
        }
        #endregion
    }
}
