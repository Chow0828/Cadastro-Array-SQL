
namespace ProjetoBancoDados
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label cd_usuarioLabel;
            System.Windows.Forms.Label nm_usuarioLabel;
            System.Windows.Forms.Label sg_nivelLabel;
            System.Windows.Forms.Label nm_loginLabel;
            System.Windows.Forms.Label cd_senhaLabel;
            this.cadastrosDataSet = new ProjetoBancoDados.CadastrosDataSet();
            this.tbprodutobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.tbprodutoTableAdapter = new ProjetoBancoDados.CadastrosDataSetTableAdapters.tbprodutoTableAdapter();
            this.vl_vendaTextBox = new System.Windows.Forms.TextBox();
            this.cd_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nm_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nm_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.qt_produtoTextBox = new System.Windows.Forms.TextBox();
            this.vl_custoTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            cd_usuarioLabel = new System.Windows.Forms.Label();
            nm_usuarioLabel = new System.Windows.Forms.Label();
            sg_nivelLabel = new System.Windows.Forms.Label();
            nm_loginLabel = new System.Windows.Forms.Label();
            cd_senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutobindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastrosDataSet
            // 
            this.cadastrosDataSet.DataSetName = "CadastrosDataSet";
            this.cadastrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(795, 494);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 41);
            this.btnSair.TabIndex = 108;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(647, 494);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 41);
            this.btnImprimir.TabIndex = 107;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(491, 494);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(127, 41);
            this.btnPesquisar.TabIndex = 106;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(333, 494);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 41);
            this.btnCancelar.TabIndex = 105;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(189, 494);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(127, 41);
            this.btnSalvar.TabIndex = 104;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(722, 445);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(127, 41);
            this.btnExcluir.TabIndex = 103;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(570, 445);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(127, 41);
            this.btnAlterar.TabIndex = 102;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(411, 445);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(127, 41);
            this.btnNovo.TabIndex = 101;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(261, 445);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(127, 41);
            this.btnProximo.TabIndex = 100;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(123, 445);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(127, 41);
            this.btnAnterior.TabIndex = 99;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // tbprodutoTableAdapter
            // 
            this.tbprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // vl_vendaTextBox
            // 
            this.vl_vendaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_vendaTextBox.Location = new System.Drawing.Point(323, 320);
            this.vl_vendaTextBox.MaxLength = 2;
            this.vl_vendaTextBox.Name = "vl_vendaTextBox";
            this.vl_vendaTextBox.Size = new System.Drawing.Size(215, 26);
            this.vl_vendaTextBox.TabIndex = 122;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(206, 323);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 20);
            label2.TabIndex = 121;
            label2.Text = "Venda R$";
            // 
            // cd_produtoTextBox
            // 
            this.cd_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_produtoTextBox.Location = new System.Drawing.Point(323, 49);
            this.cd_produtoTextBox.MaxLength = 2;
            this.cd_produtoTextBox.Name = "cd_produtoTextBox";
            this.cd_produtoTextBox.Size = new System.Drawing.Size(73, 26);
            this.cd_produtoTextBox.TabIndex = 110;
            // 
            // nm_produtoTextBox
            // 
            this.nm_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_produtoTextBox.Location = new System.Drawing.Point(323, 107);
            this.nm_produtoTextBox.MaxLength = 40;
            this.nm_produtoTextBox.Name = "nm_produtoTextBox";
            this.nm_produtoTextBox.Size = new System.Drawing.Size(613, 26);
            this.nm_produtoTextBox.TabIndex = 112;
            // 
            // nm_categoriaTextBox
            // 
            this.nm_categoriaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_categoriaTextBox.Location = new System.Drawing.Point(323, 164);
            this.nm_categoriaTextBox.MaxLength = 50;
            this.nm_categoriaTextBox.Name = "nm_categoriaTextBox";
            this.nm_categoriaTextBox.Size = new System.Drawing.Size(609, 26);
            this.nm_categoriaTextBox.TabIndex = 114;
            // 
            // qt_produtoTextBox
            // 
            this.qt_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qt_produtoTextBox.Location = new System.Drawing.Point(323, 216);
            this.qt_produtoTextBox.MaxLength = 10;
            this.qt_produtoTextBox.Name = "qt_produtoTextBox";
            this.qt_produtoTextBox.Size = new System.Drawing.Size(107, 26);
            this.qt_produtoTextBox.TabIndex = 116;
            // 
            // vl_custoTextBox
            // 
            this.vl_custoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_custoTextBox.Location = new System.Drawing.Point(323, 272);
            this.vl_custoTextBox.MaxLength = 30;
            this.vl_custoTextBox.Name = "vl_custoTextBox";
            this.vl_custoTextBox.Size = new System.Drawing.Size(215, 26);
            this.vl_custoTextBox.TabIndex = 118;
            // 
            // cd_usuarioLabel
            // 
            cd_usuarioLabel.AutoSize = true;
            cd_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_usuarioLabel.Location = new System.Drawing.Point(206, 49);
            cd_usuarioLabel.Name = "cd_usuarioLabel";
            cd_usuarioLabel.Size = new System.Drawing.Size(59, 20);
            cd_usuarioLabel.TabIndex = 109;
            cd_usuarioLabel.Text = "Código";
            // 
            // nm_usuarioLabel
            // 
            nm_usuarioLabel.AutoSize = true;
            nm_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_usuarioLabel.Location = new System.Drawing.Point(206, 107);
            nm_usuarioLabel.Name = "nm_usuarioLabel";
            nm_usuarioLabel.Size = new System.Drawing.Size(51, 20);
            nm_usuarioLabel.TabIndex = 111;
            nm_usuarioLabel.Text = "Nome";
            // 
            // sg_nivelLabel
            // 
            sg_nivelLabel.AutoSize = true;
            sg_nivelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_nivelLabel.Location = new System.Drawing.Point(206, 164);
            sg_nivelLabel.Name = "sg_nivelLabel";
            sg_nivelLabel.Size = new System.Drawing.Size(78, 20);
            sg_nivelLabel.TabIndex = 113;
            sg_nivelLabel.Text = "Categoria";
            // 
            // nm_loginLabel
            // 
            nm_loginLabel.AutoSize = true;
            nm_loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_loginLabel.Location = new System.Drawing.Point(206, 216);
            nm_loginLabel.Name = "nm_loginLabel";
            nm_loginLabel.Size = new System.Drawing.Size(92, 20);
            nm_loginLabel.TabIndex = 115;
            nm_loginLabel.Text = "Quantidade";
            // 
            // cd_senhaLabel
            // 
            cd_senhaLabel.AutoSize = true;
            cd_senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_senhaLabel.Location = new System.Drawing.Point(206, 272);
            cd_senhaLabel.Name = "cd_senhaLabel";
            cd_senhaLabel.Size = new System.Drawing.Size(76, 20);
            cd_senhaLabel.TabIndex = 117;
            cd_senhaLabel.Text = "Custo R$";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(997, 614);
            this.ControlBox = false;
            this.Controls.Add(this.vl_vendaTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.cd_produtoTextBox);
            this.Controls.Add(this.nm_produtoTextBox);
            this.Controls.Add(this.nm_categoriaTextBox);
            this.Controls.Add(this.qt_produtoTextBox);
            this.Controls.Add(this.vl_custoTextBox);
            this.Controls.Add(cd_usuarioLabel);
            this.Controls.Add(nm_usuarioLabel);
            this.Controls.Add(sg_nivelLabel);
            this.Controls.Add(nm_loginLabel);
            this.Controls.Add(cd_senhaLabel);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Name = "frmProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutobindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastrosDataSet cadastrosDataSet;
        private CadastrosDataSetTableAdapters.tbprodutoTableAdapter tbprodutoTableAdapter;
        private System.Windows.Forms.BindingSource tbprodutobindingSource;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.TextBox vl_vendaTextBox;
        private System.Windows.Forms.TextBox cd_produtoTextBox;
        private System.Windows.Forms.TextBox nm_produtoTextBox;
        private System.Windows.Forms.TextBox nm_categoriaTextBox;
        private System.Windows.Forms.TextBox qt_produtoTextBox;
        private System.Windows.Forms.TextBox vl_custoTextBox;
    }
}