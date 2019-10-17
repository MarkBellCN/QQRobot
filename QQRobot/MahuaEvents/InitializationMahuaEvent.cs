using Newbe.Mahua;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using QQRobot.MahuaEntity;
using System.Windows;

namespace QQRobot.MahuaEvents
{
    /// <summary>
    /// 插件初始化事件
    /// </summary>
    public class InitializationMahuaEvent
        : IInitializationMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public InitializationMahuaEvent(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void Initialized(InitializedContext context)
        {
            StreamReader file = File.OpenText(ConfigCache.configFilePath);
            if (null != file)
            {
                string json = file.ReadToEnd();
                IList<ConfigInfo> items = JsonConvert.DeserializeObject<List<ConfigInfo>>(json);
                for (int i = 0; i < items.Count; i++)
                {
                    ConfigCache.configInfosBind.Add(items[i]);
                }
            }
        }
    }
}
