using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDesign
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnMenuPartidas_Click(object sender, EventArgs e)
        {
            tbcInferfazInicio.SelectTab(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbcInferfazInicio.SelectTab(1);
        }
    }
}
