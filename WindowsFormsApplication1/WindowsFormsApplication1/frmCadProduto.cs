using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 


namespace WindowsFormsApplication1
{
    public partial class frmCadProduto : Form
    {
        MySqlConnection Conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        // Variáveis de Trabalho Global
        decimal vPrcCusto = 0, vMarg_Lucro = 0, vPrcVenda = 0, vEstoq_Min = 0, vQtd_Estoq = 0;

        public frmCadProduto()
        {
            InitializeComponent();

            Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=carimports;User=root");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    strSQL = "SELECT * FROM tb_Produtos WHERE CodProd = @parCodigo";
                    comando = new MySqlCommand(strSQL, Conexao);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@parCodigo", txtCodigo.Text);
                    Conexao.Open();
                    dr = comando.ExecuteReader();

                    if (dr.HasRows)
                    {

                    }
                    else
                    {
                        txtDescricao.Enabled = true;
                        txtQtd_Estoq.Enabled = true;
                        cmbUnidade.Enabled = true;
                        txtLocacao.Enabled = true;
                        txtEstoq_Min.Enabled = true;
                        txtPrcCusto.Enabled = true;
                        txtMarg_Lucro.Enabled = true;

                        txtDescricao.Focus();
                        toolStripStatuslblmsg.Text = "Informe a descrição do produto!!";
                    }
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erros --->" + erro.Message, "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                finally
                {
                    MessageBox.Show("Conexão bem sucedida!");
                    Conexao.Close();
                    comando = null;
                }
            
                
            }
        }

        private void frmCadProduto_Activated(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void txtMarg_Lucro_KeyDown(object sender, KeyEventArgs e)
        {
             vPrcCusto = decimal.Parse(txtPrcCusto.Text);
            vMarg_Lucro = decimal.Parse(txtMarg_Lucro.Text);
            vPrcVenda = vPrcCusto * (vMarg_Lucro / 100);
        }
    }
}
