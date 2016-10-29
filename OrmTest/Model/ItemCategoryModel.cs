using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Server.DataModel.RoutineBusinessModel
{
    [Serializable]
    public class ItemCategoryModel
    {
        #region 字段
        private int? itemCategoryID;

        public int? ItemCategoryID
        {
            get { return itemCategoryID; }
            set { itemCategoryID = value; }
        }
        private string itemCategoryName;

        public string ItemCategoryName
        {
            get { return itemCategoryName; }
            set { itemCategoryName = value; }
        }

        private string customID;

        public string CustomID
        {
            get { return customID; }
            set { customID = value; }
        }

        private string itemCategoryDesc;

        public string ItemCategoryDesc
        {
            get { return itemCategoryDesc; }
            set { itemCategoryDesc = value; }
        }
        private string custID;

        public string CustID
        {
            get { return custID; }
            set { custID = value; }
        }
        private int? deliveryPointID;

        public int? DeliveryPointID
        {
            get { return deliveryPointID; }
            set { deliveryPointID = value; }
        }

        private int? itemCategoryNumber;

        public int? ItemCategoryNumber
        {
            get { return itemCategoryNumber; }
            set { itemCategoryNumber = value; }
        }

        private string reversion;

        public string Reversion
        {
            get { return reversion; }
            set { reversion = value; }
        }
        private int? sTDItemTypeID;

        public int? STDItemTypeID
        {
            get { return sTDItemTypeID; }
            set { sTDItemTypeID = value; }
        }
        private int? userIDCreated;

        public int? UserIDCreated
        {
            get { return userIDCreated; }
            set { userIDCreated = value; }
        }
        private int? userIDArchived;

        public int? UserIDArchived
        {
            get { return userIDArchived; }
            set { userIDArchived = value; }
        }
        private DateTime? createdDatetime;

        public DateTime? CreatedDatetime
        {
            get { return createdDatetime; }
            set { createdDatetime = value; }
        }
        private DateTime? archivedDatetime;

        public DateTime? ArchivedDatetime
        {
            get { return archivedDatetime; }
            set { archivedDatetime = value; }
        }
        private string expiredPeriod;

        public string ExpiredPeriod
        {
            get { return expiredPeriod; }
            set { expiredPeriod = value; }
        }
        private string accountCode;

        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }
        private string spellCode;

        public string SpellCode
        {
            get { return spellCode; }
            set { spellCode = value; }
        }

        private int? isStop;

        public int? IsStop
        {
            get { return isStop; }
            set { isStop = value; }
        }

        private string itemCategoryCode;
        public string ItemCategoryCode
        {
            get { return itemCategoryCode; }
            set { itemCategoryCode = value; }
        }

        private string barcodeFlag;
        public string BarcodeFlag
        {
            get { return barcodeFlag; }
            set { barcodeFlag = value; }
        }

        private int? pmID;
        /// <summary>
        /// 包装材料ID
        /// </summary>
        public int? PMID
        {
            get { return pmID; }
            set { pmID = value; }
        }
        private decimal? stPrice;

        /// <summary>
        /// 普通服务价格
        /// </summary>
        public decimal? STPrice
        {
            get { return stPrice; }
            set { stPrice = value; }
        }
        private decimal? ftPrice;

        /// <summary>
        /// 快速服务价格
        /// </summary>
        public decimal? FTPrice
        {
            get { return ftPrice; }
            set { ftPrice = value; }
        }
        private decimal? otherPrice;

        /// <summary>
        /// 其他价格
        /// </summary>
        public decimal? OtherPrice
        {
            get { return otherPrice; }
            set { otherPrice = value; }
        }
        private int? isPrintDetail;

        /// <summary>
        /// 是否打印明细
        /// </summary>
        public int? IsPrintDetail
        {
            get { return isPrintDetail; }
            set { isPrintDetail = value; }
        }

        private int? isEnabled;

        public int? IsEnabled
        {
            get { return isEnabled; }
            set { isEnabled = value; }
        }

        #endregion
    }
}
