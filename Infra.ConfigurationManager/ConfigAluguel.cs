using Dominio.AluguelModule;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace ConfigurationManager
{
    public class ConfigsAluguel : AppConfigManager
    {
        public static Configuracoes Configs
        {
            get
            {
                JObject o1 = JObject.Parse(File.ReadAllText(pathAppConfig));

                var gasolina = o1["Gasolina"].ToObject<double>();
                var diesel = o1["Diesel"].ToObject<double>();
                var etanol = o1["Etanol"].ToObject<double>();
                var caucao = o1["Caucao"].ToObject<double>();

                return new Configuracoes(etanol, diesel, gasolina, caucao);
            }
        }

        public static bool SalvaValores(string strEtanol, string strDiesel, string strGasolina, string strCaucao)
        {
            if (Double.TryParse(strEtanol, out double etanol) &&
                Double.TryParse(strDiesel, out double diesel) &&
                Double.TryParse(strGasolina, out double gasolina) &&
                Double.TryParse(strCaucao, out double caucao) &&
                new double[] { etanol, diesel, gasolina, caucao }.All(x => x > 0))
            {
                SalvaConfiguracoes(new Configuracoes(etanol, diesel, gasolina, caucao));
                return true;
            }
            return false;
        }
        private static void SalvaConfiguracoes(Configuracoes config)
        {
            var appConfig = AppConfig;
            appConfig["Gasolina"] = new JValue(config.ValorGasolina);
            appConfig["Diesel"] = new JValue(config.ValorDiesel);
            appConfig["Etanol"] = new JValue(config.ValorEtanol);

            appConfig["Caucao"] = new JValue(config.ValorCaucao);

            Save(appConfig);
        }
    }
}
