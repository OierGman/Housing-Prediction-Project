using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Housing_Prediction_Value_Tool
{
    class DataScrapingTool
    {
        static void Main(string[] args)
        {
            GetUtilityAsync();
        }

        private static void GetUtilityAsync()
        {
            var url = "";

            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url);

            // var htmlDoc = new HtmlDocument();
        }
    }
}
