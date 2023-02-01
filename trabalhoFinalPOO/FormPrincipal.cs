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
    public partial class FormPrincipal : Form
    {
        DadosRunTime dadosrt = new DadosRunTime();

        public FormPrincipal()
        {
            InitializeComponent();

            FormLogin formLogin = new FormLogin(dadosrt);
            formLogin.ShowDialog();

            if (!dadosrt.Logado)
            {
                this.Close();
                Application.Exit();
            }

            if (!dadosrt.AdminLogado)
            {
                btnGerencGaleria.Visible = false;
                btnGerencProdutos.Visible = false;
                btnSair.Top = this.ClientSize.Height - 130;
            }

            lbBoasVindas.Text = $"Seja bem-vindo(a), {dadosrt.UsernameLogado}";
            lbBoasVindas.Left = (this.ClientSize.Width - lbBoasVindas.Width) / 2;

            btnFazerPedido.Left = (this.ClientSize.Width - btnFazerPedido.Width) / 2;
            btnVerPedidos.Left = (this.ClientSize.Width - btnVerPedidos.Width) / 2;
            btnGaleria.Left = (this.ClientSize.Width - btnGaleria.Width) / 2;
            btnSair.Left = (this.ClientSize.Width - btnSair.Width) / 2;
            btnGerencGaleria.Left = (this.ClientSize.Width - btnGerencGaleria.Width) / 2;
            btnGerencProdutos.Left = (this.ClientSize.Width - btnGerencProdutos.Width) / 2;
        }

        private void FormPrincipal_SizeChanged(object sender, EventArgs e)
        {
            lbBoasVindas.Left = (this.ClientSize.Width - lbBoasVindas.Width) / 2;
            btnFazerPedido.Left = (this.ClientSize.Width - btnFazerPedido.Width) / 2;
            btnVerPedidos.Left = (this.ClientSize.Width - btnVerPedidos.Width) / 2;
            btnGaleria.Left = (this.ClientSize.Width - btnGaleria.Width) / 2;
            btnSair.Left = (this.ClientSize.Width - btnSair.Width) / 2;
            btnGerencGaleria.Left = (this.ClientSize.Width - btnGerencGaleria.Width) / 2;
            btnGerencProdutos.Left = (this.ClientSize.Width - btnGerencProdutos.Width) / 2;
        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            FormFazerPedido janelaFazerPedido = new FormFazerPedido(dadosrt);
            janelaFazerPedido.ShowDialog();
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos janelaVisPedidos = new FormPedidos(dadosrt);
            janelaVisPedidos.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            FormGaleria galeria = new FormGaleria();
            galeria.ShowDialog();
        }

        private void btnGerencGaleria_Click(object sender, EventArgs e)
        {
            FormGerencGaleria gcGaleria = new FormGerencGaleria();
            gcGaleria.ShowDialog();
        }

        private void btnGerencProdutos_Click(object sender, EventArgs e)
        {
            FormGerencProduto gcProduto = new FormGerencProduto();  
            gcProduto.ShowDialog();
        }
    }
}
