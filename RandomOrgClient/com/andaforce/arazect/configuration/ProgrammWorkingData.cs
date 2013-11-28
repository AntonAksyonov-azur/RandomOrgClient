using System.Collections.Generic;
using RandomOrgClient.com.andaforce.arazect.data;
using RandomOrgClient.com.andaforce.arazect.format;

namespace RandomOrgClient.com.andaforce.arazect.configuration
{
    public class ProgrammWorkingData : IConfigurationObject
    {
        public List<RandomPresetRecord> Records;
        public ProgrammSettings ProgrammSettings;

        public void InitDefault()
        {
            Records = new List<RandomPresetRecord>();
            ProgrammSettings = new ProgrammSettings()
            {
                CacheSequenceLenght = 10000,
                CountSystem = CountSystemType.Decimal,
                RandomNumberType = RandomNumberType.New,
                UseCache = true
            };
        }
    }
}