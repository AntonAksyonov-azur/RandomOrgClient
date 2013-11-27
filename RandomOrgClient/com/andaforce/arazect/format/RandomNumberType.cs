using System;

namespace RandomOrgClient.com.andaforce.arazect.format
{
    public enum RandomNumberType
    {
        New = 0,
        IdIdentifier = 1,
        DateIsodate = 2
    }

    public static class RandomTypeExtension
    {
        public static String GetStringRepresentation(this RandomNumberType randomNumberType)
        {
            switch (randomNumberType)
            {
                case RandomNumberType.New:
                    return "new";
                case RandomNumberType.IdIdentifier:
                    return "id.identifier";
                case RandomNumberType.DateIsodate:
                    return "date.isodate";
                default:
                    return "new";
            }
        }
    }
}