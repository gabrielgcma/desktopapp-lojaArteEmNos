using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoFinalPOO
{
    public partial class FormPedidos : Form
    {
        NpgsqlConnection conex = Utilitarios.ConexaoBd();

        public FormPedidos(DadosRunTime dadosrt)
        {
            int idcliente = dadosrt.Idclientelogado;

            InitializeComponent();

            lbBvPedidos.Text = $"Olá {dadosrt.UsernameLogado}, estes são os seus pedidos:";

            lvPedidos.Columns.Add("ID pedido", 80).TextAlign = HorizontalAlignment.Center;
            lvPedidos.Columns.Add("Produto", 275).TextAlign = HorizontalAlignment.Center;
            lvPedidos.Columns.Add("Quantidade", 80).TextAlign = HorizontalAlignment.Center;
            lvPedidos.View = View.Details;

            conex.Open();

            string query = "SELECT pedidos.id_pedido, produtos.nome_produto, pedidos.qtd " +
                            "FROM pedidos " +
                            "INNER JOIN produtos ON pedidos.id_produtopedido=produtos.id_produto " +
                            $"WHERE pedidos.idcliente = {Convert.ToString(idcliente)};";
            using (var cmd = new NpgsqlCommand(query, conex))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    string[] output = new string[3];
                    output[0] = Convert.ToString(leitor.GetInt32(0));
                    output[1] = Convert.ToString(leitor.GetString(1));
                    output[2] = Convert.ToString(leitor.GetInt32(2));

                    lvPedidos.Items.Add(new ListViewItem(output));
                }
            }

            conex.Close();
        }
    }
}
