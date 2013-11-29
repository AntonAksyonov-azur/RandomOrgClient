using System;

namespace RandomOrgClient.com.andaforce.arazect.data
{
    public class RandomPresetRecord
    {
        protected bool Equals(RandomPresetRecord other)
        {
            return string.Equals(Name, other.Name) && Min == other.Min && Max == other.Max && Count == other.Count;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((RandomPresetRecord) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Min;
                hashCode = (hashCode * 397) ^ Max;
                hashCode = (hashCode * 397) ^ Count;
                return hashCode;
            }
        }

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