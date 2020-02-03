using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string line = Console.ReadLine();

            // set a variable to the My Document path.
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // write the string array to a new file name "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "Data_Export.txt")))
            {
                //foreach (string line in lines)
                outputFile.WriteLine(line);
            }
        }
    }
}
