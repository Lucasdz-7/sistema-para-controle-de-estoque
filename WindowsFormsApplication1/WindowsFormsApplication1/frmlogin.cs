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
    public partial class frmlogin : Form
    {
        MySqlConnection Conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public frmlogin()
        {
            InitializeComponent();

            Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=carimport;User=root");

        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirma a saída da aplicação", "Mensagem", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }


        private void lblNovoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTelaCadastro tela_cadastro = new frmTelaCadastro();
            tela_cadastro.Show();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "SELECT log_senha FROM tb_login WHERE log_usuario = @parUsuario";
                comando = new MySqlCommand(strSQL, Conexao);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@parUsuario", txtUsuario.Text);
                Conexao.Open();
                comando.ExecuteScalar();
            }
            catch (MySqlException Erro)
            {
                MessageBox.Show("Erros --->" + Erro.Message, "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                if (comando.ExecuteScalar() == null)
                {
                    MessageBox.Show("Usúario não cadastradado !!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    if (Convert.ToString(comando.ExecuteScalar()) != txtSenha.Text)
                    {
                        MessageBox.Show("Senha incorreta !!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Focus();
                    }
                    else
                    {
                        this.Visible = false;
                        frmPincipal telaPrincipal = new frmPincipal();
                        telaPrincipal.Show();


                    }
                }
                Conexao.Close();
                comando = null;
            }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        }
    }

