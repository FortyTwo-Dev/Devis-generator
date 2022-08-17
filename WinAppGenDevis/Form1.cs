using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace WinAppGenDevis{

    public partial class genDevis : Form{

        public genDevis()
        {

           InitializeComponent();
            
        }
        
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
            AddCellToTab("Nom du Produit", fontHeader, grey, table);
            AddCellToTab("Quantité", fontHeader, grey, table);
            AddCellToTab("Prix (en €)", fontHeader, grey, table);

            for (int i = 0; i < listViewInfoProduct.Items.Count; i++)
            {
                AddCellToTab(listViewInfoProduct.Items[i].SubItems[0].Text, fontHeader, white, table);
                AddCellToTab(listViewInfoProduct.Items[i].SubItems[1].Text, fontHeader, white, table);
                AddCellToTab(listViewInfoProduct.Items[i].SubItems[2].Text, fontHeader, white, table);
            }

            document.Add(table);
            document.Add(new Phrase("\n"));

            Paragraph p4 = new Paragraph("Total = " + CalcTotal() +  "\n\n", fontTitle);
            p4.Alignment = Element.ALIGN_RIGHT;
            document.Add(p4);

            document.Close();
            Process.Start(@"cmd.exe ", @"/c" + outFile);
        }

        public double CalcTotal()
        {
            double amount = 0, price = 0, totalNet = 0;
            for (int i = 0; i < listViewInfoProduct.Items.Count; i++)
            {
                amount += double.Parse(listViewInfoProduct.Items[i].SubItems[1].Text);
                price += double.Parse(listViewInfoProduct.Items[i].SubItems[2].Text);

                totalNet = totalNet + (amount * price);
                amount = 0;
                price = 0;
            }
            return totalNet;
        }
         
        public static void AddCellToTab(string str, Font font, BaseColor color, PdfPTable table)
        {
            PdfPCell cell1 = new PdfPCell(new Phrase(str, font));
            cell1.BackgroundColor = color;
            cell1.Padding = 7;
            cell1.BorderColor = BaseColor.BLACK;
            table.AddCell(cell1);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double q = double.Parse(textBoxPrice.Text);
            int p = int.Parse(textBoxAmount.Text);

            double total = q * p;

            ListViewItem item = new ListViewItem();

            item.Text = textBoxNameOfProduct.Text;
            item.SubItems.Add(textBoxAmount.Text);
            item.SubItems.Add(textBoxPrice.Text);
            item.SubItems.Add(total.ToString());

            listViewInfoProduct.Items.Add(item);
        }

        private void buttonDeleteBox_Click(object sender, EventArgs e)
        {
            textBoxNameOfProduct.Text = "";
            textBoxAmount.Text = "0";
            textBoxPrice.Text = "0";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewInfoProduct.SelectedItems.Count == 1)
            {
                int selectedIndice = listViewInfoProduct.SelectedIndices[0];
                listViewInfoProduct.Items[selectedIndice].Remove();
            } 
            else if (listViewInfoProduct.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectionnez une ligne");
            }
            else
            {
                MessageBox.Show("Selectionnez une seul ligne");
            }
            
        }
        int indiceToEdit = -1;

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (indiceToEdit == -1)
            {
                if (listViewInfoProduct.SelectedItems.Count == 1)
                {
                    int selectedIndice = listViewInfoProduct.SelectedIndices[0];
                    indiceToEdit = listViewInfoProduct.SelectedIndices[0];
                    textBoxNameOfProduct.Text = listViewInfoProduct.Items[selectedIndice].SubItems[0].Text;
                    textBoxAmount.Text = listViewInfoProduct.Items[selectedIndice].SubItems[1].Text;
                    textBoxPrice.Text = listViewInfoProduct.Items[selectedIndice].SubItems[2].Text;

                    buttonAdd.Enabled = false;
                    buttonDelete.Enabled = false;
                    buttonDeleteBox.Enabled = false;
                    buttonEdit.Text = "Valider";
                }
                else if (listViewInfoProduct.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selectionnez une ligne");
                }
                else
                {
                    MessageBox.Show("Selectionnez une seul ligne");
                }
            } 
            else
            {
                double q = double.Parse(textBoxPrice.Text);
                int p = int.Parse(textBoxAmount.Text);

                double total = q * p;

                listViewInfoProduct.Items[indiceToEdit].SubItems[0].Text = textBoxNameOfProduct.Text;
                listViewInfoProduct.Items[indiceToEdit].SubItems[1].Text = textBoxAmount.Text;
                listViewInfoProduct.Items[indiceToEdit].SubItems[2].Text = textBoxPrice.Text;
                listViewInfoProduct.Items[indiceToEdit].SubItems[3].Text = total.ToString();

                buttonAdd.Enabled = true;
                buttonDelete.Enabled = true;
                buttonDeleteBox.Enabled = true;
                buttonEdit.Text = "Editer";

                indiceToEdit = -1;
            }
            
        }
    }
}