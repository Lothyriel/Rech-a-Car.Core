using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConfigurationManager
{
    public static class Config
    {
        public static IConfiguration AppConfig
        {
            get
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                return config;
            }
        }
    }
}
