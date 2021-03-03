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
                printDocument1.Dispose();
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
                    printDocument2.Dispose();
                }
            }

            else
            {
                MessageBox.Show("Δεν έχετε καταχωρήση Αριθμό Δεμάτων ή/και Αριθμό Αποστολής! ");
            }
        }

        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image cov = Properties.Resources.stay_safe;
            e.Graphics.DrawImage(cov, 60, 10,1000,800);
        }

        private void btnStaySafe_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument3; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDocument3.DefaultPageSettings.Landscape = true;
                printDocument3.DefaultPageSettings.PaperSize =
                    new System.Drawing.Printing.PaperSize("A4", 297, 210);
                //printDocument2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                printDocument3.Print();
                printDocument3.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument4; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDocument4.DefaultPageSettings.Landscape = true;
                printDocument4.DefaultPageSettings.PaperSize =
                    new System.Drawing.Printing.PaperSize("A4", 297, 210);
                //printDocument2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                printDocument4.Print();
                printDocument4.Dispose();
            }
        }

        private void printDocument4_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image cov = Properties.Resources.stop_covid19;
            e.Graphics.DrawImage(cov, 60, 10,1000,800);
        }

        private void printDocument5_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image cov = Properties.Resources.how_not_to_wear_a_mask;
            e.Graphics.DrawImage(cov, 60, 10,1000,800);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument5; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDocument5.DefaultPageSettings.Landscape = true;
                printDocument5.DefaultPageSettings.PaperSize =
                    new System.Drawing.Printing.PaperSize("A4", 297, 210);
                //printDocument2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                printDocument5.Print();
                printDocument5.Dispose();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument6; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDocument6.DefaultPageSettings.Landscape = true;
                printDocument6.DefaultPageSettings.PaperSize =
                    new System.Drawing.Printing.PaperSize("A4", 297, 210);
                //printDocume6t2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                printDocument6.Print();
                printDocument6.Dispose();

            }
        }

        private void printDocument6_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image cov = Properties.Resources.until_2;
            e.Graphics.DrawImage(cov, 60, 10,1000,800);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument7; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDocument7.DefaultPageSettings.Landscape = false;
                printDocument7.DefaultPageSettings.PaperSize =
                    new System.Drawing.Printing.PaperSize("A4", 210, 297);
                //printDocume6t2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                printDocument7.Print();
                printDocument7.Dispose();

            }
        }

        private void printDocument7_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image cov = Properties.Resources.pinakida_simansis_face_mask_required;
            e.Graphics.DrawImage(cov, 60, 10,730,1000);
        }

        private void handle_wcDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image cov = Properties.Resources.handle_with_care;
            e.Graphics.DrawImage(cov, 60, 10,730,1000);
        }

        private void handle_wcupDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image cov = Properties.Resources.handle_with_care_tsup;
            e.Graphics.DrawImage(cov, 60, 10,730,1000);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = handle_wcDocument; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                handle_wcDocument.DefaultPageSettings.Landscape = false;
                handle_wcDocument.DefaultPageSettings.PaperSize =
                    new System.Drawing.Printing.PaperSize("A4", 210, 297);
                //printDocume6t2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                handle_wcDocument.Print();
                handle_wcDocument.Dispose();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = handle_wcupDocument; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                handle_wcupDocument.DefaultPageSettings.Landscape = false;
                handle_wcupDocument.DefaultPageSettings.PaperSize =
                    new System.Drawing.Printing.PaperSize("A4", 210, 297);
                //printDocume6t2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                handle_wcupDocument.Print();
                handle_wcupDocument.Dispose();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument8; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDocument8.DefaultPageSettings.Landscape = true;
                printDocument8.DefaultPageSettings.PaperSize =
                    new System.Drawing.Printing.PaperSize("A4", 297, 210);
                //printDocume6t2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                printDocument8.Print();
                printDocument8.Dispose();

            }
        }

        private void printDocument8_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image cov = Properties.Resources.mandatory_masks_2;
            e.Graphics.DrawImage(cov, 60, 10,1000,800);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument9; //add the document to the dialog box...        

            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                printDocument9.DefaultPageSettings.Landscape = true;
                printDocument9.DefaultPageSettings.PaperSize =
                    new System.Drawing.Printing.PaperSize("A4", 297, 210);
                //printDocume6t2.DocumentName = $"apostoles_dematwn_page_{txtPrintOne.Text}_of_{txtAD.Text}";
                printDocument9.Print();
                printDocument9.Dispose();

            }
        }

        private void printDocument9_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image cov = Properties.Resources._1_atomo;
            e.Graphics.DrawImage(cov, 60, 10,1000,800);
        }
    }
}
