using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProtoTest.XpathBuilder;

namespace ProtoTest.Specter
{
    public static class Program
    {
        public static Specter specter;
        public static List<GolemElementBuilder> elements;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            specter = new Specter();
            elements = new List<GolemElementBuilder>();
            Application.Run(specter);
        }

        public static void Error(string message)
        {
            specter.Error(message);
        }

        public static void Log(string message)
        {
            specter.Log(message);
        }
    }
}