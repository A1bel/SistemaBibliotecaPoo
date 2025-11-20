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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.erroCategoriaLbl = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.erroPrecoLbl = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.erroQuantidadeLbl = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.titulo.Click += new System.EventHandler(this.label1_Click);
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
            this.tituloLivro.Location = new System.Drawing.Point(88, 118);
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
            this.autor.Location = new System.Drawing.Point(88, 172);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(49, 20);
            this.autor.TabIndex = 7;
            this.autor.Text = "Autor";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 27);
            this.textBox1.TabIndex = 6;
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
            this.categoria.Location = new System.Drawing.Point(60, 226);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(81, 20);
            this.categoria.TabIndex = 10;
            this.categoria.Text = "Categoria";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(146, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 27);
            this.textBox2.TabIndex = 9;
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
            this.preco.Location = new System.Drawing.Point(390, 226);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(43, 16);
            this.preco.TabIndex = 13;
            this.preco.Text = "Preço";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(448, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 27);
            this.textBox3.TabIndex = 12;
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
            this.quantidade.Location = new System.Drawing.Point(49, 291);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(94, 20);
            this.quantidade.TabIndex = 16;
            this.quantidade.Text = "Quantidade";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(146, 291);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(318, 27);
            this.textBox4.TabIndex = 15;
            // 
            // CadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erroQuantidadeLbl);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.erroPrecoLbl);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.erroCategoriaLbl);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.erroAutorLbl);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.erroTituloLbl);
            this.Controls.Add(this.cadastroBtn);
            this.Controls.Add(this.tituloLivro);
            this.Controls.Add(this.tituloTxt);
            this.Controls.Add(this.titulo);
            this.Name = "CadastroLivros";
            this.Text = "CadastroLivros";
            this.Load += new System.EventHandler(this.CadastroLivros_Load);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label erroCategoriaLbl;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label erroPrecoLbl;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label erroQuantidadeLbl;
        private System.Windows.Forms.Label quantidade;
        private System.Windows.Forms.TextBox textBox4;
    }
}