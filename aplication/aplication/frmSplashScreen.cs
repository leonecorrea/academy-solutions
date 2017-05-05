using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySolution
{
    public partial class frmSplashScreen : MetroFramework.Forms.MetroForm
    {
        public frmSplashScreen()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();//Inicializado
            InitializeComponent();
            int j = 0;
            for (int i = 0; i <= 5; i++)
            {
                Thread.Sleep(1000);//Completo
                j++;
            }
            t.Abort();
        }

        public void Loading()
        {
            frmSplashScreen frm = new frmSplashScreen();
            Application.Run(frm);
        }
    }
}
