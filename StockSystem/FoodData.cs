/* ------------------------------------- */
/* Ver       日付         名前
/* Rev 1.0   20210809     K.Ishino */
/* 食材情報取得クラス画面 */
/* ------------------------------------- */

using System;
using System.Collections.Generic;
using System.Text;

namespace StockSystem
{
    public class FoodData
    {
        #region プロパティ
        /// <summary>
        /// 食材ID
        /// </summary>
        public string FoodID
        {
            get;
            private set;
        }

        /// <summary>
        /// 食材名
        /// </summary>
        public string FoodName
        {
            get;
            private set;
        }

        /// <summary>
        /// 分類
        /// 0:肉、1:魚、2:野菜、3:果物、4:お菓子、5:その他
        /// </summary>
        public int FoodType
        {
            get;
            private set;
        }

        /// <summary>
        /// 期限
        /// </summary>
        public string FoodDate
        {
            get;
            private set;
        }

        /// <summary>
        /// 数量
        /// </summary>
        public string FoodNum
        {
            get;
            private set;
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// <param name="foodID">サンプル</param>
        /// <param name="foodName">食材名</param>
        /// <param name="foodType">種類</param>
        /// <param name="foodDate">期限</param>
        /// <param name="foodNum">数量</param>
        /// </summary>
        public FoodData(string foodID, string foodName, int foodType, string foodDate, string foodNum)
        {
            FoodID = foodID;
            FoodName = foodName;
            FoodType = foodType;
            FoodDate = foodDate;
            FoodNum = foodNum;
        }
        #endregion

        #region パブリックメソッド
        /// <summary>
        /// サンプル
        /// <param name="sample">サンプル</param>
        /// </summary>
        public void Sample()
        {
            return;
        }
        
        #endregion
    }
}
