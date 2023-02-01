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
    public partial class FormGerencProduto : Form
    {
        NpgsqlConnection conex = ConexaoBd();

        // Atualiza os campos baseado em uma coluna do produto. 0 = DESC, 1 = ASC
        void UpdtLvProds(string coluna, int sort)
        {
            string ordem = "";
            if (sort == 1) ordem = "ASC";
            else ordem = "DESC";

            lvGcProdutos.Items.Clear();

            conex.Open();

            string popular = $"SELECT * FROM produtos ORDER BY {coluna} {ordem}";

            using (var cmd = new NpgsqlCommand(popular, conex))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    string[] output = new string[6];
                    output[0] = Convert.ToString(leitor.GetInt32(0));
                    output[1] = Convert.ToString(leitor.GetString(1));
                    output[2] = Convert.ToString(leitor.GetString(2));
                    output[3] = Convert.ToString(leitor.GetInt32(3));
                    output[4] = Convert.ToString(leitor.GetInt32(4));
                    output[5] = Convert.ToString(leitor.GetInt32(5));

                    lvGcProdutos.Items.Add(new ListViewItem(output));
                }
            }

            conex.Close();
        }

        public FormGerencProduto()
        {
            InitializeComponent();

            cbSort.SelectedIndex = 0;

            lvGcProdutos.Columns.Add("ID produto", 40).TextAlign = HorizontalAlignment.Center;
            lvGcProdutos.Columns.Add("Nome produto", 200).TextAlign = HorizontalAlignment.Center;
            lvGcProdutos.Columns.Add("Descrição", 500).TextAlign = HorizontalAlignment.Center;
            lvGcProdutos.Columns.Add("Preço", 50).TextAlign = HorizontalAlignment.Center;
            lvGcProdutos.Columns.Add("Em estoque", 80).TextAlign = HorizontalAlignment.Center;
            lvGcProdutos.Columns.Add("Pedidos", 80).TextAlign = HorizontalAlignment.Center;
            lvGcProdutos.View = View.Details;
        }

        private void btnDelProd_Click(object sender, EventArgs e)
        {
            int idProd = Convert.ToInt32(tbIdProdDel.Text);

            string del = $"DELETE FROM produtos WHERE id_produto = {idProd}";

            conex.Open();

            using(var cmd = new NpgsqlCommand(del, conex))
            {
                int res = cmd.ExecuteNonQuery();
                if (res > 0) mbShowSucesso("Item excluído com sucesso");
                else mbShowErro("Item não pode ser excluído. Confira o ID de produto.", "Erro");
            }

            conex.Close();

            UpdtLvProds("id_produto", 1);
        }

        private void btnDellAll_Click(object sender, EventArgs e)
        {
            conex.Open();

            string del = "DELETE FROM produtos";

            using(var cmd = new NpgsqlCommand(del, conex))
            {
                int res = cmd.ExecuteNonQuery();
                if (res > 0) mbShowSucesso("Todos os dados foram excluídos com sucesso");
                else mbShowErro("Os dados não puderam ser excluídos", "Erro");
            }

            conex.Close();

            UpdtLvProds("id_produto", 1);
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            string nomeProd = tbNomeAddProd.Text;
            string descProd = tbDescAddProd.Text;
            int precoProd = Convert.ToInt32(tbPrecoAddProd.Text);
            int qtdProd = Convert.ToInt32(tbQtdAddProd.Text);

            string insert = $"INSERT INTO produtos VALUES(DEFAULT, '{nomeProd}', '{descProd}', {precoProd}, {qtdProd}, 0)";

            conex.Open();

            using (var cmd = new NpgsqlCommand(insert, conex))
            {
                int res = cmd.ExecuteNonQuery();
                if (res > 0) mbShowSucesso("Produto adicionado com sucesso!");
                else mbShowErro("Não foi possível adicionar o produto. Cheque os campos novamente.", "Erro");
            }            

            conex.Close();

            UpdtLvProds("id_produto", 1);
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            int idProd = 0, qtdProd = 0, precoProd = 0;
            string nomeProd = "", descProd = "";

            if (tbIdProdUpdt.Text == "")
            {
                mbShowErro("Digite o ID do produto", "Erro");
                return;
            }

            idProd = Convert.ToInt32(tbIdProdUpdt.Text);
            if (tbNomeProdUpdt.Text != "") nomeProd = tbNomeProdUpdt.Text;
            if (tbDescProdUpdt.Text != "") descProd = tbDescProdUpdt.Text;
            if (tbPrecoUpdt.Text != "") precoProd = Convert.ToInt32(tbPrecoUpdt.Text);
            if (tbQtdUpdt.Text != "") qtdProd = Convert.ToInt32(tbQtdUpdt.Text);

            string updt;

            // Mudar só o nome:
            if (nomeProd != "" && descProd == "" && precoProd == 0 && qtdProd == 0)
            {
                conex.Open();

                updt = $"UPDATE produtos SET nome_produto = '{nomeProd}' WHERE id_produto = {idProd}";

                using (var cmd = new NpgsqlCommand(updt, conex))
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0) mbShowSucesso("Item atualizado com sucesso.");
                    else mbShowErro("Não foi possível atualizar o item. Confira o ID de produto.", "Erro");
                    conex.Close();
                }

                UpdtLvProds("id_produto", 1);
            }

            // Mudar só a descrição:
            if (nomeProd == "" && descProd != "" && precoProd == 0 && qtdProd == 0)
            {
                conex.Open();

                updt = $"UPDATE produtos SET descricao = '{descProd}' WHERE id_produto = {idProd}";

                using (var cmd = new NpgsqlCommand(updt, conex))
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0) mbShowSucesso("Item atualizado com sucesso.");
                    else mbShowErro("Não foi possível atualizar o item. Confira o ID de produto.", "Erro");
                    conex.Close();
                }

                UpdtLvProds("id_produto", 1);
            }

            // Mudar só o preço:
            if (nomeProd == "" && descProd == "" && precoProd != 0 && qtdProd == 0)
            {
                conex.Open();

                updt = $"UPDATE produtos SET preco = {precoProd} WHERE id_produto = {idProd}";

                using (var cmd = new NpgsqlCommand(updt, conex))
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0) mbShowSucesso("Item atualizado com sucesso.");
                    else mbShowErro("Não foi possível atualizar o item. Confira o ID de produto.", "Erro");
                    conex.Close();
                }

                UpdtLvProds("id_produto", 1);
            }

            // Mudar só a quantidade:
            if (nomeProd == "" && descProd == "" && precoProd == 0 && qtdProd != 0)
            {
                conex.Open();

                updt = $"UPDATE produtos SET qtd_estoque = {qtdProd} WHERE id_produto = {idProd}";

                using (var cmd = new NpgsqlCommand(updt, conex))
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0) mbShowSucesso("Item atualizado com sucesso.");
                    else mbShowErro("Não foi possível atualizar o item. Confira o ID de produto.", "Erro");
                    conex.Close();
                }

                UpdtLvProds("id_produto", 1);
            }

            // Mudar nome e descrição
            if (nomeProd != "" && descProd != "" && precoProd == 0 && qtdProd == 0)
            {
                conex.Open();

                updt = $"UPDATE produtos SET nome_produto = '{nomeProd}', descricao = '{descProd}' WHERE id_produto = {idProd}";

                using (var cmd = new NpgsqlCommand(updt, conex))
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0) mbShowSucesso("Item atualizado com sucesso.");
                    else mbShowErro("Não foi possível atualizar o item. Confira o ID de produto.", "Erro");
                    conex.Close();
                }

                UpdtLvProds("id_produto", 1);
            }

            // Mudar preço e quantidade:
            if (nomeProd == "" && descProd == "" && precoProd != 0 && qtdProd != 0)
            {
                conex.Open();

                updt = $"UPDATE produtos SET preco = {precoProd}, qtd_estoque = {qtdProd} WHERE id_produto = {idProd}";

                using (var cmd = new NpgsqlCommand(updt, conex))
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0) mbShowSucesso("Item atualizado com sucesso.");
                    else mbShowErro("Não foi possível atualizar o item. Confira o ID de produto.", "Erro");
                    conex.Close();
                }

                UpdtLvProds("id_produto", 1);
            }

            // Mudar descrição, preço e quantidade:
            if (nomeProd == "" && descProd != "" && precoProd != 0 && qtdProd != 0)
            {
                conex.Open();

                updt = $"UPDATE produtos SET descricao = '{descProd}', preco = {precoProd}, qtd_estoque = {qtdProd} WHERE id_produto = {idProd}";

                using (var cmd = new NpgsqlCommand(updt, conex))
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0) mbShowSucesso("Item atualizado com sucesso.");
                    else mbShowErro("Não foi possível atualizar o item. Confira o ID de produto.", "Erro");
                    conex.Close();
                }

                UpdtLvProds("id_produto", 1);
            }

            // Mudar descrição e quantidade:
            if (nomeProd == "" && descProd != "" && precoProd == 0 && qtdProd != 0)
            {
                conex.Open();

                updt = $"UPDATE produtos SET descricao = '{descProd}', qtd_estoque = {qtdProd} WHERE id_produto = {idProd}";

                using (var cmd = new NpgsqlCommand(updt, conex))
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0) mbShowSucesso("Item atualizado com sucesso.");
                    else mbShowErro("Não foi possível atualizar o item. Confira o ID de produto.", "Erro");
                    conex.Close();
                }

                UpdtLvProds("id_produto", 1);
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0) UpdtLvProds("id_produto", 1);

            if (cbSort.SelectedIndex == 1) UpdtLvProds("id_produto", 0);

            if (cbSort.SelectedIndex == 2) UpdtLvProds("preco", 1);

            if (cbSort.SelectedIndex == 3) UpdtLvProds("preco", 0);

            if (cbSort.SelectedIndex == 4) UpdtLvProds("qtd_estoque", 1);

            if (cbSort.SelectedIndex == 5) UpdtLvProds("qtd_estoque", 0);

            if (cbSort.SelectedIndex == 6) UpdtLvProds("qtd_pedidos", 0);
        }
    }
}
