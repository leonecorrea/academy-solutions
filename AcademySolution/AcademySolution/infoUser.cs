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
    public partial class infoUser : MetroFramework.Forms.MetroForm
    {
        public infoUser()
        {
            InitializeComponent();
        }

        private void btnCloseInfoUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
