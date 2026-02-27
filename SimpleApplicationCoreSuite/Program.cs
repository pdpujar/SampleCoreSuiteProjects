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
            Document document = new Document();
            Page page = new Page();
            document.Pages.Add(page);
            TextArea area = new TextArea("This is to test", 100, 100, 200, 200);
            page.Elements.Add(area);
            string outputPdf = @"C:\Temp\MyDocument.pdf";
            document.Draw(outputPdf);
            System.Diagnostics.Process.Start(outputPdf);
        }
    }
}
