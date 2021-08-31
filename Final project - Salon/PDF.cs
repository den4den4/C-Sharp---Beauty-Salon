using System.Data;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Colors;
using iText.Layout.Element;
using System.Drawing;
using iText.Kernel.Pdf;
using iText.Layout;

namespace Final_project___Salon
{
    public  class PDF
    {
       // private PdfDocument pdf;


        public PDF() : this("C:\\Users\\Ivan\\Desktop\\salon\\salonNewPdfFile.pdf"){}
        public  PDF(string path)
        {
            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var exportFile = System.IO.Path.Combine(exportFolder, "Test.pdf");

            using(var writer = new PdfWriter(exportFile))
            {
                using(var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf);
                    doc.Add(new Paragraph("Hello World"));
                }
            }

            //pdf = new PdfDocument();
            //PdfWriter.GetInstance(pdf, new FileStream(path, FileMode.Create));
            //pdf.Open();
            //SolidLine line = new SolidLine(1f);
            //line.SetColor(ColorConstants.BLUE);
            //LineSeparator ls = new LineSeparator(line);
            //ls.SetWidth(50);
            //ls.SetMarginTop(5);
        }

        //public void SetTitle(string title)
        //{
        //    Font font = new Font(Font.FontFamily.TIMES_ROMAN, 25, Font.BOLD, BaseColor.BLACK);
        //    Paragraph p = new Paragraph(title, font)
        //    {
        //        Alignment = Element.ALIGN_CENTER
        //    };

        //    pdf.Add(p);
        //}

        //public void SetImage(string imagePath)
        //{
        //    Image img = Image.GetInstance(imagePath);
        //    img.ScalePercent(10f);
        //    img.Alignment = Element.ALIGN_CENTER;

        //    pdf.Add(img);
        //}
        //public void Close()
        //{
        //    pdf.Close();
        //}
        
    }
}
