using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQRobot.MahuaEntity
{
    class ConfigCache
    {
        public static bool isInit = true;

        public static string configFilePath =  System.Windows.Forms.Application.StartupPath + "/config.json";
        
        public static IList<ConfigInfo> configInfos = new List<ConfigInfo>();

        public static BindingList<ConfigInfo> configInfosBind = new BindingList<ConfigInfo>(configInfos);

        public static IList<ConfigInfo> GetConfigInfoByGroupId(string groupId)
        {
            return configInfos;
        }

        public static void loadConfigByFile()
        {
            if (ConfigCache.isInit)
            {
                fileIsExists();
                StreamReader file = File.OpenText(ConfigCache.configFilePath);
                string json = file.ReadToEnd();
                if (!"".Equals(json) && null!= json && json.Length>0)
                {
                    IList<ConfigInfo> items = JsonConvert.DeserializeObject<List<ConfigInfo>>(json);
                    for (int i = 0; i < items.Count; i++)
                    {
                        ConfigCache.configInfosBind.Add(items[i]);
                    }
                }
                file.Close();
                ConfigCache.isInit = false;
            }
        }

        public static void saveConfigToFile()
        {
            fileIsExists();
            StreamWriter sw = new StreamWriter(ConfigCache.configFilePath);
            IsoDateTimeConverter timeFormat = new IsoDateTimeConverter();
            timeFormat.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            string jsonStr = JsonConvert.SerializeObject(ConfigCache.configInfos, Formatting.Indented, timeFormat);
            sw.Write(jsonStr);
            sw.Flush();
            sw.Close();
        }

        private static void fileIsExists()
        {
            if (!File.Exists(ConfigCache.configFilePath))
            {
                FileStream fs = File.Create(ConfigCache.configFilePath);
                fs.Close();
            }
        }
    }
}
