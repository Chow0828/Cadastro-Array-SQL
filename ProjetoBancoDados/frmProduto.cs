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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        private void Habilita()
        {
            cd_produtoTextBox.Enabled = true;
            nm_produtoTextBox.Enabled = true;
            nm_categoriaTextBox.Enabled = true;
            qt_produtoTextBox.Enabled = true;
            vl_custoTextBox.Enabled = true;
            vl_vendaTextBox.Enabled = true;     
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSalvar.Enabled = true;

        }

        private void Desabilita()
        {
            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = false;
            nm_categoriaTextBox.Enabled = false;
            qt_produtoTextBox.Enabled = false;
            vl_custoTextBox.Enabled = false;
            vl_vendaTextBox.Enabled = false;    
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbprodutobindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbprodutobindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbprodutobindingSource.AddNew();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbprodutobindingSource.RemoveCurrent();
            tbprodutoTableAdapter.Update(cadastrosDataSet.tbproduto);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbprodutobindingSource.EndEdit();
            tbprodutoTableAdapter.Update(cadastrosDataSet.tbproduto);
            Desabilita();
            tbprodutobindingSource.RemoveCurrent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbprodutobindingSource.CancelEdit();
            Desabilita();
        }
    }
}
