using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Prediction_Value_Tool
{
    public static class OperationsUtlity
    {
        public static DataTable createDataTable()
        {
            DataTable table = new DataTable();
            //columns
            table.Columns.Add("ROOMS", typeof(int));
            table.Columns.Add("VALUE", typeof(int));
            table.Columns.Add("HOUSE TYPE", typeof(string));

            //data
            table.Rows.Add(2, 300000, "TH");
            table.Rows.Add(3, 325000, "H");
            table.Rows.Add(2, 268000, "F");
            table.Rows.Add(5, 609000, "H");
            table.Rows.Add(2, 295000, "F");
            table.Rows.Add(3, 320000, "TH");
            table.Rows.Add(5, 750000, "H");
            table.Rows.Add(3, 370000, "H");

            return table;
        }
    }  
}
