
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Invoice_Writer
{


    public partial class Form1 : Form
    {

        class Invoice
        {
            public string txtGoodsValue { get; set; }
            public string txtVAT { get; set; }
            public string txtTotal { get; set; }
            public string InvoiceDetails { get; set; }
            public string CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string VatRegistrationNumber { get; set; }
            public string CustomerAddress { get; set; }
            public string InvoiceNumber { get; set; }
            public DateTime InvoiceDate { get; set; }
            public List<InvoiceItem> InvoiceItems { get; set; }
            public decimal GoodsValue { get; set; } // Calculated field
            public decimal VAT { get; set; } // Calculated field
            public decimal Total { get; set; } // Calculated field

            // Method to calculate totals (refer to the UpdateInvoiceTotals code you already have)
            public void CalculateInvoiceTotals() { /*... */ }
        }


        class InvoiceItem
        {
            public int quantity { get; set; }
            public string description { get; set; }
            public decimal amount { get; set; }

            public int multy { get; set; }
        }

        public Form1()
        {

            InitializeComponent();
            // Set invoice date to current date
            dateTimePicker1.Value = DateTime.Now;
            txtInvoiceNumber.Value = Properties.Settings.Default.LastInvoiceNumber;

            // Allowing editing and adding rows in the DataGridView
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.AllowUserToAddRows = true;

            // Set invoice number format
           
        }

        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void vatReg_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInvoiceNumber_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GoodsValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void vat_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        private Bitmap CaptureFormArea()
        {
            Bitmap screenshot = null; // Declare the variable outside the Invoke

            // Use Invoke to execute the screenshot creation on the UI thread
            this.Invoke((MethodInvoker)delegate
            {
                // Find the window handle (HWND) of your invoice panel
                IntPtr invoicePanelHandle = invoicePanel.Handle;

                // Get the device context of the window
                IntPtr hdcSrc = User32.GetWindowDC(invoicePanelHandle);

                // Get the size of the invoice panel
                RECT windowRect = new RECT();
                User32.GetWindowRect(invoicePanelHandle, ref windowRect);
                int width = windowRect.right - windowRect.left;
                int height = windowRect.bottom - windowRect.top;
                
                // Create a compatible device context in memory
                IntPtr hdcDest = GDI32.CreateCompatibleDC(hdcSrc);
                IntPtr hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, width, height);

                // Select the bitmap into the memory device context
                IntPtr hOld = GDI32.SelectObject(hdcDest, hBitmap);

                // Copy from the window device context to the memory device context
                GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY);

                // Restore the old object in the memory device context
                GDI32.SelectObject(hdcDest, hOld);

                // Clean up
                GDI32.DeleteDC(hdcDest);
                User32.ReleaseDC(invoicePanelHandle, hdcSrc);

                // Create a bitmap from the memory device context's bitmap
                screenshot = System.Drawing.Image.FromHbitmap(hBitmap);

                // Delete the memory device context's bitmap
                GDI32.DeleteObject(hBitmap);
            });

            return screenshot;
        }


        // Helper class for Windows API imports
        private class User32
        {
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowDC(IntPtr hWnd);
            [DllImport("user32.dll")]
            public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);
        }

        private class GDI32
        {
            public const int SRCCOPY = 0x00CC0020;
            [DllImport("gdi32.dll")]
            public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
                int nWidth, int nHeight, IntPtr hObjectSource,
                int nXSrc, int nYSrc, int dwRop);
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
            [DllImport("gdi32.dll")]
            public static extern bool DeleteDC(IntPtr hDC);
            [DllImport("gdi32.dll")]
            public static extern bool DeleteObject(IntPtr hObject);
            [DllImport("gdi32.dll")]
            public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
        }



        private void GeneratePDF(string filePath, Bitmap formImage)
        {
            var document = new Document(PageSize.A4);

            try
            {
                var writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Convert Bitmap to iTextSharp Image
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(formImage, System.Drawing.Imaging.ImageFormat.Png);

                // Scale the image if needed (using ScaleAbsolute)
                if (pdfImage.Width > PageSize.A4.Width || pdfImage.Height > PageSize.A4.Height)
                {
                    float scalingFactor = 1.0f;

                    // Prioritize fitting the width
                    if (pdfImage.Width > PageSize.A4.Width)
                    {
                        scalingFactor = PageSize.A4.Width / pdfImage.Width;
                    }

                    // Check if height also needs scaling
                    if (pdfImage.Height * scalingFactor > PageSize.A4.Height)
                    {
                        scalingFactor = PageSize.A4.Height / pdfImage.Height;
                    }

                    pdfImage.ScaleAbsolute(pdfImage.Width * scalingFactor, pdfImage.Height * scalingFactor);
                }

                document.Add(pdfImage);

                document.Close();
                writer.Close();

                MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private Invoice CollectInvoiceDataFromForm()
        {
            Invoice invoice = new Invoice
            {
                CustomerID = txtCustomerID.Text,
                CustomerName = txtCustomerName.Text,
                VatRegistrationNumber = txtVatRegistrationNumber.Text,
                CustomerAddress = txtCustomerAddress.Text,
                InvoiceNumber = txtInvoiceNumber.Text,
                InvoiceDate = dateTimePicker1.Value,
                InvoiceDetails = invoiceDetails.Text,
                txtGoodsValue = txtGoodsValue.Text,
                txtVAT = txtVAT.Text,
                txtTotal = txtTotal.Text,


                InvoiceItems = new List<InvoiceItem>()
            };

            // Collect InvoiceItems from the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // Skip empty new row

                var item = new InvoiceItem()
                {
                    quantity = Convert.ToInt32(row.Cells["quantity"].Value),
                    description = row.Cells["description"].Value.ToString(),
                    multy = Convert.ToInt32(row.Cells["multy"].Value),
                    amount = Convert.ToDecimal(row.Cells["amount"].Value)
                };

                invoice.InvoiceItems.Add(item);
            }

            invoice.CalculateInvoiceTotals();
            return invoice;
        }


        private void PopulateFormWithInvoiceData(Invoice invoice)
        {
            // Customer details
            txtCustomerID.Text = invoice.CustomerID;
            txtCustomerName.Text = invoice.CustomerName;
            txtCustomerAddress.Text = invoice.CustomerAddress;
            txtVatRegistrationNumber.Text = invoice.VatRegistrationNumber;
            txtTotal.Text = invoice.txtTotal;
            txtVAT.Text = invoice.txtVAT;
            txtGoodsValue.Text = invoice.txtGoodsValue;

            // Invoice details
            txtInvoiceNumber.Text = invoice.InvoiceNumber;
            dateTimePicker1.Value = invoice.InvoiceDate;
            invoiceDetails.Text = invoice.InvoiceDetails;


            // Invoice items (clear existing items first)
            dataGridView1.Rows.Clear();
            foreach (var item in invoice.InvoiceItems)
            {
                dataGridView1.Rows.Add(item.quantity, item.description, item.multy, item.amount);
            }

        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "JSON files (*.json)|*.json";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonData = File.ReadAllText(openDialog.FileName);
                Invoice invoice = JsonConvert.DeserializeObject<Invoice>(jsonData);
                PopulateFormWithInvoiceData(invoice);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Invoice invoice = CollectInvoiceDataFromForm();

            // 1. Create folder on desktop (if it doesn't exist)
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string appFolder = Path.Combine(desktopPath, "MyInvoiceApp");
            Directory.CreateDirectory(appFolder);

            // 2. Save JSON with a default filename
            SaveFileDialog jsonSaveDialog = new SaveFileDialog();
            jsonSaveDialog.Filter = "JSON files (*.json)|*.json";
            jsonSaveDialog.DefaultExt = "json";
            jsonSaveDialog.InitialDirectory = appFolder;
            jsonSaveDialog.FileName = "invoice_" + invoice.InvoiceNumber + ".json";

            if (jsonSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonData = JsonConvert.SerializeObject(invoice);
                    File.WriteAllText(jsonSaveDialog.FileName, jsonData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Ask the user if they want to increment the invoice number
            DialogResult result = MessageBox.Show("Increment invoice number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 1. Get the invoice number entered by the user
                decimal InvoiceNumber = 0;
                if (decimal.TryParse(txtInvoiceNumber.Text, out InvoiceNumber))
                {
                    // 2. Increment the invoice number
                    InvoiceNumber++;

                    // 3. Update LastInvoiceNumber
                    Properties.Settings.Default.LastInvoiceNumber = InvoiceNumber;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    // Handle the case where the user didn't enter a valid number 
                    MessageBox.Show("Invalid Invoice Number entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // 3. PDF Saving 
            SaveFileDialog pdfSaveDialog = new SaveFileDialog();
            pdfSaveDialog.Filter = "PDF files (*.pdf)|*.pdf";
            pdfSaveDialog.FileName = "invoice_" + invoice.InvoiceNumber + ".pdf";

            if (pdfSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap formScreenshot = CaptureFormArea();
                    GeneratePDF(pdfSaveDialog.FileName, formScreenshot);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Application.Restart();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Retrieve Latest JSON File
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string appFolder = Path.Combine(desktopPath, "MyInvoiceApp");

            if (!Directory.Exists(appFolder))
            {
                MessageBox.Show("Invoice directory not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var jsonFiles = Directory.GetFiles(appFolder, "*.json")
                                     .Select(f => new FileInfo(f))
                                     .OrderByDescending(f => f.CreationTime)
                                     .ToList();

            if (jsonFiles.Count == 0)
            {
                MessageBox.Show("No invoice files found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string latestFilePath = jsonFiles.First().FullName;

            // 2. Load Invoice Data
            string jsonData = File.ReadAllText(latestFilePath);
            Invoice invoice = JsonConvert.DeserializeObject<Invoice>(jsonData);

            // 3. Populate the Form
            txtCustomerName.Text = invoice.CustomerName;
            txtCustomerID.Text = invoice.CustomerID;
            txtCustomerAddress.Text = invoice.CustomerAddress;
            txtVatRegistrationNumber.Text = invoice.VatRegistrationNumber;
        }
    }

}

