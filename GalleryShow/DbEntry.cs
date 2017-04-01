using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryShow
{
    public class DbEntry
    {

        public static IDbConnection GetSqlCon(string dbname)
        {
            string sql = ConfigurationManager.ConnectionStrings[dbname].ConnectionString;
            MySql.Data.MySqlClient.MySqlConnection db = new MySql.Data.MySqlClient.MySqlConnection(sql);
            db.Open();
            return db;
        }
    }
}
