namespace SistemaBibliotecaPoo.Views
{
    partial class EdicaoLivros
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
            this.cancelarEditarBtn = new System.Windows.Forms.Button();
            this.salvarEditarBtn = new System.Windows.Forms.Button();
            this.erroQuantidadeLbl = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.Label();
            this.quantidadeTxt = new System.Windows.Forms.TextBox();
            this.erroPrecoLbl = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.precoTxt = new System.Windows.Forms.TextBox();
            this.erroCategoriaLbl = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.categoriaTxt = new System.Windows.Forms.TextBox();
            this.erroAutorLbl = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.autorTxt = new System.Windows.Forms.TextBox();
            this.erroTituloLbl = new System.Windows.Forms.Label();
            this.tituloLivro = new System.Windows.Forms.Label();
            this.tituloTxt = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.Label();
            this.disponivel = new System.Windows.Forms.Label();
            this.disponivelBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelarEditarBtn
            // 
            this.cancelarEditarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarEditarBtn.ForeColor = System.Drawing.Color.Red;
            this.cancelarEditarBtn.Location = new System.Drawing.Point(450, 346);
            this.cancelarEditarBtn.Name = "cancelarEditarBtn";
            this.cancelarEditarBtn.Size = new System.Drawing.Size(134, 38);
            this.cancelarEditarBtn.TabIndex = 7;
            this.cancelarEditarBtn.Text = "Cancelar";
            this.cancelarEditarBtn.UseVisualStyleBackColor = true;
            this.cancelarEditarBtn.Click += new System.EventHandler(this.cancelarEditarBtn_Click);
            // 
            // salvarEditarBtn
            // 
            this.salvarEditarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarEditarBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.salvarEditarBtn.Location = new System.Drawing.Point(637, 346);
            this.salvarEditarBtn.Name = "salvarEditarBtn";
            this.salvarEditarBtn.Size = new System.Drawing.Size(134, 38);
            this.salvarEditarBtn.TabIndex = 8;
            this.salvarEditarBtn.Text = "Salvar";
            this.salvarEditarBtn.UseVisualStyleBackColor = true;
            this.salvarEditarBtn.Click += new System.EventHandler(this.salvarEditarBtn_Click);
            // 
            // erroQuantidadeLbl
            // 
            this.erroQuantidadeLbl.AutoSize = true;
            this.erroQuantidadeLbl.ForeColor = System.Drawing.Color.Red;
            this.erroQuantidadeLbl.Location = new System.Drawing.Point(130, 313);
            this.erroQuantidadeLbl.Name = "erroQuantidadeLbl";
            this.erroQuantidadeLbl.Size = new System.Drawing.Size(0, 16);
            this.erroQuantidadeLbl.TabIndex = 33;
            // 
            // quantidade
            // 
            this.quantidade.AutoSize = true;
            this.quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.Location = new System.Drawing.Point(21, 283);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(94, 20);
            this.quantidade.TabIndex = 15;
            this.quantidade.Text = "Quantidade";
            // 
            // quantidadeTxt
            // 
            this.quantidadeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeTxt.Location = new System.Drawing.Point(133, 283);
            this.quantidadeTxt.Name = "quantidadeTxt";
            this.quantidadeTxt.Size = new System.Drawing.Size(215, 27);
            this.quantidadeTxt.TabIndex = 5;
            // 
            // erroPrecoLbl
            // 
            this.erroPrecoLbl.AutoSize = true;
            this.erroPrecoLbl.ForeColor = System.Drawing.Color.Red;
            this.erroPrecoLbl.Location = new System.Drawing.Point(432, 251);
            this.erroPrecoLbl.Name = "erroPrecoLbl";
            this.erroPrecoLbl.Size = new System.Drawing.Size(0, 16);
            this.erroPrecoLbl.TabIndex = 30;
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco.Location = new System.Drawing.Point(367, 221);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(53, 20);
            this.preco.TabIndex = 14;
            this.preco.Text = "Preço";
            // 
            // precoTxt
            // 
            this.precoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoTxt.Location = new System.Drawing.Point(435, 221);
            this.precoTxt.Name = "precoTxt";
            this.precoTxt.Size = new System.Drawing.Size(220, 27);
            this.precoTxt.TabIndex = 4;
            // 
            // erroCategoriaLbl
            // 
            this.erroCategoriaLbl.AutoSize = true;
            this.erroCategoriaLbl.ForeColor = System.Drawing.Color.Red;
            this.erroCategoriaLbl.Location = new System.Drawing.Point(130, 251);
            this.erroCategoriaLbl.Name = "erroCategoriaLbl";
            this.erroCategoriaLbl.Size = new System.Drawing.Size(0, 16);
            this.erroCategoriaLbl.TabIndex = 27;
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.Location = new System.Drawing.Point(37, 221);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(81, 20);
            this.categoria.TabIndex = 13;
            this.categoria.Text = "Categoria";
            // 
            // categoriaTxt
            // 
            this.categoriaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaTxt.Location = new System.Drawing.Point(133, 221);
            this.categoriaTxt.Name = "categoriaTxt";
            this.categoriaTxt.Size = new System.Drawing.Size(210, 27);
            this.categoriaTxt.TabIndex = 3;
            // 
            // erroAutorLbl
            // 
            this.erroAutorLbl.AutoSize = true;
            this.erroAutorLbl.ForeColor = System.Drawing.Color.Red;
            this.erroAutorLbl.Location = new System.Drawing.Point(130, 197);
            this.erroAutorLbl.Name = "erroAutorLbl";
            this.erroAutorLbl.Size = new System.Drawing.Size(0, 16);
            this.erroAutorLbl.TabIndex = 24;
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.Location = new System.Drawing.Point(65, 167);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(49, 20);
            this.autor.TabIndex = 12;
            this.autor.Text = "Autor";
            // 
            // autorTxt
            // 
            this.autorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorTxt.Location = new System.Drawing.Point(133, 167);
            this.autorTxt.Name = "autorTxt";
            this.autorTxt.Size = new System.Drawing.Size(522, 27);
            this.autorTxt.TabIndex = 2;
            // 
            // erroTituloLbl
            // 
            this.erroTituloLbl.AutoSize = true;
            this.erroTituloLbl.ForeColor = System.Drawing.Color.Red;
            this.erroTituloLbl.Location = new System.Drawing.Point(130, 140);
            this.erroTituloLbl.Name = "erroTituloLbl";
            this.erroTituloLbl.Size = new System.Drawing.Size(0, 16);
            this.erroTituloLbl.TabIndex = 21;
            // 
            // tituloLivro
            // 
            this.tituloLivro.AutoSize = true;
            this.tituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLivro.Location = new System.Drawing.Point(65, 113);
            this.tituloLivro.Name = "tituloLivro";
            this.tituloLivro.Size = new System.Drawing.Size(50, 20);
            this.tituloLivro.TabIndex = 11;
            this.tituloLivro.Text = "Título";
            // 
            // tituloTxt
            // 
            this.tituloTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTxt.Location = new System.Drawing.Point(133, 110);
            this.tituloTxt.Name = "tituloTxt";
            this.tituloTxt.Size = new System.Drawing.Size(524, 27);
            this.tituloTxt.TabIndex = 1;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(63, 39);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(179, 36);
            this.titulo.TabIndex = 10;
            this.titulo.Text = "Editar Livro";
            // 
            // disponivel
            // 
            this.disponivel.AutoSize = true;
            this.disponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponivel.Location = new System.Drawing.Point(362, 289);
            this.disponivel.Name = "disponivel";
            this.disponivel.Size = new System.Drawing.Size(57, 20);
            this.disponivel.TabIndex = 16;
            this.disponivel.Text = "Status";
            // 
            // disponivelBox
            // 
            this.disponivelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disponivelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponivelBox.FormattingEnabled = true;
            this.disponivelBox.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.disponivelBox.Location = new System.Drawing.Point(435, 286);
            this.disponivelBox.Name = "disponivelBox";
            this.disponivelBox.Size = new System.Drawing.Size(220, 28);
            this.disponivelBox.TabIndex = 6;
            // 
            // EdicaoLivros
            // 
            this.AcceptButton = this.salvarEditarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.disponivelBox);
            this.Controls.Add(this.disponivel);
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
            this.Controls.Add(this.erroTituloLbl);
            this.Controls.Add(this.tituloLivro);
            this.Controls.Add(this.tituloTxt);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.cancelarEditarBtn);
            this.Controls.Add(this.salvarEditarBtn);
            this.Name = "EdicaoLivros";
            this.Text = "EdicaoLivros";
            this.Load += new System.EventHandler(this.EdicaoLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelarEditarBtn;
        private System.Windows.Forms.Button salvarEditarBtn;
        private System.Windows.Forms.Label erroQuantidadeLbl;
        private System.Windows.Forms.Label quantidade;
        private System.Windows.Forms.TextBox quantidadeTxt;
        private System.Windows.Forms.Label erroPrecoLbl;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.TextBox precoTxt;
        private System.Windows.Forms.Label erroCategoriaLbl;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.TextBox categoriaTxt;
        private System.Windows.Forms.Label erroAutorLbl;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.TextBox autorTxt;
        private System.Windows.Forms.Label erroTituloLbl;
        private System.Windows.Forms.Label tituloLivro;
        private System.Windows.Forms.TextBox tituloTxt;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label disponivel;
        private System.Windows.Forms.ComboBox disponivelBox;
    }
}