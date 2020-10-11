using System;
namespace AssetCSV
{
    public class Assets
    {
   
        public Assets(string[] data)
        {
            if (data.Length != 4) throw new ArgumentOutOfRangeException();
            this.Data = data;
        }
        public string[] Data { get; private set; }
        public string SerialNumber { get { return this.Data[0]; } }
        public string AssetType { get { return this.Data[1]; } }
        public string Status { get { return this.Data[2]; } }
        public string AssignedTo { get { return this.Data[3]; } }
    }
}
