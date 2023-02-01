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
    public partial class FormGaleria : Form
    {
        NpgsqlConnection conex = Utilitarios.ConexaoBd();

        public FormGaleria()
        {
            InitializeComponent();

            conex.Open();

            using (var cmd = new NpgsqlCommand("SELECT nome_img FROM galeria", conex))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                    cbGaleria.Items.Add(leitor.GetString(0));
            }

            conex.Close();

            cbGaleria.SelectedIndex = 0;
        }

        private void cbGaleria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt_selec = cbGaleria.SelectedItem.ToString();

            string query = $"SELECT img_path FROM galeria WHERE nome_img = '{txt_selec}'";

            conex.Open();

            using (var cmd = new NpgsqlCommand(query, conex))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                    pictureBox1.ImageLocation = leitor.GetString(0);
            }

            string queryInfos = $"SELECT preco, qtd_estoque FROM produtos WHERE nome_produto = '{txt_selec}'";
            using (var cmd = new NpgsqlCommand(queryInfos, conex))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    lbPrecoGaleria.Text = "R$ " + Convert.ToString(leitor.GetInt32(0));
                    lbQtdGaleria.Text = Convert.ToString(leitor.GetInt32(1));
                }
            }

            conex.Close();
        }

        
    }
}
