using System;

namespace StockSystem
{
    public class CommonFunc
    {
        #region メッセージ
        public const string NoIniFile = "INIファイルが存在しません";
        public const string IDDuplicate = "IDが重複しています";
        #endregion

        /// <summary>
        /// F12 戻る
        /// </summary>
        public const string F12Text = "戻る";

        #region INI定数
        /// <summary>
        /// INIファイル名
        /// </summary>
        public const string IniFileName = "stock.ini";

        /// <summary>
        /// INIファイルパス
        /// </summary>
        public const string INIPath = @"C:\StockSystem\INI\";

        /// <summary>
        /// INIセクション名
        /// </summary>
        public const string IniSection = "stockdata";

        /// <summary>
        /// INIキー名
        /// </summary>
        public const string IniKey = "data";

        /// <summary>
        /// INIファイルデータ数
        /// </summary>
        public const int IniDatanum = 7;
        #endregion

        #region 最大最小定数
        /// <summary>
        /// 最大保存件数(99件)
        /// </summary>
        public const int Maxkeep = 99;
        #endregion

        #region 列定数
        /// <summary>
        /// ID
        /// </summary>
        public const string DGV_ID = "ID";

        /// <summary>
        /// 名前
        /// </summary>
        public const string DGV_NAME = "名前";

        /// <summary>
        /// 種類
        /// </summary>
        public const string DGV_TYPE = "種類";

        /// <summary>
        /// 日付
        /// </summary>
        public const string DGV_DATE = "期限";

        /// <summary>
        /// 数量
        /// </summary>
        public const string DGV_NUM = "数量";

        /// <summary>
        /// 単位
        /// </summary>
        public const string DGV_TANI = "単位";
        #endregion

        #region 列番号
        /// <summary>
        /// ID
        /// </summary>
        public const int DGV_NUMBER_ID = 0;

        /// <summary>
        /// 名前
        /// </summary>
        public const int DGV_NUMBER_NAME = 1;

        /// <summary>
        /// 種類
        /// </summary>
        public const int DGV_NUMBER_TYPE = 2;

        /// <summary>
        /// 日付
        /// </summary>
        public const int DGV_NUMBER_DATE = 3;

        /// <summary>
        /// 数量
        /// </summary>
        public const int DGV_NUMBER_NUM = 4;

        /// <summary>
        /// 単位
        /// </summary>
        public const int DGV_NUMBER_TANI = 5;

        /// <summary>
        /// 数量(生データ)
        /// </summary>
        public const int DGV_NUMBER_DATA_NUM = 6;
        #endregion

        #region 種類定数
        /// <summary>
        /// 肉(値)
        /// </summary>
        public const string MeetValue = "0";

        /// <summary>
        /// 魚(値)
        /// </summary>
        public const string FishValue = "1";

        /// <summary>
        /// 野菜(値)
        /// </summary>
        public const string VegetableValue = "2";

        /// <summary>
        /// 果実(値)
        /// </summary>
        public const string FruitValue = "3";

        /// <summary>
        /// お菓子(値)
        /// </summary>
        public const string SnackValue = "4";

        /// <summary>
        /// その他(値)
        /// </summary>
        public const string OtherValue = "5";

        /// <summary>
        /// 肉
        /// </summary>
        public const string MeetName = "肉";

        /// <summary>
        /// 魚
        /// </summary>
        public const string FishName = "魚";

        /// <summary>
        /// 野菜
        /// </summary>
        public const string VegetableName = "野菜";

        /// <summary>
        /// 果実
        /// </summary>
        public const string FruitName = "果実";

        /// <summary>
        /// お菓子
        /// </summary>
        public const string SnackName = "お菓子";

        /// <summary>
        /// その他
        /// </summary>
        public const string OtherName = "その他";
        #endregion

        public CommonFunc()
        {
        }

