using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Diary
{
    static class Excel
    {

        public static void New(string docName)
        {
            using(XLWorkbook workbook = new XLWorkbook())
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

        public static void Save(string docName, Log log)
        {
            using (XLWorkbook workbook = XLWorkbook.OpenFromTemplate(docName))
            {
                var worksheet = workbook.Worksheet("Diary");
                Console.WriteLine(worksheet.Cell("A1").Value);
            }
        }
    }
}
