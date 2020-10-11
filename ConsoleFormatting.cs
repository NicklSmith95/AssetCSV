/*using System;
using System.IO;
using System.Text;

namespace AssetCSV
{
    public class ConsoleFormatting
    {
        public ConsoleFormatting(params string[] fieldsToPrint)
        {
            AssetParser ap = new AssetParser(new FileInfo(filePath));
            Assets csvData = ap.Parse();
        }

        private static void ConsoleFormatting(string[] fieldsToPrint, Assets csvData)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < fieldsToPrint.Length; i++)
            {
                sb.Append("{" + i.ToString() + ", -15}"); // {#,-15} Left Aligned 15 Char
            }
            string fmt = sb.ToString();

            // Print Header
            Console.WriteLine(fmt, fieldsToPrint);
            // Print Data
            foreach (object obj in csvData.CsvRow)
            {
                string[] row = obj as string[];
                if (!(row is null))
                {
                    Console.WriteLine(fmt, row, fieldsToPrint);
                }
            }
        }
    }
}
*/