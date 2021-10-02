using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ConfigurationManager
{
    public class AppConfigManager
    {
        protected const string pathAppConfig = @"..\..\..\appsettings.json";

        protected static void Save(JObject appConfig)
        {
            File.WriteAllText(pathAppConfig, JsonConvert.SerializeObject(appConfig));
        }
        public static JObject AppConfig => JObject.Parse(File.ReadAllText(pathAppConfig));
    }
}