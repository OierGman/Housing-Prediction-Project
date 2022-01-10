using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_Prediction_Value_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable tableData = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tableData;
            tableData.Columns.Add("ROOMS", typeof(int));
            tableData.Columns.Add("VALUE", typeof(int));
            tableData.Columns.Add("HOUSE TYPE", typeof(string));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = OpenSavefileDialog();
            tableData.ToCSV(filename);
        }

        private string OpenSavefileDialog()
        {
            string Filename = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Excel|*.xls";
            saveFileDialog.Filter = "csv File|*.csv";
            saveFileDialog.Title = "Save Report";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Filename = saveFileDialog.FileName;
            }
            return Filename;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int room = int.Parse(textboxRooms.Text);
            int value = int.Parse(textboxValue.Text);
            string type = textboxType.Text.ToUpper();

            tableData.Rows.Add(room, value, type);

            textboxRooms.Text = String.Empty;
            textboxValue.Text = String.Empty;
            textboxType.Text = String.Empty;

            labelNumData.Text = "Number of Entries: " + tableData.Rows.Count;
        }
    }
}
