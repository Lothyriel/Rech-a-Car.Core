using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace ConfigurationManager
{
    public class AppConfigManager
    {
        private static string pathProject = $"{AppDomain.CurrentDomain.BaseDirectory}";
        protected static string pathAppConfig = $"{Path.GetFullPath(Path.Combine(pathProject, @"..\..\..\"))}\\Appsettings.json";
        protected static void Save(JObject newAppConfig)
        {
            File.WriteAllText(pathAppConfig, JsonConvert.SerializeObject(newAppConfig));
        }
        public static JObject AppConfig => JObject.Parse(File.ReadAllText(pathAppConfig));
    }
}