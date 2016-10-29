using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSSD.Server.DataModel.ManagerBenchModel;
using System.Data;
using SqlSugar;
using System.Data.SqlClient;

namespace OrmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlParameter[] sp = new SqlParameter[] { new SqlParameter("name", 1) };
            var ss = SqlSugarTool.GetParameters(sp);

            CodeTimer.InitializeByConcurrent();
            CodeTimerResult ret = CodeTimer.Execute("sugar", 1, new Action(() =>
            {
                using (SqlSugarClient db = new SqlSugarClient(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer1"].ConnectionString))
                {
                    //var list = db.GetDataTable("select * from AccountCode where AccountType=1", new { });
                    //var list = db.GetDataTable("select * from AccountCode where AccountType=@AccountType", new { AccountType = 1 });
                    var list = db.Queryable<AccountCodeModel1>("AccountCode").Where<AccountCodeModel1>(c => c.AccountType == 1).ToList();
                    int rowCount = list.Count;
                }
            }));
            //Console.ReadKey();
        }
    }
}
