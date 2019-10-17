using Newbe.Mahua.MahuaEvents;
using System;
using System.IO;
using Newbe.Mahua;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QQRobot.MahuaEntity;
using System.Windows;

namespace QQRobot.MahuaEvents
{
    /// <summary>
    /// 机器人平台退出事件
    /// </summary>
    public class PlatfromExitedMahuaEvent
        : IPlatformExitedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public PlatfromExitedMahuaEvent(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void Exited(PlatformExitedContext context)
        {
            if (!File.Exists(ConfigCache.configFilePath))
            {
                File.Create(ConfigCache.configFilePath);
            }
            StreamWriter sw = new StreamWriter(ConfigCache.configFilePath);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            //构建Json.net的写入流 
            JsonWriter writer = new JsonTextWriter(sw);
            //把模型数据序列化并写入Json.net的JsonWriter流中 
            serializer.Serialize(writer, ConfigCache.configInfos);
            writer.Close();
            sw.Close();
        }
    }
}
