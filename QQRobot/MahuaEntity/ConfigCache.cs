using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQRobot.MahuaEntity
{
    class ConfigCache
    {
        public static string configFilePath =  System.Windows.Forms.Application.StartupPath + "/config.json";
        
        public static IList<ConfigInfo> configInfos = new List<ConfigInfo>();

        public static BindingList<ConfigInfo> configInfosBind = new BindingList<ConfigInfo>(configInfos);

        public static IList<ConfigInfo> GetConfigInfoByGroupId(string groupId)
        {
            return configInfos;
        }
    }
}
