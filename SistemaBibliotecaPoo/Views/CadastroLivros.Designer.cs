namespace SistemaBibliotecaPoo.Views
{
    partial class CadastroLivros
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
            this.titulo = new System.Windows.Forms.Label();
            this.tituloTxt = new System.Windows.Forms.TextBox();
            this.tituloLivro = new System.Windows.Forms.Label();
            this.cadastroBtn = new System.Windows.Forms.Button();
            this.erroTituloLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.erroAutorLbl = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.autorTxt = new System.Windows.Forms.TextBox();
            this.erroCategoriaLbl = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.categoriaTxt = new System.Windows.Forms.TextBox();
            this.erroPrecoLbl = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.precoTxt = new System.Windows.Forms.TextBox();
            this.erroQuantidadeLbl = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.Label();
            this.quantidadeTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(86, 38);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(283, 36);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Cadastro de Livros";
            // 
            // tituloTxt
            // 
            this.tituloTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTxt.Location = new System.Drawing.Point(144, 113);
            this.tituloTxt.Name = "tituloTxt";
            this.tituloTxt.Size = new System.Drawing.Size(497, 27);
            this.tituloTxt.TabIndex = 1;
            // 
            // tituloLivro
            // 
            this.tituloLivro.AutoSize = true;
            this.tituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLivro.Location = new System.Drawing.Point(77, 116);
            this.tituloLivro.Name = "tituloLivro";
            this.tituloLivro.Size = new System.Drawing.Size(50, 20);
            this.tituloLivro.TabIndex = 2;
            this.tituloLivro.Text = "Título";
            // 
            // cadastroBtn
            // 
            this.cadastroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.cadastroBtn.Location = new System.Drawing.Point(617, 353);
            this.cadastroBtn.Name = "cadastroBtn";
            this.cadastroBtn.Size = new System.Drawing.Size(134, 38);
            this.cadastroBtn.TabIndex = 3;
            this.cadastroBtn.Text = "Salvar";
            this.cadastroBtn.UseVisualStyleBackColor = true;
            this.cadastroBtn.Click += new System.EventHandler(this.cadastroBtn_Click);
            // 
            // erroTituloLbl
            // 
            this.erroTituloLbl.AutoSize = true;
            this.erroTituloLbl.ForeColor = System.Drawing.Color.Red;
            this.erroTituloLbl.Location = new System.Drawing.Point(143, 143);
            this.erroTituloLbl.Name = "erroTituloLbl";
            this.erroTituloLbl.Size = new System.Drawing.Size(0, 16);
            this.erroTituloLbl.TabIndex = 4;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.Color.Red;
            this.cancelarBtn.Location = new System.Drawing.Point(430, 353);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(134, 38);
            this.cancelarBtn.TabIndex = 5;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // erroAutorLbl
            // 
            this.erroAutorLbl.AutoSize = true;
            this.erroAutorLbl.ForeColor = System.Drawing.Color.Red;
            this.erroAutorLbl.Location = new System.Drawing.Point(143, 202);
            this.erroAutorLbl.Name = "erroAutorLbl";
            this.erroAutorLbl.Size = new System.Drawing.Size(0, 16);
            this.erroAutorLbl.TabIndex = 8;
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.Location = new System.Drawing.Point(78, 172);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(49, 20);
            this.autor.TabIndex = 7;
            this.autor.Text = "Autor";
            // 
            // autorTxt
            // 
            this.autorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorTxt.Location = new System.Drawing.Point(146, 172);
            this.autorTxt.Name = "autorTxt";
            this.autorTxt.Size = new System.Drawing.Size(497, 27);
            this.autorTxt.TabIndex = 6;
            // 
            // erroCategoriaLbl
            // 
            this.erroCategoriaLbl.AutoSize = true;
            this.erroCategoriaLbl.ForeColor = System.Drawing.Color.Red;
            this.erroCategoriaLbl.Location = new System.Drawing.Point(143, 256);
            this.erroCategoriaLbl.Name = "erroCategoriaLbl";
            this.erroCategoriaLbl.Size = new System.Drawing.Size(0, 16);
            this.erroCategoriaLbl.TabIndex = 11;
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.Location = new System.Drawing.Point(46, 226);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(81, 20);
            this.categoria.TabIndex = 10;
            this.categoria.Text = "Categoria";
            // 
            // categoriaTxt
            // 
            this.categoriaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaTxt.Location = new System.Drawing.Point(146, 226);
            this.categoriaTxt.Name = "categoriaTxt";
            this.categoriaTxt.Size = new System.Drawing.Size(203, 27);
            this.categoriaTxt.TabIndex = 9;
            // 
            // erroPrecoLbl
            // 
            this.erroPrecoLbl.AutoSize = true;
            this.erroPrecoLbl.ForeColor = System.Drawing.Color.Red;
            this.erroPrecoLbl.Location = new System.Drawing.Point(445, 256);
            this.erroPrecoLbl.Name = "erroPrecoLbl";
            this.erroPrecoLbl.Size = new System.Drawing.Size(0, 16);
            this.erroPrecoLbl.TabIndex = 14;
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco.Location = new System.Drawing.Point(377, 226);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(53, 20);
            this.preco.TabIndex = 13;
            this.preco.Text = "Preço";
            // 
            // precoTxt
            // 
            this.precoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoTxt.Location = new System.Drawing.Point(448, 226);
            this.precoTxt.Name = "precoTxt";
            this.precoTxt.Size = new System.Drawing.Size(195, 27);
            this.precoTxt.TabIndex = 12;
            // 
            // erroQuantidadeLbl
            // 
            this.erroQuantidadeLbl.AutoSize = true;
            this.erroQuantidadeLbl.ForeColor = System.Drawing.Color.Red;
            this.erroQuantidadeLbl.Location = new System.Drawing.Point(143, 321);
            this.erroQuantidadeLbl.Name = "erroQuantidadeLbl";
            this.erroQuantidadeLbl.Size = new System.Drawing.Size(0, 16);
            this.erroQuantidadeLbl.TabIndex = 17;
            // 
            // quantidade
            // 
            this.quantidade.AutoSize = true;
            this.quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.Location = new System.Drawing.Point(33, 291);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(94, 20);
            this.quantidade.TabIndex = 16;
            this.quantidade.Text = "Quantidade";
            // 
            // quantidadeTxt
            // 
            this.quantidadeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeTxt.Location = new System.Drawing.Point(146, 291);
            this.quantidadeTxt.Name = "quantidadeTxt";
            this.quantidadeTxt.Size = new System.Drawing.Size(318, 27);
            this.quantidadeTxt.TabIndex = 15;
            // 
            // CadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erroQuantidadeLbl);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.quantidadeTxt);
            this.Controls.Add(this.erroPrecoLbl);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.precoTxt);
            this.Controls.Add(this.erroCategoriaLbl);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.categoriaTxt);
            this.Controls.Add(this.erroAutorLbl);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.autorTxt);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.erroTituloLbl);
            this.Controls.Add(this.cadastroBtn);
            this.Controls.Add(this.tituloLivro);
            this.Controls.Add(this.tituloTxt);
            this.Controls.Add(this.titulo);
            this.Name = "CadastroLivros";
            this.Text = "CadastroLivros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox tituloTxt;
        private System.Windows.Forms.Label tituloLivro;
        private System.Windows.Forms.Button cadastroBtn;
        private System.Windows.Forms.Label erroTituloLbl;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label erroAutorLbl;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.TextBox autorTxt;
        private System.Windows.Forms.Label erroCategoriaLbl;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.TextBox categoriaTxt;
        private System.Windows.Forms.Label erroPrecoLbl;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.TextBox precoTxt;
        private System.Windows.Forms.Label erroQuantidadeLbl;
        private System.Windows.Forms.Label quantidade;
        private System.Windows.Forms.TextBox quantidadeTxt;
    }
}