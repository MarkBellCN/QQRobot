using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQRobot.MahuaEntity
{
    public class ConfigInfo
    {
        public string groupId { get; set; }

        public DateTime startTime { get; set; }

        public DateTime endTime { get; set; }

        public int msgLen { get; set; }

        public string replyContent { get; set; }
    }
}
