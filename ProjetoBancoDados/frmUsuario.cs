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
    public partial class frmUsuario : Form
    {
        private void Habilita()
        {
            cd_usuarioTextBox.Enabled = true;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
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
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSalvar.Enabled = true;
        }


        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastrosDataSet.tbusuario' table. You can move, or remove it, as needed.
            this.tbusuarioTableAdapter.Fill(this.cadastrosDataSet.tbusuario);
            Desabilita();

        }

        /*
        private void tbusuarioBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tbusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastrosDataSet);

        }
        */
        private void cd_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void sg_nivelLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.RemoveCurrent();
            tbusuarioTableAdapter.Update(cadastrosDataSet.tbusuario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbusuarioBindingSource.EndEdit();
            tbusuarioTableAdapter.Update(cadastrosDataSet.tbusuario);
            Desabilita();
            tbusuarioBindingSource.RemoveCurrent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.CancelEdit();
            Desabilita();
        }
    }
}
