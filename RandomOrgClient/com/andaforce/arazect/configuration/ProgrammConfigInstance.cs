using System;
using RandomOrgClient.com.andaforce.arazect.data;

namespace RandomOrgClient.com.andaforce.arazect.configuration
{
    public static class ProgrammConfigInstance
    {
        public const String PathToConfig = "config.xml";
        private static ProgrammWorkingData _instance;

        public static void Load()
        {
            _instance =
                ConfigurationLoader.LoadConfiguration<ProgrammWorkingData>(PathToConfig);
        }

        public static void Save()
        {
            ConfigurationLoader.SaveConfiguration(_instance, PathToConfig);
        }

        public static ProgrammWorkingData GetCopy()
        {
            return new ProgrammWorkingData()
            {
                ProgrammSettings = new ProgrammSettings()
                {
                    CountSystem = _instance.ProgrammSettings.CountSystem,
                    RandomNumberType = _instance.ProgrammSettings.RandomNumberType,
                    UseCache = _instance.ProgrammSettings.UseCache,
                    CacheSequenceLenght = _instance.ProgrammSettings.CacheSequenceLenght,
                    OfflineMode = _instance.ProgrammSettings.OfflineMode
                },
                Records = _instance.Records
            };
        }

        public static void Replace(ProgrammWorkingData anotherInstance)
        {
            _instance = anotherInstance;
        }

        public static ProgrammWorkingData Get()
        {
            if (_instance != null)
            {
                return _instance;
            }

            throw new Exception("Instance object wasn't loaded at this moment");
        }
    }
}