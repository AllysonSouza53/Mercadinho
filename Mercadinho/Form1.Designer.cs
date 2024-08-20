namespace Mercadinho
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Produto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CTtc = new System.Windows.Forms.Label();
            this.Ep = new System.Windows.Forms.TextBox();
            this.Evu = new System.Windows.Forms.TextBox();
            this.Eq = new System.Windows.Forms.TextBox();
            this.Bip = new System.Windows.Forms.Button();
            this.Bnc = new System.Windows.Forms.Button();
            this.Bf = new System.Windows.Forms.Button();
            this.LTp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Produto
            // 
            this.Produto.AutoSize = true;
            this.Produto.Location = new System.Drawing.Point(53, 32);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(47, 13);
            this.Produto.TabIndex = 0;
            this.Produto.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vl. Unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Compra: ";
            // 
            // CTtc
            // 
            this.CTtc.AutoSize = true;
            this.CTtc.Location = new System.Drawing.Point(120, 531);
            this.CTtc.Name = "CTtc";
            this.CTtc.Size = new System.Drawing.Size(10, 13);
            this.CTtc.TabIndex = 4;
            this.CTtc.Text = " ";
            // 
            // Ep
            // 
            this.Ep.Location = new System.Drawing.Point(102, 25);
            this.Ep.Name = "Ep";
            this.Ep.Size = new System.Drawing.Size(309, 20);
            this.Ep.TabIndex = 5;
            // 
            // Evu
            // 
            this.Evu.Location = new System.Drawing.Point(102, 96);
            this.Evu.Name = "Evu";
            this.Evu.Size = new System.Drawing.Size(195, 20);
            this.Evu.TabIndex = 6;
            // 
            // Eq
            // 
            this.Eq.Location = new System.Drawing.Point(102, 60);
            this.Eq.Name = "Eq";
            this.Eq.Size = new System.Drawing.Size(195, 20);
            this.Eq.TabIndex = 7;
            // 
            // Bip
            // 
            this.Bip.Location = new System.Drawing.Point(180, 145);
            this.Bip.Name = "Bip";
            this.Bip.Size = new System.Drawing.Size(88, 45);
            this.Bip.TabIndex = 8;
            this.Bip.Text = "Inserir Produtos";
            this.Bip.UseVisualStyleBackColor = true;
            this.Bip.Click += new System.EventHandler(this.Bip_Click);
            // 
            // Bnc
            // 
            this.Bnc.Location = new System.Drawing.Point(54, 582);
            this.Bnc.Name = "Bnc";
            this.Bnc.Size = new System.Drawing.Size(94, 42);
            this.Bnc.TabIndex = 9;
            this.Bnc.Text = "Nova Compra";
            this.Bnc.UseVisualStyleBackColor = true;
            this.Bnc.Click += new System.EventHandler(this.Bnc_Click);
            // 
            // Bf
            // 
            this.Bf.Location = new System.Drawing.Point(317, 582);
            this.Bf.Name = "Bf";
            this.Bf.Size = new System.Drawing.Size(94, 42);
            this.Bf.TabIndex = 10;
            this.Bf.Text = "Fechar";
            this.Bf.UseVisualStyleBackColor = true;
            this.Bf.Click += new System.EventHandler(this.Bf_Click);
            // 
            // LTp
            // 
            this.LTp.FormattingEnabled = true;
            this.LTp.Items.AddRange(new object[] {
            " "});
            this.LTp.Location = new System.Drawing.Point(54, 196);
            this.LTp.Name = "LTp";
            this.LTp.Size = new System.Drawing.Size(357, 303);
            this.LTp.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 645);
            this.Controls.Add(this.LTp);
            this.Controls.Add(this.Bf);
            this.Controls.Add(this.Bnc);
            this.Controls.Add(this.Bip);
            this.Controls.Add(this.Eq);
            this.Controls.Add(this.Evu);
            this.Controls.Add(this.Ep);
            this.Controls.Add(this.CTtc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Produto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CTtc;
        private System.Windows.Forms.TextBox Ep;
        private System.Windows.Forms.TextBox Evu;
        private System.Windows.Forms.TextBox Eq;
        private System.Windows.Forms.Button Bip;
        private System.Windows.Forms.Button Bnc;
        private System.Windows.Forms.Button Bf;
        private System.Windows.Forms.ListBox LTp;
    }
}

