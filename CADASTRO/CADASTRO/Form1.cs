using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADASTRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cADASTRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 Frm3 = new Form3();
            Frm3.Visible = true;
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Frm2 = new Form2();
            Frm2.Visible = true;
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
