using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace QQRobot.MahuaUI
{
    class Setting : Newbe.Mahua.IMahuaAdministration
    {
        public void Show(ILifetimeScope lifetimeScope)
        {
            Config config = new Config();
            config.Show();
        }
    }
}
