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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(64, 20);
            this.tituloLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(72, 22);
            this.tituloLbl.TabIndex = 0;
            this.tituloLbl.Text = "tituloLbl";
            // 
            // autorLbl
            // 
            this.autorLbl.AutoSize = true;
            this.autorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorLbl.Location = new System.Drawing.Point(91, 86);
            this.autorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autorLbl.Name = "autorLbl";
            this.autorLbl.Size = new System.Drawing.Size(61, 18);
            this.autorLbl.TabIndex = 1;
            this.autorLbl.Text = "autorLbl";
            // 
            // detalhesBtn
            // 
            this.detalhesBtn.Location = new System.Drawing.Point(40, 151);
            this.detalhesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detalhesBtn.Name = "detalhesBtn";
            this.detalhesBtn.Size = new System.Drawing.Size(100, 28);
            this.detalhesBtn.TabIndex = 2;
            this.detalhesBtn.Text = "Detalhes";
            this.detalhesBtn.UseVisualStyleBackColor = true;
            this.detalhesBtn.Click += new System.EventHandler(this.detalhesBtn_Click);
            // 
            // categoriaLbl
            // 
            this.categoriaLbl.AutoSize = true;
            this.categoriaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLbl.Location = new System.Drawing.Point(114, 113);
            this.categoriaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoriaLbl.Name = "categoriaLbl";
            this.categoriaLbl.Size = new System.Drawing.Size(63, 18);
            this.categoriaLbl.TabIndex = 3;
            this.categoriaLbl.Text = "categLbl";
            // 
            // precoLbl
            // 
            this.precoLbl.AutoSize = true;
            this.precoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoLbl.Location = new System.Drawing.Point(91, 57);
            this.precoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precoLbl.Name = "precoLbl";
            this.precoLbl.Size = new System.Drawing.Size(65, 18);
            this.precoLbl.TabIndex = 4;
            this.precoLbl.Text = "precoLbl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor:";
            // 
            // LivroCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.precoLbl);
            this.Controls.Add(this.categoriaLbl);
            this.Controls.Add(this.detalhesBtn);
            this.Controls.Add(this.autorLbl);
            this.Controls.Add(this.tituloLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LivroCard";
            this.Size = new System.Drawing.Size(202, 216);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.Label autorLbl;
        private System.Windows.Forms.Button detalhesBtn;
        private System.Windows.Forms.Label categoriaLbl;
        private System.Windows.Forms.Label precoLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
