using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD.Server.DataModel.ManagerBenchModel
{
    public class AccountCodeModel1
    {
        #region 字段
        private string accountCode;

        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }

        private int accountType;

        public int AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        #endregion
    }
}
