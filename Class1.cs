using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace YP
{
    class Class1
    {
        public static string connstr = @"Data Source=62.78.81.19;Initial Catalog=Medpunkt;User ID=stud;Password=123456789";
        public static DataTable Query(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connstr);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обращения к БД!\nПроверьте вводимые данные \n {ex.Message}", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            return dt;
        }

        public static Excel.Application buldExcelApp(string SqlText)
        {
            var fields = new[]
             {
                new {field = "familia", name = "Фамилия", width = 12},
                new {field = "ima", name = "Имя", width = 10},
                new {field = "otchestvo", name = "Отчество", width = 15},
                new {field = "telefon", name = "Номер телефона", width = 17},
                new {field = "data_rozhdeniia", name = "Дата рождения", width = 16},
                new {field = "pol", name = "Пол", width = 5},
                new {field = "klass", name = "Класс", width = 6},
                new {field = "diagnoz", name = "Диагноз", width = 10},
                new {field = "simptomi", name = "Симптомы", width = 15},
                new {field = "start_data", name = "Дата начала", width = 11},
                new {field = "end_data", name = "Дата окончания", width = 15},
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

            SqlDataAdapter adapter = new SqlDataAdapter(SqlText, Class1.connstr);
            DataTable table = new DataTable();
            adapter.Fill(table);


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
