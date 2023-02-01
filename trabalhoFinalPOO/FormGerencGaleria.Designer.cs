namespace trabalhoFinalPOO
{
    partial class FormGerencGaleria
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
            this.btnAddGaleria = new System.Windows.Forms.Button();
            this.btnExcluirGaleria = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGerencGaleria = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbIdProdutoGerencGaleria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvProdutos = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddGaleria
            // 
            this.btnAddGaleria.Location = new System.Drawing.Point(304, 50);
            this.btnAddGaleria.Name = "btnAddGaleria";
            this.btnAddGaleria.Size = new System.Drawing.Size(141, 58);
            this.btnAddGaleria.TabIndex = 0;
            this.btnAddGaleria.Text = "Adicionar imagem ";
            this.btnAddGaleria.UseVisualStyleBackColor = true;
            this.btnAddGaleria.Click += new System.EventHandler(this.btnAddGaleria_Click);
            // 
            // btnExcluirGaleria
            // 
            this.btnExcluirGaleria.Location = new System.Drawing.Point(353, 30);
            this.btnExcluirGaleria.Name = "btnExcluirGaleria";
            this.btnExcluirGaleria.Size = new System.Drawing.Size(93, 35);
            this.btnExcluirGaleria.TabIndex = 1;
            this.btnExcluirGaleria.Text = "Excluir";
            this.btnExcluirGaleria.UseVisualStyleBackColor = true;
            this.btnExcluirGaleria.Click += new System.EventHandler(this.btnExcluirGaleria_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGerencGaleria);
            this.groupBox1.Controls.Add(this.btnExcluirGaleria);
            this.groupBox1.Location = new System.Drawing.Point(151, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excluir uma imagem";
            // 
            // cbGerencGaleria
            // 
            this.cbGerencGaleria.FormattingEnabled = true;
            this.cbGerencGaleria.Location = new System.Drawing.Point(27, 36);
            this.cbGerencGaleria.Name = "cbGerencGaleria";
            this.cbGerencGaleria.Size = new System.Drawing.Size(305, 24);
            this.cbGerencGaleria.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbIdProdutoGerencGaleria);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAddGaleria);
            this.groupBox2.Location = new System.Drawing.Point(152, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar uma imagem";
            // 
            // tbIdProdutoGerencGaleria
            // 
            this.tbIdProdutoGerencGaleria.Location = new System.Drawing.Point(156, 68);
            this.tbIdProdutoGerencGaleria.Name = "tbIdProdutoGerencGaleria";
            this.tbIdProdutoGerencGaleria.Size = new System.Drawing.Size(55, 22);
            this.tbIdProdutoGerencGaleria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID produto:";
            // 
            // lvProdutos
            // 
            this.lvProdutos.HideSelection = false;
            this.lvProdutos.Location = new System.Drawing.Point(132, 72);
            this.lvProdutos.Name = "lvProdutos";
            this.lvProdutos.Size = new System.Drawing.Size(512, 192);
            this.lvProdutos.TabIndex = 4;
            this.lvProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estes são os produtos existentes:";
            // 
            // FormGerencGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(755, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvProdutos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormGerencGaleria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Galeria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddGaleria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGerencGaleria;
        private System.Windows.Forms.Button btnExcluirGaleria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbIdProdutoGerencGaleria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvProdutos;
        private System.Windows.Forms.Label label2;
    }
}