using QQRobot.MahuaEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQRobot.MahuaUI
{
    public partial class AddConfig : Form
    {
        private Config config;
        private ConfigInfo configInfo;
        private int index;

        public AddConfig(Config config, ConfigInfo configInfo,int index)
        {
            this.config = config;
            this.configInfo = configInfo;
            this.index = index;
            InitializeComponent();
        }

        private void AddConfig_Load(object sender, EventArgs e)
        {
            
            if (!"".Equals(this.configInfo.groupId) && null != this.configInfo.groupId && this.configInfo.groupId.Length != 0)
            {
                this.groupId.Text = this.configInfo.groupId;
                this.replyContent.Text = this.configInfo.replyContent;
                this.startTime.Value = this.configInfo.startTime;
                this.endTime.Value = this.configInfo.endTime;
                this.msgLen.Text = this.configInfo.msgLen.ToString();
            }
        }


        private void saveConfig_Click(object sender, EventArgs e)
        {
            
            this.configInfo.groupId = this.groupId.Text;
            this.configInfo.replyContent = this.replyContent.Text;
            this.configInfo.startTime = this.startTime.Value;
            this.configInfo.endTime = this.endTime.Value;
            this.configInfo.msgLen = int.Parse(this.msgLen.Text);
            if ("".Equals(this.configInfo.groupId) || null == this.configInfo.groupId || this.configInfo.groupId.Length == 0)
            {
                MessageBox.Show("监控群号不能为空！");
                
            }else if(this.configInfo.msgLen <=0)
            {
                MessageBox.Show("监控消息长度不能为空且大于零！");
            }
            else if("".Equals(this.configInfo.replyContent) || null == this.configInfo.replyContent || this.configInfo.replyContent.Length == 0)
            {
                MessageBox.Show("回复内容不能为空！");

            }else
            {
                if (this.index >= 0)
                {
                    ConfigCache.configInfosBind.RemoveAt(index);
                    ConfigCache.configInfosBind.Insert(index, configInfo);
                }
                else
                {
                    ConfigCache.configInfosBind.Add(configInfo);
                }
                this.Close();
            }
            
        }
    }
}
