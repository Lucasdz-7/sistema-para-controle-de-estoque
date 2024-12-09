using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //<--- Adicionar o Mysql

namespace WindowsFormsApplication1
{
    public partial class frmTelaCadastro : Form
    {

        // Variaveis de controle da conexão
        MySqlConnection Conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public frmTelaCadastro()
        {
            InitializeComponent();

            //Criando a string de conexão

            Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=carimport;User=root");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = false;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = false;
            txtUsuario.Focus();
            txtNomeUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
        }


        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    strSQL = "SELECT * FROM tb_login WHERE log_usuario = @parUsuario";
                    comando = new MySqlCommand(strSQL, Conexao);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@parUsuario", txtUsuario.Text);
                    Conexao.Open();
                    dr = comando.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        txtUsuario.Enabled = true;
                        txtNomeUsuario.Enabled = true;
                        txtSenha.Enabled = true;
                        btnCadastrar.Enabled = true;
                        toolStripStatuslblmsg.Text = "Insira seus dados para criar o cadastro";
                    }
                    else {
                        while (dr.Read())
                        {
                            txtNomeUsuario.Text = Convert.ToString(dr["log_nome"]);
                            txtSenha.Text = Convert.ToString(dr["log_senha"]);
                            txtUsuario.Enabled = true;
                            txtSenha.Enabled = true;
                            txtNomeUsuario.Enabled = true;
                        }
                        toolStripStatuslblmsg.Text = "Usuário já cadastrado";
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "INSERT INTO tb_login (log_usuario, log_senha, log_nome, log_ult_atualizacao) values(@parUsuario, @parSenha, @parNomeUsuario, CURRENT_TIMESTAMP)";
                comando = new MySqlCommand(strSQL, Conexao);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@parUsuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@parSenha", txtSenha.Text);
                comando.Parameters.AddWithValue("@parNomeUsuario", txtNomeUsuario.Text);
                Conexao.Open();
                comando.ExecuteNonQuery();
                toolStripStatuslblmsg.Text = "Cadastro efetuado com sucesso";

                txtNomeUsuario.ReadOnly = true;
                txtSenha.ReadOnly = true;
                btnCadastrar.Enabled = false;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro -->" + erro.Message, "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                MessageBox.Show("Usuário cadastrado!");
            }

        }
    }
}
