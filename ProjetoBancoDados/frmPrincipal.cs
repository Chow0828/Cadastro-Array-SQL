using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBancoDados
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
            //https://etecspgov.sharepoint.com/sites/Section_1410.A.-.I.408.266.20211/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2FSection%5F1410%2EA%2E%2D%2EI%2E408%2E266%2E20211%2FShared%20Documents%2FQuinzena%2012%2FRecordings%2FAula%2023%5F09%20%2D%20Projeto%20com%20banco%20de%20dados%2D20210923%5F134557%2DGrava%C3%A7%C3%A3o%20de%20Reuni%C3%A3o%2Emp4&parent=%2Fsites%2FSection%5F1410%2EA%2E%2D%2EI%2E408%2E266%2E20211%2FShared%20Documents%2FQuinzena%2012%2FRecordings
            // 1:39:00
        }

        private void frmUsuario(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor ff = new frmFornecedor();
            ff.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto fp = new frmProduto();
            fp.ShowDialog();
            
        }
    }
}
