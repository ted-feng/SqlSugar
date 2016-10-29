using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Server.DataModel.RoutineBusinessModel
{
    public class CustTableModel
    {
        #region 字段
        private int custID;

        public int CustID
        {
            get { return custID; }
            set { custID = value; }
        }

        private string custCode;

        public string CustCode
        {
            get { return custCode; }
            set { custCode = value; }
        }

        private string custName;

        public string CustName
        {
            get { return custName; }
            set { custName = value; }
        }
        private string custNameAlias;

        public string CustNameAlias
        {
            get { return custNameAlias; }
            set { custNameAlias = value; }
        }
        private string lineDistance;

        public string LineDistance
        {
            get { return lineDistance; }
            set { lineDistance = value; }
        }
        private string invoiceAccoutID;

        public string InvoiceAccoutID
        {
            get { return invoiceAccoutID; }
            set { invoiceAccoutID = value; }
        }
        private int custGroupID;

        public int CustGroupID
        {
            get { return custGroupID; }
            set { custGroupID = value; }
        }
        private int costModelID;

        public int CostModelID
        {
            get { return costModelID; }
            set { costModelID = value; }
        }
        private string taxGroup;

        public string TaxGroup
        {
            get { return taxGroup; }
            set { taxGroup = value; }
        }
        private int locationID;

        public int LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }
        private int contactID;

        public int ContactID
        {
            get { return contactID; }
            set { contactID = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string spellCode;

        public string SpellCode
        {
            get { return spellCode; }
            set { spellCode = value; }
        }
        private string accountCode;

        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }

        private string isStop;

        public string IsStop
        {
            get { return isStop; }
            set { isStop = value; }
        }

        private string custGroupName;

        public string CustGroupName
        {
            get { return custGroupName; }
            set { custGroupName = value; }
        }


        private string costModelName;

        public string CostModelName
        {
            get { return costModelName; }
            set { costModelName = value; }
        }
        private int isEnabled;

        public int IsEnabled
        {
            get { return isEnabled; }
            set { isEnabled = value; }
        }

        private string custType;
        public string CustType
        {
            get { return custType; }
            set { custType = value; }
        }
        #endregion
    }
}
