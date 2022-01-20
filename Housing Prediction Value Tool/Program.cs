using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_Prediction_Value_Tool
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // getPropertyInfo();
        }


        static void getPropertyInfo(string propertyType, int propertyRooms)
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

            foreach (var propertyListItem in propertyListItems)
            {
                // id
                Console.WriteLine(propertyListItem.GetAttributeValue("id", ""));

                // property value
                Console.WriteLine(propertyListItem.Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("propertyCard-priceValue")).FirstOrDefault().InnerText.Trim('\t', '\n', '£', 'r'));
            }
        }
    }
}
