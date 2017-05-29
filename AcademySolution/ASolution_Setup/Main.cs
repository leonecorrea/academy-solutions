using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASolution_Setup
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            var resp = f.ShowDialog();
            if (resp == DialogResult.Yes)
            {
                Form f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
}
