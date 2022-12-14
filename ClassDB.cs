using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace YP
{
    class ClassDB
    {
        public const string TABLE_UCHENIKI = "yp_ucheniki";
        public const string TABLE_VRACHI = "yp_vrachi";
        public const string TABLE_ZAPISI = "yp_zapisi";

        public static string connstr = @"Data Source=62.78.81.19;Initial Catalog=Medpunkt;User ID=stud;Password=123456789";
        
        public static DataTable Query(string sql)
        {
            Console.WriteLine("--------sql------------");
            Console.WriteLine(sql);
            Console.WriteLine("--------...------------");

            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connstr);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                ClassMessage.showError($"Ошибка обращения к БД! \nПроверьте вводимые данные \n {ex.Message}");
                return null;
            }
            return dt;
        }

        public static DataRow[] findLoginUser(string table, string login)
        {
            return ClassDB.Query("SELECT * FROM [dbo].[" + table + "] where [login] LIKE '" + login + "';").Select();
        }

        public static void updateOrInsertUchenik(string familia, string ima, string otchestvo, DateTime date_rozhdeniia, string telefon, string pol, string klass, string login, string id = "")
        {
            string sqlUpdateOrInsertUchenik;
            if (id == "")
            {
                sqlUpdateOrInsertUchenik = $@"INSERT INTO [dbo].[{ClassDB.TABLE_UCHENIKI}]
                (
                    [familia],
                    [ima],
                    [otchestvo],
                    [date_rozhdeniia],
                    [telefon],
                    [pol],
                    [klass],
                    [login],
                    [pwd]
                ) VALUES (
                    '{familia}',
                    '{ima}',
                    '{otchestvo}',
                    '{date_rozhdeniia}',
                    '{telefon}',
                    '{pol}',
                    '{klass}',
                    '{login}',
                    '111'
                );";
            } else {
                sqlUpdateOrInsertUchenik = $"UPDATE [dbo].[{ClassDB.TABLE_UCHENIKI}] SET " +
                $" [familia] ='{familia}',  [ima] ='{ima}', [otchestvo] ='{otchestvo}'," +
                $" [date_rozhdeniia] ='{date_rozhdeniia}'," +
                $" [telefon] ='{telefon}'," +
                $" [pol] ='{pol}'," +
                $" [klass] ='{klass}'," +
                $" [login] ='{login}'," +
                $" WHERE id = '{id}';";
            }

            ClassDB.Query(sqlUpdateOrInsertUchenik);
        }

        public static void updateOrInsertZapisi(string diagnoz, string simptomi, DateTime date_start, DateTime date_end, string patient_id = "", string id = "")
        {
            string sqlUpdateOrInsertUchenik;
            if (id == "")
            {
                sqlUpdateOrInsertUchenik = $@"INSERT INTO [dbo].[{ClassDB.TABLE_ZAPISI}]
                (
                    [diagnoz],
                    [simptomi],
                    [date_start],
                    [date_end],
                    [patient_id]
                ) VALUES (
                    '{diagnoz}',
                    '{simptomi}',
                    '{date_start}',
                    '{date_end}',
                    '{patient_id}'
                );";
            }
            else
            {
                sqlUpdateOrInsertUchenik = $"UPDATE [dbo].[{ClassDB.TABLE_ZAPISI}] SET " +
                $" [diagnoz] ='{diagnoz}',  [simptomi] ='{simptomi}', [date_start] ='{date_start}', [date_end] ='{date_end}' " +
                $" WHERE id = '{id}';";
            }

            ClassDB.Query(sqlUpdateOrInsertUchenik);
        }

        public static DataTable selectForZapisiGrid(string where = "")
        {
            string sql = $"SELECT " +
                $"u.id AS 'u.id', u.familia, u.ima, u.otchestvo, u.pol, u.telefon, u.klass, u.date_rozhdeniia, u.login, " +
                $"zp.id AS 'zp.id', zp.diagnoz, zp.simptomi, zp.date_start, zp.date_end " +
                $"FROM [dbo].[{ClassDB.TABLE_ZAPISI}] AS zp " +
                $"LEFT JOIN [dbo].[{ClassDB.TABLE_UCHENIKI}] AS u  ON (zp.patient_id = u.id)";

            if (where != "")
            {
                sql += $" {where}";
            }
            sql += " ORDER BY zp.id DESC;";
            return ClassDB.Query(sql);
        }

        public static DataTable selectForUchenikiGrid(string where = "")
        {
            string sql = $"SELECT " +
                $"u.id AS 'u.id', u.familia, u.ima, u.otchestvo, u.pol, u.telefon, u.klass, u.date_rozhdeniia, u.login " +
                $"FROM [dbo].[{ ClassDB.TABLE_UCHENIKI}] AS u ";

            if (where != "")
            {
                sql += $" {where}";
            }

            sql += " ORDER BY u.id DESC;";

            return ClassDB.Query(sql);
        }

        public static DataTable selectPoisk(string poiskText)
        {
            string sql = $"WHERE " +
                $"[familia] LIKE '%{poiskText}%' "+
                $"OR [familia] LIKE '%{poiskText}%' " +
                $"OR [ima] LIKE '%{poiskText}%' " +
                $"OR [otchestvo] LIKE '%{poiskText}%' " +
                $"OR [pol] LIKE '%{poiskText}%' " +
                $"OR [telefon] LIKE '%{poiskText}%' " +
                $"OR [klass] LIKE '%{poiskText}%' " +
                $"OR [login] LIKE '%{poiskText}%' " +
                $"OR [diagnoz] LIKE '%{poiskText}%' " +
                $"OR [simptomi] LIKE '%{poiskText}%' " +
                $"OR [date_rozhdeniia] LIKE '%{poiskText}%' " +
                $"OR [date_start] LIKE '%{poiskText}%' " +
                $"OR [date_end] LIKE '%{poiskText}%'";

            return ClassDB.selectForZapisiGrid(sql);
        }

        public static Excel.Application buldExcelApp(string whereDateEnd = "")
        {
            var fields = new[]
             {
                new {field = "familia", name = "Фамилия", width = 12},
                new {field = "ima", name = "Имя", width = 10},
                new {field = "otchestvo", name = "Отчество", width = 15},
                new {field = "telefon", name = "Номер телефона", width = 17},
                new {field = "date_rozhdeniia", name = "Дата рождения", width = 16},
                new {field = "pol", name = "Пол", width = 5},
                new {field = "klass", name = "Класс", width = 6},
                new {field = "diagnoz", name = "Диагноз", width = 10},
                new {field = "simptomi", name = "Симптомы", width = 15},
                new {field = "date_start", name = "Дата начала", width = 11},
                new {field = "date_end", name = "Дата окончания", width = 15},
            };


            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Name = "Отчёт";
            worksheet.Cells[2, 2] = "Список школьников которые были в медпункте.";
            Excel.Range rng1 = worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[2, 2]];
            rng1.Cells.Font.Name = "Times New Roman";
            rng1.Cells.Font.Size = 18;
            rng1.Font.Bold = true;
            rng1.Cells.Font.Color = ColorTranslator.ToOle(Color.Green);

            int n = 0;
            foreach (var r in fields)
            {
                n++;
                worksheet.Cells[4, n] = r.name;
                worksheet.Columns[n].ColumnWidth = r.width;
            }

            Excel.Range rng2 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[4, fields.Count()]];
            rng2.Font.Bold = true;

            DataTable table = ClassDB.selectForZapisiGrid(whereDateEnd);
  

            int rowCount = 5;
            foreach (DataRow row in table.Rows)
            {
                n = 0;
                foreach (var r in fields)
                {
                    n++;
                    worksheet.Cells[rowCount, n] = row[r.field];
                }

                rowCount++;
                Excel.Range rng3 = worksheet.Range[worksheet.Cells[4, 1], worksheet.Cells[rowCount - 1, fields.Count()]];
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
                rng3.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            }

            rowCount += 2;
            worksheet.Cells[rowCount, 1] = "Ф.И.О.";
            Excel.Range rng4 = worksheet.Range[worksheet.Cells[rowCount, 1], worksheet.Cells[rowCount, 3]];
            rng4.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot;

            worksheet.Cells[rowCount, 5] = "Дата";
            Excel.Range rng5 = worksheet.Range[worksheet.Cells[rowCount, 5], worksheet.Cells[rowCount, 7]];
            rng5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot;

            worksheet.Cells[rowCount, 10] = "Подпись";
            Excel.Range rng6 = worksheet.Range[worksheet.Cells[rowCount, 10], worksheet.Cells[rowCount, 11]];
            rng6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlDot;

            return excelApp;
        }
    }
}
