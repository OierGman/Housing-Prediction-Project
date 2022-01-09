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

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = OperationsUtlity.createDataTable();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = OperationsUtlity.createDataTable();
            string filename = OpenSavefileDialog();
            dt.ToCSV(filename);
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
    }
}
