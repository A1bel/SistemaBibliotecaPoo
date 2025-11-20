namespace SistemaBibliotecaPoo
{
    partial class LivroCard
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloLbl = new System.Windows.Forms.Label();
            this.autorLbl = new System.Windows.Forms.Label();
            this.detalhesBtn = new System.Windows.Forms.Button();
            this.categoriaLbl = new System.Windows.Forms.Label();
            this.precoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Location = new System.Drawing.Point(40, 25);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(43, 13);
            this.tituloLbl.TabIndex = 0;
            this.tituloLbl.Text = "tituloLbl";
            // 
            // autorLbl
            // 
            this.autorLbl.AutoSize = true;
            this.autorLbl.Location = new System.Drawing.Point(40, 71);
            this.autorLbl.Name = "autorLbl";
            this.autorLbl.Size = new System.Drawing.Size(45, 13);
            this.autorLbl.TabIndex = 1;
            this.autorLbl.Text = "autorLbl";
            // 
            // detalhesBtn
            // 
            this.detalhesBtn.Location = new System.Drawing.Point(30, 123);
            this.detalhesBtn.Name = "detalhesBtn";
            this.detalhesBtn.Size = new System.Drawing.Size(75, 23);
            this.detalhesBtn.TabIndex = 2;
            this.detalhesBtn.Text = "Detalhes";
            this.detalhesBtn.UseVisualStyleBackColor = true;
            this.detalhesBtn.Click += new System.EventHandler(this.detalhesBtn_Click);
            // 
            // categoriaLbl
            // 
            this.categoriaLbl.AutoSize = true;
            this.categoriaLbl.Location = new System.Drawing.Point(40, 93);
            this.categoriaLbl.Name = "categoriaLbl";
            this.categoriaLbl.Size = new System.Drawing.Size(65, 13);
            this.categoriaLbl.TabIndex = 3;
            this.categoriaLbl.Text = "categoriaLbl";
            // 
            // precoLbl
            // 
            this.precoLbl.AutoSize = true;
            this.precoLbl.Location = new System.Drawing.Point(40, 47);
            this.precoLbl.Name = "precoLbl";
            this.precoLbl.Size = new System.Drawing.Size(48, 13);
            this.precoLbl.TabIndex = 4;
            this.precoLbl.Text = "precoLbl";
            // 
            // LivroCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.precoLbl);
            this.Controls.Add(this.categoriaLbl);
            this.Controls.Add(this.detalhesBtn);
            this.Controls.Add(this.autorLbl);
            this.Controls.Add(this.tituloLbl);
            this.Name = "LivroCard";
            this.Size = new System.Drawing.Size(150, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.Label autorLbl;
        private System.Windows.Forms.Button detalhesBtn;
        private System.Windows.Forms.Label categoriaLbl;
        private System.Windows.Forms.Label precoLbl;
    }
}
