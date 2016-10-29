using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CSSD.Server.DataModel.RoutineBusinessModel
{
    public class TurnAroundJournalModel
    {
        #region 字段

        private int turnAroundID;

        public int TurnAroundID
        {
            get { return turnAroundID; }
            set { turnAroundID = value; }
        }

        private string deliveryPointIdActual;

        public string DeliveryPointIdActual
        {
            get { return deliveryPointIdActual; }
            set { deliveryPointIdActual = value; }
        }

        private int? serviceRequirementId;

        public int? ServiceRequirementId
        {
            get { return serviceRequirementId; }
            set { serviceRequirementId = value; }
        }

        private DateTime? expiry;

        public DateTime? Expiry
        {
            get { return expiry; }
            set { expiry = value; }
        }

        private int? itemid;

        public int? Itemid
        {
            get { return itemid; }
            set { itemid = value; }
        }

        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private int? itemCategoryID;

        public int? ItemCategoryID
        {
            get { return itemCategoryID; }
            set { itemCategoryID = value; }
        }

        private string accountCode;

        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }

        private DateTime? createtime;

        public DateTime? Createtime
        {
            get { return createtime; }
            set { createtime = value; }
        }

        private int? createuserid;

        public int? Createuserid
        {
            get { return createuserid; }
            set { createuserid = value; }
        }

        private int? isstop;

        public int? Isstop
        {
            get { return isstop; }
            set { isstop = value; }
        }

        private int? itemnumber;

        public int? Itemnumber
        {
            get { return itemnumber; }
            set { itemnumber = value; }
        }

        private int? custid;

        public int? Custid
        {
            get { return custid; }
            set { custid = value; }
        }

        private int? deliverypointid;

        public int? Deliverypointid
        {
            get { return deliverypointid; }
            set { deliverypointid = value; }
        }

        private int? barcodetype;

        public int? Barcodetype
        {
            get { return barcodetype; }
            set { barcodetype = value; }
        }

        private int? workbenchid;

        public int? Workbenchid
        {
            get { return workbenchid; }
            set { workbenchid = value; }
        }

        private string itemsstatus;

        public string Itemsstatus
        {
            get { return itemsstatus; }
            set { itemsstatus = value; }
        }

        private string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        private string remark1;

        public string Remark1
        {
            get { return remark1; }
            set { remark1 = value; }
        }

        private string remark2;

        public string Remark2
        {
            get { return remark2; }
            set { remark2 = value; }
        }

        private string remark3;

        public string Remark3
        {
            get { return remark3; }
            set { remark3 = value; }
        }

        private string startStationTypeID;

        public string StartStationTypeID
        {
            get { return startStationTypeID; }
            set { startStationTypeID = value; }
        }

        private string currentStationTypeID;

        public string CurrentStationTypeID
        {
            get { return currentStationTypeID; }
            set { currentStationTypeID = value; }
        }

        private string archvedUserID;

        public string ArchvedUserID
        {
            get { return archvedUserID; }
            set { archvedUserID = value; }
        }

        private DateTime? archivedDatetime;

        public DateTime? ArchivedDatetime
        {
            get { return archivedDatetime; }
            set { archivedDatetime = value; }
        }

        private int? washMachineID;

        /// <summary>
        /// 清洗机器ID
        /// </summary>
        public int? WashMachineID
        {
            get { return washMachineID; }
            set { washMachineID = value; }
        }

        private int? disinfectMachineID;

        /// <summary>
        /// 灭菌机器ID
        /// </summary>
        public int? DisinfectMachineID
        {
            get { return disinfectMachineID; }
            set { disinfectMachineID = value; }
        }

        private int? washSysBatchID;

        /// <summary>
        /// 清洗批次ID
        /// </summary>
        public int? WashSysBatchID
        {
            get { return washSysBatchID; }
            set { washSysBatchID = value; }
        }

        private int? disinfectSysBatchID;

        /// <summary>
        /// 灭菌批次ID
        /// </summary>
        public int? DisinfectSysBatchID
        {
            get { return disinfectSysBatchID; }
            set { disinfectSysBatchID = value; }
        }

        private DateTime? startdate;

        public DateTime? StartDate
        {
            get { return startdate; }
            set { startdate = value; }
        }

        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private DateTime? singlePlanTime;

        public DateTime? SinglePlanTime
        {
            get { return singlePlanTime; }
            set { singlePlanTime = value; }
        }

        #endregion 字段
    }
}