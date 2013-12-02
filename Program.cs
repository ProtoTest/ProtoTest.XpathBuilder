using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoTest.Specter
{
    public static class Program
    {
        public static XpathBuilder builder;

        public static void StartTimer()
        {
            Timer t = new Timer();
            t.Tick += delegate
            {
                builder.UpdatePanels();

            };
            t.Interval = 5000;
            t.Start();

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            builder = new XpathBuilder();
           // StartTimer();
            Application.Run(builder);
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
