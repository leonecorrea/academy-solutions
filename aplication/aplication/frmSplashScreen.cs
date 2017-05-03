using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySolution
{
    public partial class frmSplashScreen : MetroFramework.Forms.MetroForm
    {
        public frmSplashScreen()
        {
            InitializeComponent();

            int i = 0;

            for(int j = 0; j < 100; j--)
            {
                lblCountLoading.Text = $"{i++}%";
            }
        }
    }
}