        /// <summary>
        /// 種類を値→名前に変換
        /// </summary>
        /// <param name="value">種類の値</param>
        public string TypeChangeValueToName(string value)
        {
            string name = string.Empty;
            try
            {
                switch (value)
                {
                    case MeetValue:
                        name = MeetName;
                        break;

                    case FishValue:
                        name = FishName;
                        break;

                    case VegetableValue:
                        name = VegetableName;
                        break;

                    case FruitValue:
                        name = FruitName;
                        break;

                    case SnackValue:
                        name = SnackName;
                        break;

                    case OtherValue:
                        name = OtherName;
                        break;

                    default:
                        break;

                }
            }
            catch
            {
                throw;
            }
            return name;
        }

        /// <summary>
        /// 種類を値→名前に変換
        /// </summary>
        /// <param name="value">種類の値</param>
        public static string TypeChangeValueToNameEX(Type value)
        {
            string name = string.Empty;
            try
            {
                switch (value)
                {
                    case Type.meet:
                        name = MeetName;
                        break;

                    case Type.fish:
                        name = FishName;
                        break;

                    case Type.vegetable:
                        name = VegetableName;
                        break;

                    case Type.fruit:
                        name = FruitName;
                        break;

                    case Type.snack:
                        name = SnackName;
                        break;

                    case Type.other:
                        name = OtherName;
                        break;

                    default:
                        break;

                }
            }
            catch
            {
                throw;
            }
            return name;
        }

        /// <summary>
        /// 種類を値→INIファイルの値に変換
        /// </summary>
        /// <param name="value">種類の値</param>
        public string TypeChangeTypeToValue(Type value)
        {
            string name = string.Empty;
            try
            {
                switch (value)
                {
                    case Type.meet:
                        name = MeetValue;
                        break;

                    case Type.fish:
                        name = FishValue;
                        break;

                    case Type.vegetable:
                        name = VegetableValue;
                        break;

                    case Type.fruit:
                        name = FruitValue;
                        break;

                    case Type.snack:
                        name = SnackValue;
                        break;

                    case Type.other:
                        name = OtherValue;
                        break;

                    default:
                        break;

                }
            }
            catch
            {
                throw;
            }
            return name;
        }

        /// <summary>
        /// 名前→Typeの値に変換
        /// </summary>
        /// <param name="name">名前</param>
        public Type TypeChangeNameToType(string name)
        {
            Type type = Type.meet;
            try
            {
                switch (name)
                {
                    case MeetName:
                        type = Type.meet;
                        break;

                    case FishName:
                        type = Type.fish;
                        break;

                    case VegetableName:
                        type = Type.vegetable;
                        break;

                    case FruitName:
                        type = Type.fruit;
                        break;

                    case SnackName:
                        type = Type.snack;
                        break;

                    case OtherName:
                        type = Type.other;
                        break;

                    default:
                        break;

                }
            }
            catch
            {
                throw;
            }
            return type;
        }

        /// <summary>
        /// 名前→値に変換
        /// </summary>
        /// <param name="name">名前</param>
        public string TypeChangeNameToValue(string name)
        {
            string value = string.Empty;
            try
            {
                switch (name)
                {
                    case MeetName:
                        value = MeetValue;
                        break;

                    case FishName:
                        value = FishValue;
                        break;

                    case VegetableName:
                        value = VegetableValue;
                        break;

                    case FruitName:
                        value = FruitValue;
                        break;

                    case SnackName:
                        value = SnackValue;
                        break;

                    case OtherName:
                        value = OtherValue;
                        break;

                    default:
                        break;

                }
            }
            catch
            {
                throw;
            }
            return value;
        }

        /// <summary>
        /// 日付を"/"で区切る
        /// </summary>
        /// <param name="date">変換前日付</param>
        public string ChangeDate(string date)
        {
            string changedate = string.Empty;
            try
            {
                // 文字数をチェックしエラーを防ぐ
                if (date.Length == 8)
                {
                    changedate = date.Substring(0, 4) + "/" + date.Substring(4, 2) + "/" + date.Substring(6, 2);
                }
            }
            catch
            {
                throw;
            }
            return changedate;
        }
    }
    }
