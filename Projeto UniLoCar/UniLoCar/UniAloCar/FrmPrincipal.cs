using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniAloCar
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clintesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmClinete = new FrmCadastroCliente();
            frmClinete.MdiParent = this;
            frmClinete.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
