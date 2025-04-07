using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace App1403Service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();

        protected override void OnStart(string[] args)
        {
            
            timer.Interval = 10_000; //10sec
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            EventLog.WriteEntry("App1403Service Tick!");

            /*
             * For install
             * Developer Command Prompt for VS2022 - run as admin
             * cd folder bin
             * installutil <appname>
             */
        }

        protected override void OnStop()
        {
            timer.Stop();
        }
    }
}
