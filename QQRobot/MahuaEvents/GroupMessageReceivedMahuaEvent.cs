using Newbe.Mahua;
using Newbe.Mahua.MahuaEvents;
using QQRobot.MahuaEntity;
using System;

namespace QQRobot.MahuaEvents
{
    /// <summary>
    /// 群消息接收事件
    /// </summary>
    public class GroupMessageReceivedMahuaEvent
        : IGroupMessageReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        public GroupMessageReceivedMahuaEvent(
            IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        public void ProcessGroupMessage(GroupMessageReceivedContext context)
        {
            for (int i = 0; i < ConfigCache.configInfos.Count; i++)
            {
                ConfigInfo config = ConfigCache.configInfos[i];
                if (config.groupId.Equals(context.FromGroup) && context.SendTime <= config.endTime && context.SendTime >= config.startTime)
                {
                    if (TypeCode.String == context.Message.GetTypeCode())
                    {
                        if(context.Message !=null && context.Message.Length >= config.msgLen)
                        {
                            _mahuaApi.SendGroupMessage(context.FromGroup, config.replyContent);
                        }
                    }
                    else
                    {
                        _mahuaApi.SendGroupMessage(context.FromGroup, config.replyContent);
                    }
                }
            }
        }
    }
}
