namespace trabalhoFinalPOO
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBoasVindas = new System.Windows.Forms.Label();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.btnGaleria = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerencProdutos = new System.Windows.Forms.Button();
            this.btnGerencGaleria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBoasVindas
            // 
            this.lbBoasVindas.AutoSize = true;
            this.lbBoasVindas.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBoasVindas.Location = new System.Drawing.Point(379, 90);
            this.lbBoasVindas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBoasVindas.Name = "lbBoasVindas";
            this.lbBoasVindas.Size = new System.Drawing.Size(237, 38);
            this.lbBoasVindas.TabIndex = 0;
            this.lbBoasVindas.Text = "Seja bem-vindo,";
            this.lbBoasVindas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPedidos.Location = new System.Drawing.Point(449, 265);
            this.btnVerPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(148, 28);
            this.btnVerPedidos.TabIndex = 1;
            this.btnVerPedidos.Text = "Ver meus pedidos";
            this.btnVerPedidos.UseVisualStyleBackColor = true;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerPedido.Location = new System.Drawing.Point(449, 214);
            this.btnFazerPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(148, 28);
            this.btnFazerPedido.TabIndex = 2;
            this.btnFazerPedido.Text = "Fazer pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            this.btnFazerPedido.Click += new System.EventHandler(this.btnFazerPedido_Click);
            // 
            // btnGaleria
            // 
            this.btnGaleria.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaleria.Location = new System.Drawing.Point(449, 316);
            this.btnGaleria.Margin = new System.Windows.Forms.Padding(4);
            this.btnGaleria.Name = "btnGaleria";
            this.btnGaleria.Size = new System.Drawing.Size(148, 28);
            this.btnGaleria.TabIndex = 3;
            this.btnGaleria.Text = "Galeria";
            this.btnGaleria.UseVisualStyleBackColor = true;
            this.btnGaleria.Click += new System.EventHandler(this.btnGaleria_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(449, 474);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(148, 28);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerencProdutos
            // 
            this.btnGerencProdutos.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerencProdutos.Location = new System.Drawing.Point(440, 368);
            this.btnGerencProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerencProdutos.Name = "btnGerencProdutos";
            this.btnGerencProdutos.Size = new System.Drawing.Size(157, 28);
            this.btnGerencProdutos.TabIndex = 5;
            this.btnGerencProdutos.Text = "Gerenciar produtos";
            this.btnGerencProdutos.UseVisualStyleBackColor = true;
            this.btnGerencProdutos.Click += new System.EventHandler(this.btnGerencProdutos_Click);
            // 
            // btnGerencGaleria
            // 
            this.btnGerencGaleria.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerencGaleria.Location = new System.Drawing.Point(440, 422);
            this.btnGerencGaleria.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerencGaleria.Name = "btnGerencGaleria";
            this.btnGerencGaleria.Size = new System.Drawing.Size(157, 28);
            this.btnGerencGaleria.TabIndex = 6;
            this.btnGerencGaleria.Text = "Gerenciar galeria";
            this.btnGerencGaleria.UseVisualStyleBackColor = true;
            this.btnGerencGaleria.Click += new System.EventHandler(this.btnGerencGaleria_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1067, 587);
            this.Controls.Add(this.btnGerencGaleria);
            this.Controls.Add(this.btnGerencProdutos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGaleria);
            this.Controls.Add(this.btnFazerPedido);
            this.Controls.Add(this.btnVerPedidos);
            this.Controls.Add(this.lbBoasVindas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arte Em Nós - Loja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.SizeChanged += new System.EventHandler(this.FormPrincipal_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBoasVindas;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.Button btnGaleria;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerencProdutos;
        private System.Windows.Forms.Button btnGerencGaleria;
    }
}