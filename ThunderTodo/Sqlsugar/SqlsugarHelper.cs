/**
* Namespace: ThunderTodo.Sqlsugar
* Name:      SqlsugarHelper
* Author:    江挺
* Time:      2022/10/19 15:55:09
* Ver:       1.0
*
* Info: N/A
*/

using SqlSugar;

namespace ThunderTodo.Sqlsugar
{
    public sealed class SqlsugarHelper
    {
        //private static readonly SqlsugarHelper instance = new SqlsugarHelper();

        //static SqlsugarHelper() { }

        //private SqlsugarHelper() { }

        //public static SqlsugarHelper Instance 
        //{
        //    get 
        //    {
        //        return instance;
        //    }
        //}

        //public static SqlSugarScope Db = new SqlSugarScope(new ConnectionConfig() 
        //{
        //    ConnectionString = @"Data Source=ALIENS-JT\SQLEXPRESS;Initial Catalog=Todo;Persist Security Info=True;User ID=sa;Password=Aa123456",
        //    DbType = DbType.SqlServer,
        //    IsAutoCloseConnection = true
        //},
        //db => 
        //{
        //    db.Aop.OnLogExecuting = (sql, pars) =>
        //    {
        //        Console.WriteLine(sql);
        //    };
        //});

        private static readonly SqlSugarScope instance = new SqlSugarScope(new ConnectionConfig()
        {
            ConnectionString = @"Data Source=ALIENS-JT\SQLEXPRESS;Initial Catalog=Todo;Persist Security Info=True;User ID=sa;Password=Aa123456",
            DbType = DbType.SqlServer,
            IsAutoCloseConnection = true
        });

        private SqlsugarHelper() { }


        public static SqlSugarScope GetInstance()
        {
            return instance;
        }
    }
}
