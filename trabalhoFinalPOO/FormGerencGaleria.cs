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
using static trabalhoFinalPOO.Utilitarios;

namespace trabalhoFinalPOO
{
    public partial class FormGerencGaleria : Form
    {
        NpgsqlConnection conex = ConexaoBd();
        
        void UpdtCbGerencGaleria()
        {
            cbGerencGaleria.Items.Clear();

            conex.Open();

            using (var cmd = new NpgsqlCommand("SELECT nome_img FROM galeria", conex))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                    cbGerencGaleria.Items.Add(leitor.GetString(0));
            }

            cbGerencGaleria.SelectedIndex = 0;

            conex.Close();
        }

        public FormGerencGaleria()
        {
            InitializeComponent();

            lvProdutos.Columns.Add("ID produto", 80).TextAlign = HorizontalAlignment.Center;
            lvProdutos.Columns.Add("Nome produto", 300).TextAlign = HorizontalAlignment.Center;
            lvProdutos.View = View.Details;

            UpdtCbGerencGaleria();

            string popular = "SELECT id_produto, nome_produto FROM produtos";

            conex.Open();
            using(var cmd = new NpgsqlCommand(popular, conex))
            using(var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    string[] output = new string[2];
                    output[0] = Convert.ToString(leitor.GetInt32(0));
                    output[1] = Convert.ToString(leitor.GetString(1));

                    lvProdutos.Items.Add(new ListViewItem(output));
                }
            }

            conex.Close();
        }

        private void btnExcluirGaleria_Click(object sender, EventArgs e)
        {
            conex.Open();

            string selected = cbGerencGaleria.SelectedItem.ToString();

            string delete = $"DELETE FROM galeria WHERE nome_img = '{selected}'";

            using (var cmd = new NpgsqlCommand(delete, conex))
            {
                int res = cmd.ExecuteNonQuery();
                if (res == 0) mbShowErro("O item não existe na galeria", "Erro");
                else mbShowSucesso("O item foi excluído com sucesso");
            }

            conex.Close();

            UpdtCbGerencGaleria();
        }

        private void btnAddGaleria_Click(object sender, EventArgs e)
        {
            int idProd =  Convert.ToInt32(tbIdProdutoGerencGaleria.Text);
            string nomeProd = "";

            OpenFileDialog procurar = new OpenFileDialog();
            procurar.Filter = "Arquivos de imagem (*.jpg)|*.jpg";
            procurar.ShowDialog();

            string arqSelecionado = procurar.FileName;

            conex.Open();

            // buscar o nome do produto
            string busca = $"SELECT nome_produto FROM produtos WHERE id_produto = {idProd}";
            using(var cmd = new NpgsqlCommand(busca, conex))
            using(var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read()) 
                    nomeProd = leitor.GetString(0);
            }

            // inserir o produto
            string inserir = $"INSERT INTO galeria VALUES({idProd}, '{nomeProd}', '{arqSelecionado}')";
            using(var cmd = new NpgsqlCommand(inserir, conex))
            {
                int res = cmd.ExecuteNonQuery();
                if (res == -1) mbShowErro("O item não pôde ser adicionado", "Erro");
                else mbShowSucesso("Item adicionado com sucesso!");
            }

            conex.Close();

            UpdtCbGerencGaleria();
        }
    }
}
