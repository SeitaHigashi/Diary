using ClosedXML.Excel;
using System;

namespace Diary
{
    static class Excel
    {

        public static void New(string docName)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Diary");
                worksheet.Cell("A1").Value = "日付";
                worksheet.Cell("B1").Value = "研究時間";
                worksheet.Cell("C1").Value = "実績";
                worksheet.Cell("D1").Value = "課題";
                worksheet.Cell("E1").Value = "予定";
                workbook.SaveAs(docName);
            }
        }

        public static string LoadPlans(string docName)
        {
            try
            {
                using (XLWorkbook workbook = new XLWorkbook(docName))
                {
                    var worksheet = workbook.Worksheet("Diary");
                    return worksheet.Column("E").LastCellUsed().Value.ToString();
                }
            }
            catch
            {
                return null;
            };

        }

        public static void Save(string docName, Log log)
        {
            using (XLWorkbook workbook = new XLWorkbook(docName))
            {
                var worksheet = workbook.Worksheet("Diary");
                Console.WriteLine(worksheet.Cell("A1").Value);
                var row = worksheet.Column("A").LastCellUsed().WorksheetRow().RowNumber() + 1;
                worksheet.Cell("A" + row).Value = log.date;
                worksheet.Cell("B" + row).Value = log.classTime;
                worksheet.Cell("C" + row).Value = log.performance;
                worksheet.Cell("D" + row).Value = log.task;
                worksheet.Cell("E" + row).Value = log.plan;
                workbook.Save();
            }
        }
    }
}
