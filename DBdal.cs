using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleColoredBall
{
    public static class DBdal
    {
        private static string dataSource = "db.dll";
        private static string passWord = "123";

        public static void CreateDB()
        {
            try
            {
                SQLiteHelper Helper = new SQLiteHelper(dataSource);
                Helper.CreateDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void CreateTable()
        {
            string sql = "";
        
        }

    }
}
