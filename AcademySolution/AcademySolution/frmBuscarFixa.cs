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
    public partial class frmSearchFicha : MetroFramework.Forms.MetroForm
    {
        public frmSearchFicha()
        {
            InitializeComponent();
        }

        private void frmSearchFicha_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbbParametro.Text = "";
        }
    }      
}
