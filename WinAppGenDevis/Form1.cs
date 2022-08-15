using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace WinAppGenDevis{

    public partial class genDevis : Form{

        public genDevis(){

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e){}

        private void buttonGenDevis_Click(object sender, EventArgs e){

            GeneratePDF();

        }

        public void GeneratePDF(){

            string outFile = Environment.CurrentDirectory + "/devis.pdf";

            Document document = new Document();

            PdfWriter.GetInstance(document, new FileStream(outFile, FileMode.Create));

            document.Open();

            //Color
            BaseColor blue = new BaseColor(0, 75, 155);
            BaseColor grey = new BaseColor(240, 240, 240);
            BaseColor white = new BaseColor(255, 255, 255);
            BaseColor black = new BaseColor(0, 0, 0);

            //Police
            Font fontTitle = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20F, iTextSharp.text.Font.BOLD, black);
            Font fontHeader = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16F, 1, black);

            Paragraph p1 = new Paragraph("Entreprise : " + textBoxCoordinates.Text + "\n\n", fontTitle);
            p1.Alignment = Element.ALIGN_LEFT;
            document.Add(p1);

            Paragraph p2 = new Paragraph("Client : " + textBoxCoordinateClient.Text + "\n\n", fontTitle);
            p2.Alignment = Element.ALIGN_RIGHT;
            document.Add(p2);

            Paragraph p3 = new Paragraph("Devis : " + textBoxTitle.Text + "\n\n", fontTitle);
            p3.Alignment = Element.ALIGN_LEFT;
            document.Add(p3);

            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;
            addCellToTab("Nom du Produit", fontHeader, white, table);
            addCellToTab("quantité", fontHeader, white, table);
            addCellToTab("prix", fontHeader, white, table);


            string[] infosProduct = new string[3];
            infosProduct[0] = textBoxNameOfProduct.Text;
            infosProduct[1] = textBoxAmount.Text;
            infosProduct[2] = textBoxPrice.Text;

            foreach(string info in infosProduct) {

                PdfPCell cell = new PdfPCell(new Phrase(info));
                cell.BackgroundColor = grey;
                cell.Padding = 7;
                cell.BorderColor = black;
                table.AddCell(cell);

            }

            document.Add(table);
            document.Add(new Phrase("\n"));

            Paragraph p4 = new Paragraph("Total = " + int.Parse(textBoxPrice.Text) * int.Parse(textBoxAmount.Text) + "\n\n", fontTitle);
            p4.Alignment = Element.ALIGN_RIGHT;
            document.Add(p4);

            document.Close();
            Process.Start(@"cmd.exe ", @"/c" + outFile);
        }
         
        public void addCellToTab(string str, Font font, BaseColor color, PdfPTable table) {

            PdfPCell cell1 = new PdfPCell(new Phrase(str, font));
            cell1.BackgroundColor = color;
            cell1.Padding = 7;
            cell1.BorderColor = BaseColor.BLACK;
            table.AddCell(cell1);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            TextBox textBoxAmount1 = new TextBox();
            TextBox textBoxPrice1 = new TextBox();


            textBoxAmount1.AcceptsTab = true;
            textBoxAmount1.Multiline = false;
            textBoxPrice1.AcceptsTab = true;
            textBoxPrice1.Multiline = false;

            textBoxAmount1.ClientSize = new Size(195, 23);
            textBoxAmount1.Location = new Point(302, 587);
            Controls.Add(textBoxAmount1);
            textBoxPrice1.ClientSize = new Size(190, 23);
            textBoxPrice1.Location = new Point(506, 587);
            Controls.Add(textBoxPrice1);
            ResumeLayout(false);
            textBoxAdd();
        }

        public void textBoxAdd()
        {
            int i = buttonAdd.Location.Y;
            buttonAdd.Location = new Point(705, i+30);

            TextBox textBoxProduct0 = new TextBox();
            textBoxProduct0.AcceptsTab = true;
            textBoxProduct0.Multiline = false;
            
            textBoxProduct0.ClientSize = new Size(280, 23);
            textBoxProduct0.Location = new Point(12, i+30);
            Controls.Add(textBoxProduct0);
            
        }
    }
}