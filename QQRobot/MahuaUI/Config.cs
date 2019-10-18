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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = ConfigCache.configInfosBind;
        }

        private void addConfig_Click(object sender, EventArgs e)
        {
            AddConfig addConfig = new AddConfig(this,new ConfigInfo(),-1);
            addConfig.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                {
                DataGridViewColumn column = dataGridView.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn && column.Name == "edit")
                {
                    ConfigInfo configInfo = ConfigCache.configInfos[e.RowIndex];
                    AddConfig addConfig = new AddConfig(this, configInfo, e.RowIndex);
                    addConfig.Show();
                }else if (column is DataGridViewButtonColumn && column.Name == "delete")
                {
                    ConfigCache.configInfosBind.RemoveAt(e.RowIndex);
                    ConfigCache.saveConfigToFile();
                }
            }
        }
    }
}
