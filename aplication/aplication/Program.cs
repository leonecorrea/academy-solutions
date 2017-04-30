using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplication
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            t.Abort();
        }

        private static void StartForm()
        {
            Application.Run(new SplashScreen());
        }
    }
}
