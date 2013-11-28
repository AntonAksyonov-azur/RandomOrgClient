using System;
using System.Windows.Forms;

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