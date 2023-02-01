namespace trabalhoFinalPOO
{
    partial class FormGerencProduto
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
            this.lvGcProdutos = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.tbQtdAddProd = new System.Windows.Forms.TextBox();
            this.tbPrecoAddProd = new System.Windows.Forms.TextBox();
            this.tbDescAddProd = new System.Windows.Forms.TextBox();
            this.tbNomeAddProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.tbDescProdUpdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.tbIdProdDel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbQtdUpdt = new System.Windows.Forms.TextBox();
            this.tbPrecoUpdt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNomeProdUpdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdProdUpdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvGcProdutos
            // 
            this.lvGcProdutos.HideSelection = false;
            this.lvGcProdutos.Location = new System.Drawing.Point(38, 75);
            this.lvGcProdutos.Name = "lvGcProdutos";
            this.lvGcProdutos.Size = new System.Drawing.Size(994, 311);
            this.lvGcProdutos.TabIndex = 0;
            this.lvGcProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estes são os produtos existentes:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddProd);
            this.groupBox1.Controls.Add(this.tbQtdAddProd);
            this.groupBox1.Controls.Add(this.tbPrecoAddProd);
            this.groupBox1.Controls.Add(this.tbDescAddProd);
            this.groupBox1.Controls.Add(this.tbNomeAddProd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 292);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar produto";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(238, 156);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(89, 69);
            this.btnAddProd.TabIndex = 8;
            this.btnAddProd.Text = "Adicionar";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // tbQtdAddProd
            // 
            this.tbQtdAddProd.Location = new System.Drawing.Point(113, 200);
            this.tbQtdAddProd.Name = "tbQtdAddProd";
            this.tbQtdAddProd.Size = new System.Drawing.Size(55, 25);
            this.tbQtdAddProd.TabIndex = 7;
            // 
            // tbPrecoAddProd
            // 
            this.tbPrecoAddProd.Location = new System.Drawing.Point(113, 156);
            this.tbPrecoAddProd.Name = "tbPrecoAddProd";
            this.tbPrecoAddProd.Size = new System.Drawing.Size(94, 25);
            this.tbPrecoAddProd.TabIndex = 6;
            // 
            // tbDescAddProd
            // 
            this.tbDescAddProd.Location = new System.Drawing.Point(113, 113);
            this.tbDescAddProd.Name = "tbDescAddProd";
            this.tbDescAddProd.Size = new System.Drawing.Size(214, 25);
            this.tbDescAddProd.TabIndex = 5;
            // 
            // tbNomeAddProd
            // 
            this.tbNomeAddProd.Location = new System.Drawing.Point(113, 71);
            this.tbNomeAddProd.Name = "tbNomeAddProd";
            this.tbNomeAddProd.Size = new System.Drawing.Size(214, 25);
            this.tbNomeAddProd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnUpdt
            // 
            this.btnUpdt.Location = new System.Drawing.Point(238, 196);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(89, 56);
            this.btnUpdt.TabIndex = 9;
            this.btnUpdt.Text = "Atualizar";
            this.btnUpdt.UseVisualStyleBackColor = true;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // tbDescProdUpdt
            // 
            this.tbDescProdUpdt.Location = new System.Drawing.Point(113, 165);
            this.tbDescProdUpdt.Name = "tbDescProdUpdt";
            this.tbDescProdUpdt.Size = new System.Drawing.Size(214, 25);
            this.tbDescProdUpdt.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Descrição:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelAll);
            this.groupBox2.Controls.Add(this.btnDelProd);
            this.groupBox2.Controls.Add(this.tbIdProdDel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(772, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 292);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluir produto";
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(57, 230);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(157, 42);
            this.btnDelAll.TabIndex = 13;
            this.btnDelAll.Text = "Excluir todos os produtos";
            this.btnDelAll.UseVisualStyleBackColor = true;
            // 
            // btnDelProd
            // 
            this.btnDelProd.Location = new System.Drawing.Point(93, 116);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(89, 59);
            this.btnDelProd.TabIndex = 11;
            this.btnDelProd.Text = "Excluir";
            this.btnDelProd.UseVisualStyleBackColor = true;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            // 
            // tbIdProdDel
            // 
            this.tbIdProdDel.Location = new System.Drawing.Point(113, 53);
            this.tbIdProdDel.Name = "tbIdProdDel";
            this.tbIdProdDel.Size = new System.Drawing.Size(55, 25);
            this.tbIdProdDel.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "ID produto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdt);
            this.groupBox3.Controls.Add(this.tbQtdUpdt);
            this.groupBox3.Controls.Add(this.tbPrecoUpdt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbDescProdUpdt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbNomeProdUpdt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbIdProdUpdt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(409, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 292);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Atualizar produto";
            // 
            // tbQtdUpdt
            // 
            this.tbQtdUpdt.Location = new System.Drawing.Point(113, 227);
            this.tbQtdUpdt.Name = "tbQtdUpdt";
            this.tbQtdUpdt.Size = new System.Drawing.Size(55, 25);
            this.tbQtdUpdt.TabIndex = 10;
            // 
            // tbPrecoUpdt
            // 
            this.tbPrecoUpdt.Location = new System.Drawing.Point(113, 196);
            this.tbPrecoUpdt.Name = "tbPrecoUpdt";
            this.tbPrecoUpdt.Size = new System.Drawing.Size(94, 25);
            this.tbPrecoUpdt.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Quantidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Preço:";
            // 
            // tbNomeProdUpdt
            // 
            this.tbNomeProdUpdt.Location = new System.Drawing.Point(113, 132);
            this.tbNomeProdUpdt.Name = "tbNomeProdUpdt";
            this.tbNomeProdUpdt.Size = new System.Drawing.Size(214, 25);
            this.tbNomeProdUpdt.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 51);
            this.label8.TabIndex = 10;
            this.label8.Text = "Digite o ID do produto que você deseja modificar.\r\nDeixe em branco informações qu" +
    "e você não quer\r\nmodificar.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nome:";
            // 
            // tbIdProdUpdt
            // 
            this.tbIdProdUpdt.Location = new System.Drawing.Point(113, 101);
            this.tbIdProdUpdt.Name = "tbIdProdUpdt";
            this.tbIdProdUpdt.Size = new System.Drawing.Size(55, 25);
            this.tbIdProdUpdt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID produto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(697, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 27);
            this.label13.TabIndex = 9;
            this.label13.Text = "Ordenar por:";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "ID crescente",
            "ID descrente ",
            "Preço crescente",
            "Preço decrescente",
            "Quantidade crescente",
            "Quantidade decrescente",
            "Mais pedidos"});
            this.cbSort.Location = new System.Drawing.Point(847, 29);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(185, 24);
            this.cbSort.TabIndex = 10;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // FormGerencProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1076, 730);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvGcProdutos);
            this.Name = "FormGerencProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvGcProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.TextBox tbQtdAddProd;
        private System.Windows.Forms.TextBox tbPrecoAddProd;
        private System.Windows.Forms.TextBox tbDescAddProd;
        private System.Windows.Forms.TextBox tbNomeAddProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescProdUpdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNomeProdUpdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdProdUpdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.TextBox tbQtdUpdt;
        private System.Windows.Forms.TextBox tbPrecoUpdt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.TextBox tbIdProdDel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbSort;
    }
}