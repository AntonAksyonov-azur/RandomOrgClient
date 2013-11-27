//using System.Windows.Forms;

using System;
using System.IO;
using System.Xml.Serialization;

namespace RandomOrgClient.com.andaforce.arazect.configuration
{
    public class ConfigurationLoader
    {
        public delegate void OnExceptionDelegate(Exception e);

        public static OnExceptionDelegate OnLoadException;
        public static OnExceptionDelegate OnSaveException;

        public static T LoadConfiguration<T>(String loadPath) where T : IConfigurationObject, new()
        {
            try
            {
                var serializer = new XmlSerializer(typeof (T));
                TextReader reader = new StreamReader(loadPath);
                T instance = (T) serializer.Deserialize(reader);
                reader.Close();

                return instance;
            }
            catch (IOException e)
            {
                if (OnLoadException != null)
                {
                    OnLoadException.Invoke(e);
                }

                T instance = new T();

                instance.InitDefault();
                return instance;
            }
        }

        public static void SaveConfiguration<T>(T configurationObject, String savePath)
        {
            try
            {
                var serializer = new XmlSerializer(typeof (T));
                TextWriter writer = new StreamWriter(savePath);
                serializer.Serialize(writer, configurationObject);
                writer.Close();
            }
            catch (IOException e)
            {
                if (OnSaveException != null)
                {
                    OnSaveException.Invoke(e);
                }
            }
        }
    }

    public interface IConfigurationObject
    {
        void InitDefault();
    }
}