using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;

namespace ReRunBabyUpload
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        string name = string.Empty;
        string expectedColoumns = string.Empty;
        string outputColoumns = string.Empty;
        DataTableCollection dtc;



        private void ValidateSourceColoumn()
        {
            string inputText = txt_source_columns.Text;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("The column input cannot be empty.");
                return;
            }
        }

        private void OriginalDataGridViewPopulate()
        {
            //what we use to populate the og datagridview
            if (comboBox1.SelectedItem != null)
            {
                DataTable dataTable = dtc[comboBox1.SelectedItem.ToString()];
                dataGridViewExcel.DataSource = dataTable;
            }
        }

        private DataTable ProcessDataTable(DataTable originalTable)
        {
            DataTable newTable = new DataTable();
            string[] outputColumnsArray = txt_csv.Text.Split(',');

            if (string.IsNullOrWhiteSpace(txt_csv.Text))
            {
                // If no new column names are provided, use the original ones
                foreach (DataColumn column in originalTable.Columns)
                {
                    newTable.Columns.Add(column.ColumnName);
                }

                foreach (DataRow row in originalTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();
                    foreach (DataColumn column in originalTable.Columns)
                    {
                        newRow[column.ColumnName] = row[column.ColumnName];
                    }
                    newTable.Rows.Add(newRow);
                }
            }
            else
            {
                // Use the provided output column names
                foreach (var column in outputColumnsArray)
                {
                    newTable.Columns.Add(column.Trim());
                }

                string[] expectedColumnsArray = txt_source_columns.Text.Split(',');
                var columnMappings = new Dictionary<string, string>();

                for (int i = 0; i < expectedColumnsArray.Length; i++)
                {
                    columnMappings[expectedColumnsArray[i].Trim()] = outputColumnsArray[i].Trim();
                }

                foreach (DataRow row in originalTable.Rows)
                {
                    DataRow newRow = newTable.NewRow();
                    foreach (var mapping in columnMappings)
                    {
                        newRow[mapping.Value] = row[mapping.Key].ToString();
                    }
                    newTable.Rows.Add(newRow);
                }
            }

            return newTable;
        }

        private bool OnlytaketheseExcelFiles(DataTable dataTable)
        {
            string[] expectedColumnsArray = dataTable.Columns.Cast<DataColumn>().Select(col => col.ColumnName).ToArray();
            txt_source_columns.Text = string.Join(",", expectedColumnsArray);
            return true;

        }

        private void Convert(DataTable dataTable, string csvFilePath)
        {
            StringBuilder stringBuilder = new StringBuilder();
            IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            stringBuilder.AppendLine(string.Join(",", columnNames));

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string[] fields = dataTable.Rows[i].ItemArray.Select(field => field.ToString()).ToArray();
                stringBuilder.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(csvFilePath, stringBuilder.ToString(), Encoding.UTF8);
            MessageBox.Show("Your data has been converted to a CSV file!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //doesnt work oops

        }

        private void txt_columns_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //saves file in csv
            if (dataGridViewCSV.DataSource == null)
            {
                MessageBox.Show("Please process the data first!");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV files (*.csv)|*.csv" })
            {
               
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string csvFilePath = saveFileDialog.FileName;
                    Convert((DataTable)dataGridViewCSV.DataSource, csvFilePath);
                    txt_csv_path.Text = csvFilePath;
                } 
              
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OriginalDataGridViewPopulate();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            //processes the files from csv to excel by taking og file and using the processdatatable method to output it the way we want
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an Excel file from the combobox first!");
                return;
            }

            DataTable originalTable = dtc[comboBox1.SelectedItem.ToString()];
            DataTable processedTable = ProcessDataTable(originalTable);
            dataGridViewCSV.DataSource = processedTable;

            tabControl1.SelectedTab = tabPage_CSV;
        }

        private void btn_close_excel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_upload_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx" })
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txt_excel_path.Text = openFileDialog1.FileName;
                    openFileDialog1.RestoreDirectory = true;
                    using (var stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            dtc = result.Tables;

                            if (!OnlytaketheseExcelFiles(dtc[0]))
                            {
                                MessageBox.Show("Invalid file format. The file must have the expected columns.");
                                return;
                            }

                            comboBox1.Items.Clear();
                            for (int l = 0; l < dtc.Count; l++)
                            {
                                comboBox1.Items.Add(dtc[l].TableName);
                            }
                            OriginalDataGridViewPopulate();
                            
                        }
                    }
                }
            }
        }

        private void btn_Close_csv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btn_view_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageEXCEL;
        }

        private void txt_output_TextChanged(object sender, EventArgs e)
        {
            lbl_naming_columns_hint.Visible = !string.IsNullOrWhiteSpace(txt_output.Text);
        }
    }
}
