using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcProfitButton_Click(object sender, EventArgs e)
        {
            // Creates a file dialog for user to select CSV file
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get file path from user selection and read file into list of strings
                string filePath = fileDialog.FileName;
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                double totalProfit = 0f;
                foreach (string line in lines)
                {
                    // Parse the right info in the CSV to the right column of the dataGridView
                    string[] columns = line.Split(',');
                    string textbook = columns[0];
                    string subject = columns[1];
                    string purchaser = columns[3];
                    string seller = columns[2];
                    string purchasePrice = columns[4];
                    string salePrice = columns[5];

                    // Calculates the profit of each book
                    double profit = 0f;
                    if (salePrice == "NA")
                    {
                        profit = Convert.ToDouble(purchasePrice) * -1;
                    }
                    else
                    {
                        profit = Convert.ToDouble(salePrice) - Convert.ToDouble(purchasePrice);
                    }

                    // Add profit to the total profit
                    totalProfit = totalProfit + profit;

                    // Round to 2 decimal places
                    profit = Math.Round(profit, 2);
                    totalProfit = Math.Round(totalProfit, 2);

                    // Add row with relevant info to dataGridView
                    string[] row = new string[] { textbook, subject, purchaser, seller, "$" + purchasePrice, "$" + salePrice, "$" + profit };
                    dgvSales.Rows.Add(row);

                }

                // Add total profit to the last row of dataGridView
                int rowCount = dgvSales.Rows.Count;
                dgvSales.Rows[rowCount - 1].Cells[5].Value = "Total Profit";
                dgvSales.Rows[rowCount - 1].Cells[6].Value = "$" + totalProfit;
            }
        }
    }
}
