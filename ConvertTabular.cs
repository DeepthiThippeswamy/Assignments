using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Console_App_Assignment
{
    class ConvertTabular
    {
        static void Main(string[] args)
        {
            CsvToDataTable obj = new CsvToDataTable();
            DataTable dtData = obj.ConvertCsvToDataTable(@"C:\Users\Deepthi T\source\repos\Console App-Assignment\Console App-Assignment\EmpData.txt");
            obj.ShowData(dtData);
        }

        class CsvToDataTable
        {
            public DataTable ConvertCsvToDataTable(string filePath)
            {
                
                string[] rows = File.ReadAllLines(filePath);

                DataTable dtData = new DataTable();
                string[] rowValues = null;
                DataRow dr = dtData.NewRow();

                
                if (rows.Length > 0)
                {
                    foreach (string columnName in rows[0].Split(','))
                        dtData.Columns.Add(columnName);
                }

                
                for (int row = 1; row < rows.Length; row++)
                {
                    rowValues = rows[row].Split(',');
                    dr = dtData.NewRow();
                    dr.ItemArray = rowValues;
                    dtData.Rows.Add(dr);
                }

                return dtData;
            }

            public void ShowData(DataTable dtData)
            {
                if (dtData != null && dtData.Rows.Count > 0)
                {
                    foreach (DataColumn dc in dtData.Columns)
                    {
                        Console.Write(dc.ColumnName + " ");
                    }
                    Console.WriteLine("\n-----------------------------------------------");

                    foreach (DataRow dr in dtData.Rows)
                    {
                        foreach (var item in dr.ItemArray)
                        {
                            Console.Write(item.ToString() + "      ");
                        }
                        Console.Write("\n");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
