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
        public static Specter specter;
        private static BackgroundWorker worker;
        [STAThread]
        static void Main()
        {
            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            specter = new Specter();
            specter.FormClosed += SpecterFormClosed;
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();
            Application.Run(specter);
        }

        static void SpecterFormClosed(object sender, FormClosedEventArgs e)
        {
            worker.CancelAsync();
            specter.driver.Close();
        }

        static void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;

            while (!backgroundWorker.CancellationPending)
            {
                if (Specter.updateElement)
                {
                    specter.UpdateElement();
                    Thread.Sleep(Specter.refreshMs);
                }
            }
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
