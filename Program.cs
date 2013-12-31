using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ProtoTest.Specter
{
    public static class Program
    {
        public static Specter builder;
        private static BackgroundWorker worker;
        public static void StartTimer()
        {
            Timer t = new Timer();
            t.Tick += delegate
            {
                builder.UpdateElement();
                t.Interval = Specter.refreshMs;
            };
            t.Start();

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            builder = new Specter();
            builder.FormClosed += builder_FormClosed;
            StartTimer();
            Application.Run(builder);
            worker.RunWorkerAsync();
        }

        static void builder_FormClosed(object sender, FormClosedEventArgs e)
        {
            builder.driver.Close();
        }

        static void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                builder.UpdateElement();
                Thread.Sleep(2000);
            }
        }

        public static void Error(string message)
        {
            builder.Error(message);
        }
        public static void Log(string message)
        {
            builder.Log(message);
        }
    }
}
