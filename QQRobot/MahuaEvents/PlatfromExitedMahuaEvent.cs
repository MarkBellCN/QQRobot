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
            ConfigCache.saveConfigToFile();
        }
    }
}
