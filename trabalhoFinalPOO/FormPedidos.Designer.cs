namespace trabalhoFinalPOO
{
    partial class FormPedidos
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
            this.lbBvPedidos = new System.Windows.Forms.Label();
            this.lvPedidos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbBvPedidos
            // 
            this.lbBvPedidos.AutoSize = true;
            this.lbBvPedidos.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBvPedidos.Location = new System.Drawing.Point(24, 25);
            this.lbBvPedidos.Name = "lbBvPedidos";
            this.lbBvPedidos.Size = new System.Drawing.Size(305, 26);
            this.lbBvPedidos.TabIndex = 0;
            this.lbBvPedidos.Text = "Olá, estes são os seus pedidos:";
            // 
            // lvPedidos
            // 
            this.lvPedidos.HideSelection = false;
            this.lvPedidos.Location = new System.Drawing.Point(29, 71);
            this.lvPedidos.Name = "lvPedidos";
            this.lvPedidos.Size = new System.Drawing.Size(440, 246);
            this.lvPedidos.TabIndex = 1;
            this.lvPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(508, 337);
            this.Controls.Add(this.lvPedidos);
            this.Controls.Add(this.lbBvPedidos);
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBvPedidos;
        private System.Windows.Forms.ListView lvPedidos;
    }
}