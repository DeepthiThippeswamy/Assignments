using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Console_App_Assignment
{
    class FileLowerCaseToUpperCase
    {
        static void Main()
        {
            //Console.Write("Enter name file: ");
            string name = @"C:\Users\Deepthi T\source\repos\Console App-Assignment\Console App-Assignment\EmpData.txt";

            if (File.Exists(name))
            {
                StreamReader fileRw = File.OpenText(name);
                StreamWriter fileWr = File.CreateText(name + "uppercase" + ".csv");
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                        fileWr.WriteLine(line.ToUpper());
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
                if (File.Exists(name + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }
    }
}

