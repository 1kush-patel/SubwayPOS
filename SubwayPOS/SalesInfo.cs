using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SubwayPOS
{
    public partial class SalesInfo : Form
    {
      
        public int userID;
        private PrintDocument printDocument1;
        public string userName;

        public SalesInfo()
        {
            InitializeComponent();
        }

        public SalesInfo(int currentUserID, string currentUserName)
        {
            InitializeComponent();

            userID = currentUserID;
            userName = currentUserName;
            printDocument1 = new PrintDocument();

            // Assign the PrintPage event handler
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
        }

        private void SalesInfo_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader reader = Model.getSalesInfoWithUserId(userID);

                
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Bind the DataTable to the DataGrid
                        dataGridSalesInfo.BackgroundColor = SystemColors.Window;
                        dataGridSalesInfo.DataSource = dt;
                      
                        dataGridSalesInfo.EnableHeadersVisualStyles = false;

                        // Customize the header columns appearance
                        foreach (DataGridViewColumn column in dataGridSalesInfo.Columns)
                        {
                            // Set the header text to bold
                            column.HeaderCell.Style.Font = new Font(dataGridSalesInfo.Font, FontStyle.Bold);

                            // Set the header text color to green
                            column.HeaderCell.Style.ForeColor = Color.DarkGreen;

                            // Set the header background color
                            column.HeaderCell.Style.BackColor = Color.LightGray;
                         
                            dataGridSalesInfo.ForeColor = Color.Green;
                        }
                        dataGridSalesInfo.RowHeadersVisible = false;

                    }

                Model.closeConnection();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.GetType());
            }
            dataGridSalesInfo.Margin = new Padding(0);
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            // Show print dialog and start printing if user clicks "OK"
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Clear the page
            e.Graphics.Clear(Color.White);

            // Draw the contents of dataGridSalesInfo on the print page
            int rowHeight = dataGridSalesInfo.RowTemplate.Height;
            int currentY = 100; // Start printing below the header

            // Calculate column widths based on cell contents and column names
            int[] columnWidths = new int[dataGridSalesInfo.Columns.Count];
            for (int columnIndex = 0; columnIndex < dataGridSalesInfo.Columns.Count; columnIndex++)
            {
                string columnName = dataGridSalesInfo.Columns[columnIndex].HeaderText;
                int columnNameWidth = (int)e.Graphics.MeasureString(columnName, dataGridSalesInfo.Font).Width + 12;
                int cellMaxWidth = dataGridSalesInfo.Rows.Cast<DataGridViewRow>()
                    .Select(row => (int)e.Graphics.MeasureString(row.Cells[columnIndex].Value?.ToString(), dataGridSalesInfo.Font).Width + 10)
                    .Max();
                columnWidths[columnIndex] = Math.Max(columnNameWidth, cellMaxWidth);
            }

            // Draw column names at the top of the table within each column
            int currentX = dataGridSalesInfo.RowHeadersWidth;
            for (int columnIndex = 0; columnIndex < dataGridSalesInfo.Columns.Count; columnIndex++)
            {
                string columnName = dataGridSalesInfo.Columns[columnIndex].HeaderText;
                int centerColumnNameX = currentX + (columnWidths[columnIndex] - (int)e.Graphics.MeasureString(columnName, dataGridSalesInfo.Font).Width) / 2;

                e.Graphics.DrawString(columnName, dataGridSalesInfo.Font, Brushes.Black, centerColumnNameX, 80);

                currentX += columnWidths[columnIndex];
            }

            // Draw lines for column names and borders
            using (Pen pen = new Pen(Brushes.Black))
            {
                currentX = dataGridSalesInfo.RowHeadersWidth;
                e.Graphics.DrawLine(pen, currentX, 80, currentX, currentY + rowHeight);

                for (int columnIndex = 0; columnIndex < dataGridSalesInfo.Columns.Count; columnIndex++)
                {
                    currentX += columnWidths[columnIndex];
                    e.Graphics.DrawLine(pen, currentX, 80, currentX, currentY + rowHeight);
                }

                e.Graphics.DrawLine(pen, dataGridSalesInfo.RowHeadersWidth, currentY + rowHeight, currentX, currentY + rowHeight);
            }

            // Draw rows
            foreach (DataGridViewRow row in dataGridSalesInfo.Rows)
            {
                currentX = dataGridSalesInfo.RowHeadersWidth;
                for (int columnIndex = 0; columnIndex < dataGridSalesInfo.Columns.Count; columnIndex++)
                {
                    e.Graphics.DrawString(row.Cells[columnIndex].Value?.ToString(), dataGridSalesInfo.Font, Brushes.Black, currentX, currentY + 5);
                    currentX += columnWidths[columnIndex];
                }
                currentY += rowHeight;

                // Draw horizontal lines for each row
                using (Pen pen = new Pen(Brushes.Black))
                {
                    e.Graphics.DrawLine(pen, dataGridSalesInfo.RowHeadersWidth, currentY, currentX, currentY);
                }
            }Hide();
        }


        private void dataGridSalesInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

