using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetBarcode;

namespace PrintablesApp
{
    public partial class Form1 : Form
    {
        int current = 1;
        public Form1()
        {
            InitializeComponent();
            txtAddress.Text = Properties.Settings.Default.txtAddress;
            txtFrom.Text = Properties.Settings.Default.txtFrom;
            txtPhone.Text = Properties.Settings.Default.txtPhone;
            rtbStamp.Text = Properties.Settings.Default.txtStamp;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(txtAA.Text,@"^\d+$")) && (Regex.IsMatch(txtAD.Text,@"^\d+$"))) {
                txtAA.Enabled = txtAD.Enabled = false;
                btnPrint.Enabled = true;
            }
            else { txtAA.Clear(); txtAD.Clear(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAA.Enabled = txtAD.Enabled = true;
            txtAA.Clear();
            txtAD.Clear();
            btnPrint.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtFrom = txtFrom.Text;
            Properties.Settings.Default.Save();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtAddress = txtAddress.Text;
            Properties.Settings.Default.Save();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument1; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDocument1.DefaultPageSettings.Landscape = true;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 297, 210);
                printDocument1.DocumentName = "apostoles_dematwn";
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //printDocument1.DefaultPageSettings.Landscape = true;
//            PaperSize paperSize = new PaperSize("A4", 150, 500);
            //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 297, 210);
            float currentY = 25; // declare  one variable for height measurement
            e.Graphics.DrawString("Αποστολή από " + txtFrom.Text, new Font(FontFamily.GenericSerif, 28, FontStyle.Bold), Brushes.Black, 20, currentY);
            e.Graphics.DrawString("Ημερομηνία " + dateTimePicker1.Value.ToString("dd/MM/yyyy"), new Font(FontFamily.GenericSerif, 22, FontStyle.Bold), Brushes.Black, 750, currentY);
            currentY += 38;
            e.Graphics.DrawString(txtAddress.Text, new Font(FontFamily.GenericSerif, 16, FontStyle.Bold), Brushes.Black, 25, currentY);
            e.Graphics.DrawString("Αριθμός Αποστολής " +txtAA.Text, new Font(FontFamily.GenericSerif, 16, FontStyle.Bold), Brushes.Black, 760, currentY);
            currentY += 22;
            e.Graphics.DrawString("ΤΗΛ. " +txtPhone.Text, new Font(FontFamily.GenericSerif, 16, FontStyle.Bold), Brushes.Black, 25, currentY);
            Image barcode = new Barcode("550" + txtAA.Text, NetBarcode.Type.Code93, true).GetImage();
            e.Graphics.DrawImage(barcode, 780, currentY);
            currentY += 200;
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1),90, currentY-15, 600, 160);
            e.Graphics.DrawString(Properties.Settings.Default.txtStamp, new Font(FontFamily.GenericSerif, 16, FontStyle.Bold), Brushes.Black, 100, currentY);
            currentY += 160-15;
            e.Graphics.DrawString("( Σφραγίδα / Υπογραφή )", new Font(FontFamily.GenericSerif, 10, FontStyle.Italic), Brushes.Black, 325, currentY);
            currentY += 210+40+15;
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),450-15, currentY-10, 225, 50);
            e.Graphics.DrawString($"ΔΕΜΑΤΑ: { current } / { getTotalPages(txtAD.Text) } ", new Font(FontFamily.GenericSerif, 18, FontStyle.Bold), Brushes.Black, 450, currentY);
            if (current < getTotalPages(txtAD.Text))
            {
                e.HasMorePages = true;
                current += 1;
                return;
            }
            else
            {
                e.HasMorePages = false;
                current = 1;
            }
        }

        private int getTotalPages(string pages)
        {
            int total;
            try
            {
                total = Convert.ToInt32(pages);
            }
            catch
            { 
                total = 0;
            }

            return total;
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtPhone = txtPhone.Text;
            Properties.Settings.Default.Save();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            txtFrom.Enabled = txtAddress.Enabled = txtPhone.Enabled = rtbStamp.Enabled = btnResetStamp.Enabled = btnLock.Enabled = false;
            btnUnlock.Enabled = true;
            rtbStamp.ReadOnly = true;
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            txtFrom.Enabled = txtAddress.Enabled = txtPhone.Enabled = rtbStamp.Enabled = btnResetStamp.Enabled = btnLock.Enabled = true;
            rtbStamp.ReadOnly = false;
            btnUnlock.Enabled = false;
        }

        private void rtbStamp_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtStamp = rtbStamp.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtStamp = rtbStamp.Text = Properties.Settings.Default.StampDefaultValue;
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            float currentY = 25; // declare  one variable for height measurement
            e.Graphics.DrawString("Αποστολή από " + txtFrom.Text, new Font(FontFamily.GenericSerif, 28, FontStyle.Bold), Brushes.Black, 20, currentY);
            e.Graphics.DrawString("Ημερομηνία " + dateTimePicker1.Value.ToString("dd/MM/yyyy"), new Font(FontFamily.GenericSerif, 22, FontStyle.Bold), Brushes.Black, 750, currentY);
            currentY += 38;
            e.Graphics.DrawString(txtAddress.Text, new Font(FontFamily.GenericSerif, 16, FontStyle.Bold), Brushes.Black, 25, currentY);
            e.Graphics.DrawString("Αριθμός Αποστολής " +txtAA.Text, new Font(FontFamily.GenericSerif, 16, FontStyle.Bold), Brushes.Black, 760, currentY);
            currentY += 22;
            e.Graphics.DrawString("ΤΗΛ. " +txtPhone.Text, new Font(FontFamily.GenericSerif, 16, FontStyle.Bold), Brushes.Black, 25, currentY);
            Image barcode = new Barcode("550" + txtAA.Text, NetBarcode.Type.Code93, true).GetImage();
            e.Graphics.DrawImage(barcode, 780, currentY);
            currentY += 200;
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1),90, currentY-15, 600, 160);
            e.Graphics.DrawString(Properties.Settings.Default.txtStamp, new Font(FontFamily.GenericSerif, 16, FontStyle.Bold), Brushes.Black, 100, currentY);
            currentY += 160-15;
            e.Graphics.DrawString("( Σφραγίδα / Υπογραφή )", new Font(FontFamily.GenericSerif, 10, FontStyle.Italic), Brushes.Black, 325, currentY);
            currentY += 210+40+15;
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),450-15, currentY-10, 225, 50);
            e.Graphics.DrawString($"ΔΕΜΑΤΑ: { txtPrintOne.Text } / { getTotalPages(txtAD.Text) } ", new Font(FontFamily.GenericSerif, 18, FontStyle.Bold), Brushes.Black, 450, currentY);
        }

        private void btnSPP_Click(object sender, EventArgs e)
        {
            if ((txtAA.Text != "") && (txtAD.Text != "")) {
                PrintDialog printDialog = new PrintDialog();

                printDialog.Document = printDocument2; //add the document to the dialog box...        

                //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

                DialogResult result = printDialog.ShowDialog();

                if (result == DialogResult.OK)
                {

                    printDocument2.DefaultPageSettings.Landscape = true;
                    printDocument2.DefaultPageSettings.PaperSize =
                        new System.Drawing.Printing.PaperSize("A4", 297, 210);
                    printDocument2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                    printDocument2.Print();

                }
            }

            else
            {
                MessageBox.Show("Δεν έχετε καταχωρήση Αριθμό Δεμάτων ή/και Αριθμό Αποστολής! ");
            }
        }
    }
}
