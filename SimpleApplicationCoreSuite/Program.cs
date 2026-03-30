using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;

namespace SimpleApplicationCoreSuite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Document document = new Document();
            //Page page = new Page();
            //document.Pages.Add(page);
            //TextArea area = new TextArea("This is to test", 100, 100, 200, 200);
            //page.Elements.Add(area);
            //string outputPdf = @"C:\Temp\MyDocument.pdf";
            //document.Draw(outputPdf);
            //System.Diagnostics.Process.Start(outputPdf);

            CreateSimpleTable();

        }

        private static void CreateSimpleTable()
        {
            Table2 table = new Table2(100, 100, 400, 500);
            Column2 col1 = table.Columns.Add(100);
            Column2 col2 = table.Columns.Add(100);

            Row2 row1 = table.Rows.Add();
            Cell2 cellR1C1 = row1.Cells.Add("Row1 Column1");
            Cell2 cellR1C2 = row1.Cells.Add("Row1 Column2");

            Document document = new Document();
            Page page = new Page();
            document.Pages.Add(page);

            //Add table to page.
            page.Elements.Add(table);

            string outputPdf = @"SimpleTable.pdf";
            document.Draw(outputPdf);
            System.Diagnostics.Process.Start(outputPdf);


        }
    }
}
