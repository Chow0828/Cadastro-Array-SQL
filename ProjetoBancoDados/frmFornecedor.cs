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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }
        private void Habilita()
        {
            cd_fornecedorTextBox.Enabled = true;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nr_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            cd_CEPTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_telefoneTextBox.Enabled = true;
            cd_CPFTextBox.Enabled = true;
            cd_RGTextBox.Enabled = true;
            cd_CNPJTextBox.Enabled = true;
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
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nr_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            cd_CEPTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_telefoneTextBox.Enabled = false;
            cd_CPFTextBox.Enabled = false;
            cd_RGTextBox.Enabled = false;
            cd_CNPJTextBox.Enabled = false;
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
        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            this.tbfornecedorTableAdapter.Fill(this.cadastrosDataSet.tbfornecedor);
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbfornecedorbindingSource2.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbfornecedorbindingSource2.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbfornecedorbindingSource2.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbfornecedorbindingSource2.RemoveCurrent();
            //tbfornecedorbindingSource2.Update(cadastrosDataSet.tbfornecedor);
        }

        private void tbfornecedorbindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool validation = true;
            int count = 0, dig;
            count += int.Parse(cd_CPFTextBox.Text.Substring(10, 1)) * 2;
            count += int.Parse(cd_CPFTextBox.Text.Substring(9, 1)) * 3;
            count += int.Parse(cd_CPFTextBox.Text.Substring(8, 1)) * 4;
            count += int.Parse(cd_CPFTextBox.Text.Substring(7, 1)) * 5;
            count += int.Parse(cd_CPFTextBox.Text.Substring(6, 1)) * 6;
            count += int.Parse(cd_CPFTextBox.Text.Substring(5, 1)) * 7;
            count += int.Parse(cd_CPFTextBox.Text.Substring(4, 1)) * 8;
            count += int.Parse(cd_CPFTextBox.Text.Substring(8, 1)) * 9;
            count += int.Parse(cd_CPFTextBox.Text.Substring(1, 1)) * 10;
            dig = count % 11;
            if (dig < 2)
            {
                dig = 0;
            }
            else
            {
                dig = 11 - dig;
            }
            if (int.Parse(cd_CPFTextBox.Text.Substring(12, 1)) == dig)
            {
                count += int.Parse(cd_CPFTextBox.Text.Substring(12, 1)) * 2;
                count += int.Parse(cd_CPFTextBox.Text.Substring(10, 1)) * 3;
                count += int.Parse(cd_CPFTextBox.Text.Substring(9, 1)) * 4;
                count += int.Parse(cd_CPFTextBox.Text.Substring(8, 1)) * 5;
                count += int.Parse(cd_CPFTextBox.Text.Substring(6, 1)) * 6;
                count += int.Parse(cd_CPFTextBox.Text.Substring(5, 1)) * 7;
                count += int.Parse(cd_CPFTextBox.Text.Substring(4, 1)) * 8;
                count += int.Parse(cd_CPFTextBox.Text.Substring(2, 1)) * 9;
                count += int.Parse(cd_CPFTextBox.Text.Substring(1, 1)) * 10;
                count += int.Parse(cd_CPFTextBox.Text.Substring(0, 1)) * 11;
                dig = count % 11;
                if (dig < 2)
                {
                    dig = 0;
                }
                else
                {
                    dig = 11 - dig;
                }
                if (int.Parse(cd_CPFTextBox.Text.Substring(13, 1)) != dig)
                {
                    MessageBox.Show("CPF Inválido!");
                    cd_CPFTextBox.Focus();
                    validation = false;
                }
            }
            else
            {
                MessageBox.Show("CPF Inválido!");
                cd_CPFTextBox.Focus();
            }
            if (validation)
            {
                Validate();
                tbfornecedorbindingSource2.EndEdit();
                tbfornecedorTableAdapter.Update(cadastrosDataSet.tbfornecedor);
                Desabilita();
                tbfornecedorbindingSource2.RemoveCurrent();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }
    }
}
