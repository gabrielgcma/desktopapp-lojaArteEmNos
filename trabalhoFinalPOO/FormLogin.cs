using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static trabalhoFinalPOO.Utilitarios;

namespace trabalhoFinalPOO
{
    public partial class FormLogin : Form
    {
        DadosRunTime dadosrt = new DadosRunTime();

        NpgsqlConnection conex = Utilitarios.ConexaoBd();

        public FormLogin(DadosRunTime _dadosrt)
        {
            InitializeComponent();
            dadosrt = _dadosrt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (tbCadastroSenha.Text == tbCadastroSenhaDnv.Text)
            {
                conex.Open();

                // Cadastrar:
                using (var comando = new NpgsqlCommand("INSERT INTO clientes VALUES (DEFAULT, @username, @senha)", conex))
                {
                    comando.Parameters.AddWithValue("username", tbCadastroUsername.Text);
                    comando.Parameters.AddWithValue("senha", tbCadastroSenha.Text);

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Usuário cadastrado com sucesso. Faça login para usar o app.", 
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                conex.Close();
            }
            else MessageBox.Show("Senhas não conferem! Tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool userExiste = false;

            conex.Open();

            using (var cmd = new NpgsqlCommand("SELECT clienteid, username, senha FROM clientes", conex))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    if ((leitor.GetString(1) == tbJaClienteUser.Text) && (leitor.GetString(2) == tbJaClienteSenha.Text))
                    {
                        userExiste = true;
                        dadosrt.Logado = true;
                        if (tbJaClienteUser.Text == "admin") dadosrt.AdminLogado = true;
                        dadosrt.UsernameLogado = tbJaClienteUser.Text;
                        dadosrt.Idclientelogado = leitor.GetInt32(0);
                        break;
                    }
                    else if ((leitor.GetString(1) == tbJaClienteUser.Text) && (leitor.GetString(2) != tbJaClienteSenha.Text))
                    {
                        userExiste = true;
                        mbShowErro("Senha incorreta", "Login");
                        break;
                    }
                    else if (leitor.GetString(1) != tbJaClienteUser.Text)
                    {
                        userExiste = false;
                    }
                }

                conex.Close();
            }

            if (!userExiste)
            {
                mbShowErro("Usuário não existe", "Login");
                dadosrt.Logado = false;
            }

            if (dadosrt.Logado)
            {
                this.Close();
            }
        }
    }
}
