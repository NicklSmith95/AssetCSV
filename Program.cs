using System;

namespace AssetCSV
{
    class Program
    {
        public static string filePath = @"/Users/nick/Desktop/C#Projects/AssetCSV/AssetCSV/Asset.csv";
        static void Main(string[] args)
        {
            try
            {
                PrintAssets();
            }
            catch(ArgumentOutOfRangeException argex)
            {
                Console.WriteLine(argex.Message);
            }
            Console.ReadLine();
        }

        public static void PrintAssets()
        {
            string fmt = "{0, -20}{1, -20}{2,-20}{3, -20}";
            Console.WriteLine(fmt, "Serial Number", "Asset Type", "Status", "Assigned To");

            AssetParser parser = new AssetParser(new System.IO.FileInfo(filePath));
            foreach (Assets asset in parser.Parse())
            {
                Console.WriteLine(fmt, asset.SerialNumber, asset.AssetType, asset.Status, asset.AssignedTo);
            }
        }
    }
}
