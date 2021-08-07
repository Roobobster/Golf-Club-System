using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace Reports
{
    class WordDocument
    {
        private static  Microsoft.Office.Interop.Word.Application wordApp;
        private static Document wordDocument;
        //Creates all the nesseccary things to start implementing features into the word document. 
        public void InitialiseDocument()
        {
            try
            {
                wordDocument = new Document();
                //Create an instance for word app
                wordApp = new Microsoft.Office.Interop.Word.Application()
                {
                    //Set animation status for word application
                    ShowAnimation = false,

                    //Set status for word application is to be visible or not.
                    Visible = false
                };

                //Create a new document
                wordDocument = wordApp.Documents.Add();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //After all the wanted features are implemented into the word document this will need to be called to finalise the word document and save it.
        public void FinaliseDocument(object fileLocation)
        {

            //Save the document

            // object filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)  + @"\GenerateReport.docx";
            if (fileLocation != null)
            {
                wordDocument.SaveAs2(ref fileLocation);

                wordDocument.Close();
                wordDocument = null;
                wordApp.Quit();
                wordApp = null;
                MessageBox.Show("Document created successfully !");
            }
       
           
        }


        //Adds a paragraph to a word document.
        public void AddParagraph( string ParagraphText)
        {
            //Add paragraph with Heading 1 style
            Paragraph para1 = wordDocument.Content.Paragraphs.Add();
            object styleHeading1 = "Heading 1";
            para1.Range.set_Style(ref styleHeading1);
            para1.Range.Text = ParagraphText;
            para1.Range.InsertParagraphAfter();
        }

        //Adds a Footer to a word document 
        public void AddFooterToDocument( string FooterText)
        {
            //Add the footers into the document
            foreach (Section wordSection in wordDocument.Sections)
            {
                //Get the footer range and add the footer details.
                Range footerRange = wordSection.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                footerRange.Font.ColorIndex = WdColorIndex.wdDarkRed;
                footerRange.Font.Size = 10;
                footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                footerRange.Text = FooterText;
            }
        }

        public void AddGapToDocument()
        {
            wordDocument.Content.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;

        }

        //Adds a Header to a word document.
        public void AddHeaderToDocument( string HeaderText)
        {

            //Add header into the document
            foreach (Section section in wordDocument.Sections)
            {
                //Get the header range and add the header details.
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                headerRange.Font.Size = 30;
                headerRange.Text = HeaderText;
            }

        }


        //Adds a table into a word document that is passed to it. 
        public void AddTableToDocument(  IDictionary<string,float> DataValues)
        {
            Paragraph para1 = wordDocument.Content.Paragraphs.Add();

            int Columns = 2;
            //Gets the number of rows in the data and adds one to account for the header. 
            int Rows = DataValues.Keys.Count;
            //Create a 5X5 table
            Table DocumentTable = wordDocument.Tables.Add(para1.Range, Rows , Columns);
            
            DocumentTable.Borders.Enable = 1;
            string[] Headers = new string[DataValues.Keys.Count +1];
            int i = 1;
            foreach(KeyValuePair<string,float> pair in DataValues)
            {
                Headers[i] = pair.Key;
                i++;
            }


            foreach (Row row in DocumentTable.Rows)
            {
                foreach (Cell cell in row.Cells)
                {
                    //Header row
                    if (cell.ColumnIndex == 1)
                    {
                        cell.Range.Text = Headers[cell.RowIndex];
                        cell.Range.Font.Bold = 1;
                        //other format properties goes here
                        cell.Range.Font.Name = "verdana";
                        cell.Range.Font.Size = 10;
                        //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
                        cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                        //Center alignment for the Header cells
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                    }
                    //Data row
                    else
                    {
                        cell.Range.Text = "£"+ DataValues[Headers[cell.RowIndex]].ToString();

                    }
                }

            }
        }

        public void AddPictureToDocument(string[] graphPaths)
        {
            
            foreach (string filePath in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug", "") + @"\ChartImages"))
            {
                foreach (string path in graphPaths)
                {
                    if (path == filePath)
                    {
                        InlineShape picture = wordDocument.InlineShapes.AddPicture(filePath);
                        picture.Width *= 0.8f;
                        picture.Height *= 0.8f;
                    }
                }
                

            }

            
        }
    }

}