using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Office.Interop.Excel;

namespace csharpindepth
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var p in Product.SampleProducts.Where(p => p.Price > 10).OrderBy(p => p.Name)) // extension method.
            {
                Console.WriteLine(p.ToString());
            }

            var app = new Application { Visible = false };
            Workbook workbook = app.Workbooks.Add();
            Worksheet worksheet = app.ActiveSheet;
            int row = 1;
            foreach (var product in Product.SampleProducts.Where(p => p.Price > 10))
            {
                worksheet.Cells[row, 1].Value = product.Name;
                worksheet.Cells[row, 2].Value = product.Price;
                row++;
            }
            workbook.SaveAs(Filename: "demo.xls", FileFormat: XlFileFormat.xlWorkbookNormal);
            app.Application.Quit();
        }
    }
}
