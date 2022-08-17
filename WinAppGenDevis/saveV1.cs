using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace WinAppGenDevis{

    public partial class genDevis : Form{
        public int j = 0;

        public genDevis()
        {

            InitializeComponent();
            if (j == 0)
            {
                buttonDelete.Visible = false;
            }
            else
            {
                buttonDelete.Visible = true;
            }
            
            
        }
        //no use
        private void label1_Click(object sender, EventArgs e){}

        private void buttonGenDevis_Click(object sender, EventArgs e)
        {

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
            addCellToTab("Quantité", fontHeader, white, table);
            addCellToTab("Prix (en €)", fontHeader, white, table);
            addCellToTab("jj", fontHeader, grey, table);
            addCellToTab("jj", fontHeader, grey, table);
            addCellToTab("jj", fontHeader, grey, table);
            string[] infosProduct = new string[3];
            infosProduct[0] = textBoxNameOfProduct.Text;
            infosProduct[1] = textBoxAmount.Text;
            infosProduct[2] = textBoxPrice.Text;

            foreach (string info in infosProduct)
            {

                PdfPCell cell = new PdfPCell(new Phrase(info));
                cell.BackgroundColor = grey;
                cell.Padding = 7;
                cell.BorderColor = black;
                table.AddCell(cell);

            }

            void addCellInTOArray()
            {
                
            }

            addCellInTOArray();
            document.Add(table);
            document.Add(new Phrase("\n"));

            Paragraph p4 = new Paragraph("Total = " + double.Parse(textBoxPrice.Text) * double.Parse(textBoxAmount.Text) +  "\n\n", fontTitle);
            p4.Alignment = Element.ALIGN_RIGHT;
            document.Add(p4);

            document.Close();
            Process.Start(@"cmd.exe ", @"/c" + outFile);
        }
         
        public void addCellToTab(string str, Font font, BaseColor color, PdfPTable table)
        {

            PdfPCell cell1 = new PdfPCell(new Phrase(str, font));
            cell1.BackgroundColor = color;
            cell1.Padding = 7;
            cell1.BorderColor = BaseColor.BLACK;
            table.AddCell(cell1);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxAdd();
        }
        public Dictionary<string, TextBox> GeneratedTextBoxes = new();

        public void textBoxAdd()
        {
            
            j++;
            int i = buttonAdd.Location.Y;
            buttonAdd.Location = new Point(705, i + 30);

            if (j == 0)
            {
                buttonDelete.Visible = false;
            }
            else
            {
                buttonDelete.Visible = true;
            }


            void GenerateTextBox(string TextBoxName, string text, Point location, Point size)
            {
                TextBox generated = new();
                generated.Name = TextBoxName;
                generated.Location = location;
                generated.Size = (Size)size;
                generated.Text = text;
                Controls.Add(generated);
                GeneratedTextBoxes[TextBoxName] = generated;
            }
            void textBoxAddProduct()
            {
                
                Convert.ToString(j);
                GenerateTextBox("textBoxProduct" + j, "",new Point(12, i + 30), new Point(284, 23));
                Debug.WriteLine(GeneratedTextBoxes["textBoxProduct" + j].Name);
            }
            void textBoxAddAmount()
            {
                
                Convert.ToString(j);
                GenerateTextBox("textBoxAmount" + j, "", new Point(506, i + 30), new Point(193, 23));
                Debug.WriteLine(GeneratedTextBoxes["textBoxAmount" + j].Name);
            }
            void textBoxAddPrice()
            {
                
                Convert.ToString(j);
                GenerateTextBox("textBoxPrice" + j, "", new Point(302, i + 30), new Point(198, 23));
                Debug.WriteLine(GeneratedTextBoxes["textBoxPrice" + j].Name);
            }

            textBoxAddProduct();
            textBoxAddAmount();
            textBoxAddPrice();

            buttonDelete.Location = new Point(740, i+30);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = buttonAdd.Location.Y;
            buttonAdd.Location = new Point(705, i - 30);
            buttonDelete.Location = new Point(740, i - 30);
            Debug.WriteLine(GeneratedTextBoxes["textBoxProduct" + j].Name);
            Debug.WriteLine(GeneratedTextBoxes["textBoxAmount" + j].Name);
            Debug.WriteLine(GeneratedTextBoxes["textBoxPrice" + j].Name);
            GeneratedTextBoxes["textBoxProduct" + j].Dispose();
            GeneratedTextBoxes["textBoxAmount" + j].Dispose();
            GeneratedTextBoxes["textBoxPrice" + j].Dispose();

            j--;
            if (j == 0)
            {
                buttonDelete.Visible = false;
            }
            else
            {
                buttonDelete.Visible = true;
            }
        }
    }
}
/*
 * dictionary
 * j
 * array
 * 
*/
