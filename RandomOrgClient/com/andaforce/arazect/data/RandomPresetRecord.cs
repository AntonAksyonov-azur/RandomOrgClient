using System;
using RandomOrgClient.com.andaforce.arazect.format;

namespace RandomOrgClient.com.andaforce.arazect.data
{
    public class RandomPresetRecord
    {
        public String Name;
        public int Min;
        public int Max;
        public int Count;

        public override string ToString()
        {
            return String.Format("{0} ({1} -> {2})", Name, Min, Max);
        }
    }
}
