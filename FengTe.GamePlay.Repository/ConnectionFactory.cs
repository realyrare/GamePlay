using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace FengTe.GamePlay.Repository
{
  public  class ConnectionFactory
    {
        private static readonly string ConnString = ConfigurationManager.ConnectionStrings["MSSQL_GamePlayDB"].ConnectionString;
     
        private static readonly string ConnStringType = ConfigurationManager.AppSettings["ConnMsSql"];

        #region 单例模式
        //// 定义一个静态变量来保存类的实例
        //private static IDbConnection connection =null;
        //// 定义一个标识确保线程同步
        //private static readonly object locker = new object();
        ///// <summary>
        ///// 私有构造函数防止外界通过new创建实例
        ///// </summary>
        //private ConnectionFactory()
        //{

        //}
        ///// <summary>
        ///// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        ///// </summary>
        ///// <returns></returns>
        //public static IDbConnection Connection()
        //{
        //    // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
        //    // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
        //    // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
        //    // 双重锁定只需要一句判断就可以了
        //    if (connection == null)
        //    {
        //        lock (locker)
        //        {
        //            if (connection == null)
        //            {
        //                connection = new SqlConnection(ConnString);

        //            }
        //        }
        //    }          
        //    connection.Open();
        //    return connection;
        //} 
        #endregion
        public static IDbConnection Connection()
        {
            IDbConnection conn = null;
            switch (ConnStringType)
            {
                case "SQLServer":

                    conn = new SqlConnection(ConnString);
                    break;
                //-------需要切换mySql时 下载MySQL.Data.dll程序集引用该层应用即可--------------------
                //  case "MySQL":
                //   conn = new MySqlConnection(ConnString);
                //   break;
                default:
                    conn = new SqlConnection(ConnString);
                    break;
            }
            conn.Open();
            return conn;

        }
    }
}
