using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LocadoraClassic.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void listaNegraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaGenero frmTelaGenero = new FrmTelaGenero();
            frmTelaGenero.MdiParent = this;
            frmTelaGenero.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaCategoria frmTelaCategoria = new FrmTelaCategoria();
            frmTelaCategoria.MdiParent = this;       
            frmTelaCategoria.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaFilme frmTelFilme = new FrmTelaFilme();
            frmTelFilme.MdiParent= this;
            frmTelFilme.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void realizarLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaLocacao frm = new FrmTelaLocacao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
