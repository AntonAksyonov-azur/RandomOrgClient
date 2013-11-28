using System;

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

        public static bool operator ==(RandomPresetRecord obj1, bool obj2)
        {
            return obj1 == null;
        }

        public static bool operator !=(RandomPresetRecord obj1, bool obj2)
        {
            return obj1 != null;
        }
    }
}