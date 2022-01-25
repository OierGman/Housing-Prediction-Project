using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;

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
            tableData.Columns.Add("PROPERTY ID", typeof(string));
            tableData.Columns.Add("ROOMS", typeof(int));
            tableData.Columns.Add("VALUE", typeof(string));
            tableData.Columns.Add("HOUSE TYPE", typeof(string));

            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

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

        private List<string> getPropertyValue(string propertyType, string propertyRooms)
        {
            var url = "https://www.rightmove.co.uk/property-for-sale/find.html?locationIdentifier=REGION%5E61307&maxBedrooms=" + propertyRooms + "&minBedrooms=" + propertyRooms + "&propertyTypes=" + propertyType + "&includeSSTC=false&mustHave=&dontShow=&furnishTypes=&keywords=";

            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();

            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            var propertyHtml = doc.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("l-searchResults")).ToList();

            var propertyListItems = propertyHtml[0].Descendants("div")
                .Where(node => node.GetAttributeValue("id", "")
                .Contains("property-")).ToList();

            List<string> propertyValues = new List<string>();


            foreach (var propertyListItem in propertyListItems)
            {
                string p = propertyListItem.Descendants("div")
                                        .Where(node => node.GetAttributeValue("class", "")
                                        .Equals("propertyCard-priceValue"))
                                        .FirstOrDefault().InnerText
                                        .Trim('\t', '\n', '£', '\r', ',', ' ');
                propertyValues.Add(p);
            }
            return propertyValues;
        }

        private List<string> getPropertyId(string propertyType, string propertyRooms)
        {
            var url = "https://www.rightmove.co.uk/property-for-sale/find.html?locationIdentifier=REGION%5E61307&maxBedrooms=" + propertyRooms + "&minBedrooms=" + propertyRooms + "&propertyTypes=" + propertyType + "&includeSSTC=false&mustHave=&dontShow=&furnishTypes=&keywords=";

            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();

            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            var propertyHtml = doc.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("l-searchResults")).ToList();

            var propertyListItems = propertyHtml[0].Descendants("div")
                .Where(node => node.GetAttributeValue("id", "")
                .Contains("property-")).ToList();

            // return property id
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string propertyRoom = textboxRooms.Text;
            string propertyType = textboxType.Text.ToLower();

            List<string> propertyValue = getPropertyValue(propertyType, propertyRoom);

            foreach (var item in propertyValue)
            {
                NumberStyles numStyle = NumberStyles.AllowThousands;
                CultureInfo culture = new CultureInfo("en-US");
                int newItem = 0;

                bool resultOfConvert = Int32.TryParse(item, numStyle, culture, out newItem);

                if ( resultOfConvert == true)
                {
                    tableData.Rows.Add("Not Found", propertyRoom, newItem, propertyType);
                }
            }         
            // max smells

            labelNumData.Text = "Number of Entries: " + tableData.Rows.Count;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textboxRooms.Text = String.Empty;
            textboxType.Text = String.Empty;
        }
    }
}
