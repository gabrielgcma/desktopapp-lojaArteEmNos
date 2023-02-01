using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static trabalhoFinalPOO.Utilitarios;


namespace trabalhoFinalPOO
{
    public partial class FormFazerPedido : Form
    {
        NpgsqlConnection conex = Utilitarios.ConexaoBd();

        DadosRunTime dadosrt = new DadosRunTime();
        int id_cliente;

        public FormFazerPedido(DadosRunTime dadosrt)
        {
            InitializeComponent();

            id_cliente = dadosrt.Idclientelogado;

            conex.Open();

            using(var cmd = new NpgsqlCommand("SELECT nome_produto FROM produtos", conex))
            using(var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                    cbProduto.Items.Add(leitor.GetString(0));
            }

            conex.Close();

        }

        private void btnRegPedido_Click(object sender, EventArgs e)
        {
            if (nudQtd.Value <= 0) 
            {
                mbShowErro("Quantidade inválida", "Tente novamente");
                return;
            }

            int id_produto = 0;
            int qtd = Convert.ToInt32(nudQtd.Value);
            string nome_produto = cbProduto.SelectedItem.ToString();

            conex.Open();

            using (var cmd = new NpgsqlCommand("SELECT id_produto, nome_produto FROM produtos", conex))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                    if (Convert.ToString(leitor.GetString(1)) == nome_produto) id_produto = leitor.GetInt32(0);
            }

            using(var cmd = new NpgsqlCommand($"INSERT INTO pedidos VALUES (DEFAULT, {id_cliente}, {id_produto}, {qtd})", conex))
            {
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    mbShowSucesso("Pedido realizado com sucesso!\nVolte ao menu principal para visualizar o seu pedido");

                    string updtProd = $"UPDATE produtos SET qtd_pedidos = qtd_pedidos + {qtd} WHERE id_produto = {id_produto}";
                    
                    using(var cmd2 = new NpgsqlCommand(updtProd, conex))
                    {
                        cmd2.ExecuteNonQuery();
                    }
                }
                else mbShowErro("Não foi possível fazer o pedido, verifique os campos", "Erro");
            }
            conex.Close();
        }
    }
}
