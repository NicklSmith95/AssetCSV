using System.Collections.Generic;
using System.IO;

namespace AssetCSV
{
    public class AssetParser : CsvParser
    {
        public AssetParser(FileInfo fileInfo) : base(fileInfo) { }

        public List<Assets> Parse()
        {
            List<Assets> assetList = new List<Assets>();
            foreach(Assets asset in this.ParseEach())
            {
                assetList.Add(asset);
            }
            return assetList;
        }

        public IEnumerable<Assets> ParseEach()
        {
            bool isHeader = true;
            foreach (string line in this.ReadLines(FileInfo))
            {
                if (isHeader) { isHeader = false; continue; }
                yield return new Assets(ParseLine(line));
            }
        }
    }
}
