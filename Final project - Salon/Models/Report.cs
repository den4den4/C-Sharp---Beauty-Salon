using System;
using System.Linq;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using System.Data;

namespace Final_project___Salon
{
    /// <summary>
    /// Class For Creating Report PDF FIle
    /// 
    /// </summary>
    class Report
    {
        Document doc;//pdf document
        private readonly string shekel = " nis";

        /*
         * Constructors of pdf
         * Arguments:
         * -path - path to file saving place
         * -name - name of pdf file
         */
        public Report(): this(ReportForm.absolutePathToProjDir)
        {
            
        }

        public Report(string path): this(path, "newPdf")
        {
           
        }
        public Report(string path,string name)
        {
            Rectangle rec = new Rectangle(PageSize.A4);
            rec.BackgroundColor = new BaseColor(System.Drawing.Color.LightCoral);
            doc = new Document();
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(Path.Combine(path, name + ".pdf"), FileMode.Create));
                doc.Open();
            }
            catch (Exception)
            {
                doc.Close();
            }
            
            
        }


        /*
         * standart for all PDF reports files
         * with all information about company and logo         
         * Arguments:
         * -string imgPath -path to logo
         * -DateTime dateTime - date and tome of Pdf creating
         * -CompanyInfo compInfo - All company information
         */
        public void pdfSample(string imgPath, DateTime dateTime, CompanyInfo compInfo)
        {
            SetImage(imgPath);
            AddParagraph(dateTime.ToString(),2);
            AddParagraph("Company Name: ".ToUpper() + compInfo.CompName.ToString(),2);
            AddParagraph("Email: ".ToUpper() + compInfo.CompEmail.ToString(),2);
            AddParagraph("Address: ".ToUpper() + compInfo.CompAddress.ToString(),2);
            AddParagraph("Phone: ".ToUpper() + compInfo.CompPhone.ToString(),2);
            AddParagraph("License Id: ".ToUpper() + compInfo.CompLicense.ToString(),2);
            CreateLineOnPDF();


        }

        /*
         *Add Line to PDF
         */
        public void CreateLineOnPDF()
        {
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            doc.Add(p);
        }

        /*
         * setset Title for pdf  file
         * Arguments:
         * -string title - our text
         */
        public void SetTitle(string title)
        {
            
                Font font = new Font(Font.FontFamily.TIMES_ROMAN, 18, Font.BOLD, BaseColor.BLACK);
                Paragraph p = new Paragraph(title, font)
                {
                    Alignment = Element.ALIGN_CENTER                    
                };

                doc.Add(p);
            
        }

        /*
        * setset logo image on pdf  file
        * Arguments:
        * -string imagePath - path to image logo
        */
        public void SetImage(string imagePath)
        {
            
                Image img = Image.GetInstance(imagePath);

                img.Alignment = Element.ALIGN_LEFT;
                img.ScalePercent(10f);
                img.SetAbsolutePosition(10, doc.PageSize.Height-60f);
                doc.Add(img);
            
        }

        #region/STATISTIC_REPORT

        //-----------------SERVICES STATISTIC---------------------//
        public void GetServiceStatHeader()
        {

            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 14, Font.NORMAL);
            font.Color = BaseColor.BLUE;
            float[] width = new float[] { 3f, 1f, 1f,1f };
            PdfPTable table = new PdfPTable(width.Length) { WidthPercentage = 100 };
            table.SetWidths(width);

            table.AddCell(new PdfPCell(new Phrase($"Service Name", font)));
            table.AddCell(new PdfPCell(new Phrase($"Quantity", font)));
            table.AddCell(new PdfPCell(new Phrase($"Amount", font)));
            table.AddCell(new PdfPCell(new Phrase($"Procent", font)));

            doc.Add(table);
        }


        public void GetServicesStatistic(DataTable dt)
        {
            double total = 0;
            int quantity = 0;
            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.NORMAL);
            font.Color = BaseColor.BLACK;
            float[] width = new float[] { 3f, 1f, 1f,1f };
            PdfPTable table = new PdfPTable(width.Length) { WidthPercentage = 100 };
            table.SetWidths(width);

            //get sums of all services
            var result = dt.AsEnumerable().Select(row => row.Field<Decimal>("sum"));
            foreach (var res in result)
            {
                total += Convert.ToInt64(res);//sum of all services
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][0].ToString()}", font)));// name of service
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][1].ToString()}", font)));// quantity of each service
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][2].ToString()}"+shekel, font)));// summ of each service
                table.AddCell(new PdfPCell(new Phrase($"{GetProcentFromSum(Convert.ToInt64(dt.Rows[i][2]),total)}", font)));// procent of service sum from total sum
                quantity += Convert.ToInt32(dt.Rows[i][1]);// total quantity
            }
            doc.Add(table);
            table.DeleteBodyRows();

            font.Color = BaseColor.BLUE;
            table.AddCell(new PdfPCell(new Phrase("Total SUM", font)));
            table.AddCell(new PdfPCell(new Phrase(quantity.ToString(), font)));
            table.AddCell(new PdfPCell(new Phrase(total.ToString()+ shekel, font)));
            table.AddCell(new PdfPCell(new Phrase("100 %", font)));
            doc.Add(table);
        }
        //----------------------------------------------------------------------
        //-----------------Clients Statistic---------------------//
        public void GetClientsStatHeader(DataTable dt)
        {

            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 14, Font.NORMAL);
            font.Color = BaseColor.BLUE;
            float[] width = new float[] { 2f, 1f, 1f, 1f, 1f };
            PdfPTable table = new PdfPTable(width.Length) { WidthPercentage = 100 };
            table.SetWidths(width);

            table.AddCell(new PdfPCell(new Phrase($"Full Name", font)));
            table.AddCell(new PdfPCell(new Phrase($"Telephone", font)));
            table.AddCell(new PdfPCell(new Phrase($"Services Amount", font)));
            table.AddCell(new PdfPCell(new Phrase($"Services Total Sum", font)));
            table.AddCell(new PdfPCell(new Phrase($"Procent", font)));
            doc.Add(table);
            SetClientsStatistic(dt);
        }


        public void SetClientsStatistic(DataTable dt)
        {
            double total = 0;
            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.NORMAL);
            font.Color = BaseColor.BLACK;
            float[] width = new float[] { 2f, 1f, 1f, 1f,1f };
            PdfPTable table = new PdfPTable(width.Length) { WidthPercentage = 100 };
            table.SetWidths(width);

            //get sums of all services
            var result = dt.AsEnumerable().Select(row => row.Field<Decimal>("All Service Sum"));
            foreach (var res in result)
            {
                total += Convert.ToInt64(res);//sum of all services
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][0].ToString()}", font)));// name of customer
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][1].ToString()}", font)));// customer phone
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][2].ToString()}", font)));// quantity of services by customer
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][3].ToString()}"+ shekel, font)));// cost of all customer`s services
                table.AddCell(new PdfPCell(new Phrase($"{GetProcentFromSum(Convert.ToInt64(dt.Rows[i][3]), total)}", font)));// procent of srvice sum from total sum
            }
            doc.Add(table);
        }
        //----------------------------------------------------------------------
        //-----------------Employees Statistic---------------------//
        public void GetEmployeeStatHeader()
        {

            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 14, Font.NORMAL);
            font.Color = BaseColor.BLUE;
            float[] width = new float[] { 2f, 1f, 1f, 1f, 1f, 1f };
            PdfPTable table = new PdfPTable(width.Length) { WidthPercentage = 100 };
            table.SetWidths(width);

            table.AddCell(new PdfPCell(new Phrase($"Employee Name", font)));
            table.AddCell(new PdfPCell(new Phrase($"Number Of Clients", font)));
            table.AddCell(new PdfPCell(new Phrase($"Number Of Services", font)));
            table.AddCell(new PdfPCell(new Phrase($"Total Sevices Sum", font)));
            table.AddCell(new PdfPCell(new Phrase($"Procent From All Summ", font)));
            table.AddCell(new PdfPCell(new Phrase($"Salary", font)));
            doc.Add(table);
        }
        public void GetEmployeeStatistic(DataTable dt)
        {
            GetEmployeeStatHeader();
            double total = 0;
            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.NORMAL);
            font.Color = BaseColor.BLACK;
            float[] width = new float[] { 2f, 1f, 1f, 1f, 1f, 1f };
            PdfPTable table = new PdfPTable(width.Length) { WidthPercentage = 100 };
            table.SetWidths(width);

            //get sums of all services
            var result = dt.AsEnumerable().Select(row => row.Field<Decimal>("Sum of Services"));
            foreach (var res in result)
            {
                total += Convert.ToInt64(res);//sum of all services
            }

            for (int i=0; i<dt.Rows.Count;i++)
            {
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][0].ToString()}", font)));//Employee name
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][1].ToString()}", font)));//Number of clients
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][2].ToString()}", font)));//Number of services
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][3].ToString()}" + shekel, font)));//summ of services
                table.AddCell(new PdfPCell(new Phrase($"{GetProcentFromSum(Convert.ToInt64(dt.Rows[i][3]),total)}", font)));//Procent from all service sum
                table.AddCell(new PdfPCell(new Phrase($"{dt.Rows[i][4].ToString()}" + shekel, font)));//salary
            }
            

            doc.Add(table);
        }

        private string GetProcentFromSum(double number, double sum)
        {
            return Format.FormatDuobleTwoDecPlaces((number * 100) / sum)+"%";            
        }


        #endregion


        /*
         * set services infortmation on standart pdf 
         * Arguments:
         * -string str - 2D array, with services and prices
         */
        public void SetCheckServices(Service[] services,string sum)
        {
            
            int numbOfCells = 3;

            PdfPTable table = new PdfPTable(numbOfCells);
            table.TotalWidth = 250f;
            float[] widths = new float[] { 1f, 2f, 1f };
            table.SetWidths(widths);
            table.HorizontalAlignment = Element.ALIGN_CENTER;


            PdfPCell cell = SpecialCell("ID", 1, 1, 0.8f);
            table.AddCell(cell);
            cell = SpecialCell("Services",1, 1,0.8f);
            table.AddCell(cell);
            cell = SpecialCell("Price", 1, 1, 0.8f);
            table.AddCell(cell);

            for (int i = 0; i < services.Length; i++)
            {                
                table.AddCell(services[i].Id.ToString());
                table.AddCell(services[i].Name.ToString());
                table.AddCell(services[i].Price.ToString()+ shekel);
            }

            cell = SpecialCell("Total Sum : " + sum + shekel, numbOfCells, 1,0.8f);
            table.AddCell(cell);

            doc.Add(table);
            
        }


        /*
         * Check Data without services
         * Arguments:
         * -string[] str - Array with check data(employee name, customer name, and date of procedur)
         */
        public void SetCheckData(string[] str)
        {            
            PdfPTable table = new PdfPTable(2);
            table.TotalWidth = 250f;
            float[] widths = new float[] { 1f, 1f };
            table.SetWidths(widths);
            table.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell cell = SpecialCell("Customer Name :".ToUpper(), 1, 0);// customer name
            table.AddCell(cell);
            cell = SpecialCell(str[1], 1, 0);
            table.AddCell(cell);
            cell = SpecialCell("Date And Time :".ToUpper(), 1, 0);// date and time
            table.AddCell(cell);
            cell = SpecialCell(str[0], 1, 0);
            table.AddCell(cell);

            doc.Add(table);
        }

        /// <summary>
        /// Method Create Cells table, from data table and add them to pdf file
        /// </summary>
        /// <param name="dt">data table - exists information from data base</param>
        public void ListsInformation(DataTable dt)
        {
            int i = 0;
            string[] headers = new string[dt.Columns.Count];
            foreach (DataColumn column in dt.Columns)
            {
                
                headers[i] = column.ColumnName.Replace("_"," \n").ToUpper();
                i++;
            }
            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 8, Font.NORMAL);
            font.Color = BaseColor.BLUE;
            PdfPTable table = new PdfPTable(headers.Length) { WidthPercentage = 100 };
            table.SetWidths(GetHeaderWidths(font, headers));

            table.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cell;

            foreach (string header in headers)
            {                
                table.AddCell(new PdfPCell(new Phrase($"{header}", font)));
            }
            
            foreach (DataRow row in dt.Rows)
            {
                
                var rowCells = row.ItemArray;
                foreach (object rowCell in rowCells)
                {
                    
                    cell = new PdfPCell(new Phrase($"{rowCell.ToString().Replace(" 0:00:00", "")}",(new Font(Font.FontFamily.TIMES_ROMAN, 8, Font.NORMAL))));
                    cell.GrayFill = i % 2 == 0 ? 1 : 0.8f;
                    table.AddCell(cell);
                }
                i++;
            }


            doc.Add(table);
        }
        /// <summary>
        /// Method returns float array, with cells width
        /// </summary>
        /// <param name="font"> Font of text, for width calculate by font size</param>
        /// <param name="headers">Array of table Headers cells, for wdth calculate</param>
        /// <returns>result - float array, withds of cells</returns>
        public float[] GetHeaderWidths(Font font, params string[] headers)
        {
            int total = 0;
            int columns = headers.Length;
            int[] widths = new int[columns];
            for (int i = 0; i < columns; ++i)
            {
                int w = font.GetCalculatedBaseFont(true).GetWidth(GetFirstWord(headers[i]));
                total += w;
                widths[i] = w;
            }
            float[] result = new float[columns];
            for (int i = 0; i < columns; ++i)
            {
                result[i] = (float)widths[i] / total * 100;
            }
            return result;
        }
        /// <summary>
        /// Method returns first word from passed string
        /// </summary>
        /// <param name="text">string for getting first word from</param>
        /// <returns>string first word from passed string</returns>
        public static string GetFirstWord(string text)
        {
            string firstWord = String.Empty;

            // Check for empty string.
            if (String.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            // Get first word from passed string
            firstWord = text.Split(' ').FirstOrDefault();
            if (String.IsNullOrEmpty(firstWord))
            {
                return string.Empty;
            }

            return firstWord;
        }

        /// <summary>
        /// Method add Paragraf to pdf, with default properties
        /// </summary>
        /// <param name="str">text that we will add</param>
        /// <param name="aligment">text aligment</param>
        public void AddParagraph(string str,int aligment=0)
        {
            Font myFont = new Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, Font.NORMAL);
            myFont.Color = BaseColor.BLACK;
            Paragraph para = new Paragraph(str+"\n",myFont);
            para.Alignment = aligment;
            doc.Add(para);
        }


        /*
         * Special CELL
         * Arguments:
         * -string str - cell text
         * -int colspan - combining columns
         * -int border - (0 - without border) 1 - with border
         * -float grayfil - (1 - without filling) 1 > level of filling
         * Return:
         * -PdfPCell cell - for adding to table
         */
        public PdfPCell SpecialCell(string str, int colspan = 1, int border=1,float grayfill= 1)
        {
            PdfPCell cell = new PdfPCell(new Phrase((str),new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL)));
            cell.Colspan = colspan;
            cell.GrayFill = grayfill;
            cell.Border = border;
            cell.HorizontalAlignment = 0;
            return cell;
        }


        /*
         * Function Do Line Down("\n")
         * Arguments:
         * -int number - number of pads
         */
        public void PaddingDown(int number)
        {
            Chunk padding = new Chunk("\n");
            while(number!=0)
            {
                doc.Add(padding);
                number--;
            }
        }
        /*
         * Close PDF file
         */
        public void CloseReport()
        {
            CreateLineOnPDF();
            doc.Close();
        }
    }
}
