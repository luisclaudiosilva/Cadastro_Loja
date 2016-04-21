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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            idTextBox.Enabled = true;
            nomeTextBox.Enabled = true;

        }

        private void cadastrarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastrarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Cadastrar' table. You can move, or remove it, as needed.
            this.cadastrarTableAdapter.Fill(this.dataSet1.Cadastrar);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
