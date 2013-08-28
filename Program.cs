using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoTest.XpathBuilder
{
    public static class Program
    {
        
        public static XpathBuilder builder;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            builder = new XpathBuilder();
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
