using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace AssetCSV
{
    public abstract class CsvParser
    {
        protected FileInfo FileInfo;
        protected Regex RegEx;

        public CsvParser(FileInfo fileInfo)
        {
            this.FileInfo = fileInfo;
            this.RegEx = new Regex("(?:[^,]*\"[^\"]*\")|([^,]+)", RegexOptions.Multiline | RegexOptions.IgnoreCase);
        }

        protected string[] ParseLine(string line)
        {
            List<string> dataList = new List<string>();

            MatchCollection lineMatches = this.RegEx.Matches(line);
            foreach (Match match in lineMatches)
            {
                dataList.Add(match.Groups[""].Value.Trim());
            }

            return dataList.ToArray();
        }

        protected IEnumerable<string> ReadLines(FileInfo fileInfo)
        {
            using StreamReader sr = File.OpenText(fileInfo.FullName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }
}
