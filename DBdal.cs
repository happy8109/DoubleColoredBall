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
            SQLiteHelper Helper = new SQLiteHelper(dataSource);
            //CREATE TABLE "SSQ" ( `AutoID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `Code` TEXT NOT NULL, `Date` TEXT NOT NULL, `Week` TEXT NOT NULL, `Red` TEXT NOT NULL, `Blue` TEXT NOT NULL, `Poolmoney` INTEGER NOT NULL, `Sales` INTEGER NOT NULL, `P1count` INTEGER NOT NULL, `P1money` INTEGER NOT NULL, `P2count` INTEGER NOT NULL, `P2money` INTEGER NOT NULL, `P3count` INTEGER NOT NULL, `P3money` INTEGER NOT NULL, `P4count` INTEGER NOT NULL, `P4money` INTEGER NOT NULL, `P5count` INTEGER NOT NULL, `P5money` INTEGER NOT NULL, `P6count` INTEGER NOT NULL, `P6money` INTEGER NOT NULL, `P7count` INTEGER NOT NULL, `P7money` INTEGER NOT NULL, `Content` TEXT NOT NULL, `DetailsLink` TEXT NOT NULL, `VideoLink` TEXT NOT NULL )
            if (Helper.TableIsExist("SSQ"))
            {
                return;
            }
            string sql = "CREATE TABLE 'SSQ' ( `AutoID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `Code` TEXT NOT NULL, `Date` TEXT NOT NULL, `Week` TEXT NOT NULL, `Red` TEXT NOT NULL, `Blue` TEXT NOT NULL, `Poolmoney` INTEGER NOT NULL, `Sales` INTEGER NOT NULL, `P1count` INTEGER NOT NULL, `P1money` INTEGER NOT NULL, `P2count` INTEGER NOT NULL, `P2money` INTEGER NOT NULL, `P3count` INTEGER NOT NULL, `P3money` INTEGER NOT NULL, `P4count` INTEGER NOT NULL, `P4money` INTEGER NOT NULL, `P5count` INTEGER NOT NULL, `P5money` INTEGER NOT NULL, `P6count` INTEGER NOT NULL, `P6money` INTEGER NOT NULL, `P7count` INTEGER NOT NULL, `P7money` INTEGER NOT NULL, `Content` TEXT NOT NULL, `DetailsLink` TEXT NOT NULL, `VideoLink` TEXT NOT NULL )";
            Helper.ExecuteNonQuery(sql, null);
        }

    }
}
