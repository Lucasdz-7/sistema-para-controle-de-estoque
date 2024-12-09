namespace WindowsFormsApplication1
{
    partial class frmCadProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtQtd_Estoq = new System.Windows.Forms.TextBox();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.txtLocacao = new System.Windows.Forms.TextBox();
            this.txtEstoq_Min = new System.Windows.Forms.TextBox();
            this.txtPrcCusto = new System.Windows.Forms.TextBox();
            this.txtMarg_Lucro = new System.Windows.Forms.TextBox();
            this.txtPrcVenda = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatuslblmsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desc. Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quant. Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Locação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estoque Minimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Preço Custo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marg Lucro (%)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Preço Venda";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(47, 186);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 26);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(286, 186);
            this.txtDescricao.MaxLength = 30;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(480, 26);
            this.txtDescricao.TabIndex = 10;
            // 
            // txtQtd_Estoq
            // 
            this.txtQtd_Estoq.Enabled = false;
            this.txtQtd_Estoq.Location = new System.Drawing.Point(47, 294);
            this.txtQtd_Estoq.MaxLength = 7;
            this.txtQtd_Estoq.Name = "txtQtd_Estoq";
            this.txtQtd_Estoq.Size = new System.Drawing.Size(154, 26);
            this.txtQtd_Estoq.TabIndex = 11;
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.Enabled = false;
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(260, 294);
            this.cmbUnidade.MaxLength = 2;
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(69, 28);
            this.cmbUnidade.TabIndex = 12;
            // 
            // txtLocacao
            // 
            this.txtLocacao.Enabled = false;
            this.txtLocacao.Location = new System.Drawing.Point(367, 296);
            this.txtLocacao.MaxLength = 3;
            this.txtLocacao.Name = "txtLocacao";
            this.txtLocacao.Size = new System.Drawing.Size(100, 26);
            this.txtLocacao.TabIndex = 13;
            // 
            // txtEstoq_Min
            // 
            this.txtEstoq_Min.Enabled = false;
            this.txtEstoq_Min.Location = new System.Drawing.Point(524, 294);
            this.txtEstoq_Min.MaxLength = 7;
            this.txtEstoq_Min.Name = "txtEstoq_Min";
            this.txtEstoq_Min.Size = new System.Drawing.Size(242, 26);
            this.txtEstoq_Min.TabIndex = 14;
            // 
            // txtPrcCusto
            // 
            this.txtPrcCusto.Enabled = false;
            this.txtPrcCusto.Location = new System.Drawing.Point(47, 413);
            this.txtPrcCusto.MaxLength = 8;
            this.txtPrcCusto.Name = "txtPrcCusto";
            this.txtPrcCusto.Size = new System.Drawing.Size(154, 26);
            this.txtPrcCusto.TabIndex = 15;
            // 
            // txtMarg_Lucro
            // 
            this.txtMarg_Lucro.Enabled = false;
            this.txtMarg_Lucro.Location = new System.Drawing.Point(260, 413);
            this.txtMarg_Lucro.MaxLength = 6;
            this.txtMarg_Lucro.Name = "txtMarg_Lucro";
            this.txtMarg_Lucro.Size = new System.Drawing.Size(174, 26);
            this.txtMarg_Lucro.TabIndex = 16;
            this.txtMarg_Lucro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarg_Lucro_KeyDown);
            // 
            // txtPrcVenda
            // 
            this.txtPrcVenda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrcVenda.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrcVenda.ForeColor = System.Drawing.Color.Red;
            this.txtPrcVenda.Location = new System.Drawing.Point(515, 413);
            this.txtPrcVenda.Name = "txtPrcVenda";
            this.txtPrcVenda.ReadOnly = true;
            this.txtPrcVenda.Size = new System.Drawing.Size(251, 47);
            this.txtPrcVenda.TabIndex = 17;
            this.txtPrcVenda.Text = "0.00";
            this.txtPrcVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(75, 538);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 73);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(424, 538);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(111, 73);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(569, 538);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 73);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(244, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 36);
            this.label10.TabIndex = 21;
            this.label10.Text = "Produtos - Cadastrar";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatuslblmsg});
            this.statusStrip.Location = new System.Drawing.Point(0, 669);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(808, 30);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(110, 25);
            this.toolStripStatusLabel.Text = "Mensagem:";
            // 
            // toolStripStatuslblmsg
            // 
            this.toolStripStatuslblmsg.Name = "toolStripStatuslblmsg";
            this.toolStripStatuslblmsg.Size = new System.Drawing.Size(300, 25);
            this.toolStripStatuslblmsg.Text = "Informe o Cód. do produto <enter>";
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 699);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPrcVenda);
            this.Controls.Add(this.txtMarg_Lucro);
            this.Controls.Add(this.txtPrcCusto);
            this.Controls.Add(this.txtEstoq_Min);
            this.Controls.Add(this.txtLocacao);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.txtQtd_Estoq);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Imports - Cadastro Produtos";
            this.Activated += new System.EventHandler(this.frmCadProduto_Activated);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtQtd_Estoq;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.TextBox txtLocacao;
        private System.Windows.Forms.TextBox txtEstoq_Min;
        private System.Windows.Forms.TextBox txtPrcCusto;
        private System.Windows.Forms.TextBox txtMarg_Lucro;
        private System.Windows.Forms.TextBox txtPrcVenda;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslblmsg;
    }
}