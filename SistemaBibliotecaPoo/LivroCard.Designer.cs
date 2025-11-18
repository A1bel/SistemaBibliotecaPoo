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
            this.SuspendLayout();
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Location = new System.Drawing.Point(40, 23);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(43, 13);
            this.tituloLbl.TabIndex = 0;
            this.tituloLbl.Text = "tituloLbl";
            // 
            // autorLbl
            // 
            this.autorLbl.AutoSize = true;
            this.autorLbl.Location = new System.Drawing.Point(40, 47);
            this.autorLbl.Name = "autorLbl";
            this.autorLbl.Size = new System.Drawing.Size(45, 13);
            this.autorLbl.TabIndex = 1;
            this.autorLbl.Text = "autorLbl";
            // 
            // detalhesBtn
            // 
            this.detalhesBtn.Location = new System.Drawing.Point(30, 97);
            this.detalhesBtn.Name = "detalhesBtn";
            this.detalhesBtn.Size = new System.Drawing.Size(75, 23);
            this.detalhesBtn.TabIndex = 2;
            this.detalhesBtn.Text = "Detalhes";
            this.detalhesBtn.UseVisualStyleBackColor = true;
            // 
            // categoriaLbl
            // 
            this.categoriaLbl.AutoSize = true;
            this.categoriaLbl.Location = new System.Drawing.Point(40, 70);
            this.categoriaLbl.Name = "categoriaLbl";
            this.categoriaLbl.Size = new System.Drawing.Size(65, 13);
            this.categoriaLbl.TabIndex = 3;
            this.categoriaLbl.Text = "categoriaLbl";
            // 
            // LivroCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoriaLbl);
            this.Controls.Add(this.detalhesBtn);
            this.Controls.Add(this.autorLbl);
            this.Controls.Add(this.tituloLbl);
            this.Name = "LivroCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.Label autorLbl;
        private System.Windows.Forms.Button detalhesBtn;
        private System.Windows.Forms.Label categoriaLbl;
    }
}
