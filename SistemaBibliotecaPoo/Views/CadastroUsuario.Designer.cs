namespace SistemaBibliotecaPoo.Views
{
    partial class CadastroUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.erroCSenhaLbl = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.Label();
            this.confimarSenhaTxt = new System.Windows.Forms.TextBox();
            this.erroEmailLbl = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.erroSenhaLbl = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.erroTelefoneLbl = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.telefoneTxt = new System.Windows.Forms.TextBox();
            this.erroNomeLbl = new System.Windows.Forms.Label();
            this.usuarioNome = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.cadastroBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // erroCSenhaLbl
            // 
            this.erroCSenhaLbl.AutoSize = true;
            this.erroCSenhaLbl.ForeColor = System.Drawing.Color.Red;
            this.erroCSenhaLbl.Location = new System.Drawing.Point(170, 596);
            this.erroCSenhaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.erroCSenhaLbl.Name = "erroCSenhaLbl";
            this.erroCSenhaLbl.Size = new System.Drawing.Size(0, 16);
            this.erroCSenhaLbl.TabIndex = 30;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(113, 71);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(307, 36);
            this.titulo.TabIndex = 31;
            this.titulo.Text = "Cadastro de Usuário";
            // 
            // quantidade
            // 
            this.quantidade.AutoSize = true;
            this.quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.Location = new System.Drawing.Point(19, 338);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(141, 20);
            this.quantidade.TabIndex = 54;
            this.quantidade.Text = "Confirme a senha";
            // 
            // confimarSenhaTxt
            // 
            this.confimarSenhaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confimarSenhaTxt.Location = new System.Drawing.Point(171, 335);
            this.confimarSenhaTxt.Name = "confimarSenhaTxt";
            this.confimarSenhaTxt.Size = new System.Drawing.Size(285, 27);
            this.confimarSenhaTxt.TabIndex = 53;
            // 
            // erroEmailLbl
            // 
            this.erroEmailLbl.AutoSize = true;
            this.erroEmailLbl.ForeColor = System.Drawing.Color.Red;
            this.erroEmailLbl.Location = new System.Drawing.Point(470, 253);
            this.erroEmailLbl.Name = "erroEmailLbl";
            this.erroEmailLbl.Size = new System.Drawing.Size(0, 16);
            this.erroEmailLbl.TabIndex = 52;
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco.Location = new System.Drawing.Point(416, 229);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(51, 20);
            this.preco.TabIndex = 51;
            this.preco.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(473, 223);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(281, 27);
            this.emailTxt.TabIndex = 50;
            // 
            // erroSenhaLbl
            // 
            this.erroSenhaLbl.AutoSize = true;
            this.erroSenhaLbl.ForeColor = System.Drawing.Color.Red;
            this.erroSenhaLbl.Location = new System.Drawing.Point(170, 310);
            this.erroSenhaLbl.Name = "erroSenhaLbl";
            this.erroSenhaLbl.Size = new System.Drawing.Size(0, 16);
            this.erroSenhaLbl.TabIndex = 49;
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.Location = new System.Drawing.Point(104, 283);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(56, 20);
            this.categoria.TabIndex = 48;
            this.categoria.Text = "Senha";
            // 
            // senhaTxt
            // 
            this.senhaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.Location = new System.Drawing.Point(173, 280);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(283, 27);
            this.senhaTxt.TabIndex = 47;
            // 
            // erroTelefoneLbl
            // 
            this.erroTelefoneLbl.AutoSize = true;
            this.erroTelefoneLbl.ForeColor = System.Drawing.Color.Red;
            this.erroTelefoneLbl.Location = new System.Drawing.Point(170, 256);
            this.erroTelefoneLbl.Name = "erroTelefoneLbl";
            this.erroTelefoneLbl.Size = new System.Drawing.Size(0, 16);
            this.erroTelefoneLbl.TabIndex = 46;
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.Location = new System.Drawing.Point(87, 226);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(73, 20);
            this.autor.TabIndex = 45;
            this.autor.Text = "Telefone";
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTxt.Location = new System.Drawing.Point(173, 226);
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(220, 27);
            this.telefoneTxt.TabIndex = 44;
            // 
            // erroNomeLbl
            // 
            this.erroNomeLbl.AutoSize = true;
            this.erroNomeLbl.ForeColor = System.Drawing.Color.Red;
            this.erroNomeLbl.Location = new System.Drawing.Point(170, 197);
            this.erroNomeLbl.Name = "erroNomeLbl";
            this.erroNomeLbl.Size = new System.Drawing.Size(0, 16);
            this.erroNomeLbl.TabIndex = 43;
            // 
            // usuarioNome
            // 
            this.usuarioNome.AutoSize = true;
            this.usuarioNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioNome.Location = new System.Drawing.Point(115, 172);
            this.usuarioNome.Name = "usuarioNome";
            this.usuarioNome.Size = new System.Drawing.Size(53, 20);
            this.usuarioNome.TabIndex = 42;
            this.usuarioNome.Text = "Nome";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(171, 167);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(583, 27);
            this.nomeTxt.TabIndex = 41;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.Color.Red;
            this.cancelarBtn.Location = new System.Drawing.Point(458, 415);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(134, 38);
            this.cancelarBtn.TabIndex = 56;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            // 
            // cadastroBtn
            // 
            this.cadastroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.cadastroBtn.Location = new System.Drawing.Point(645, 415);
            this.cadastroBtn.Name = "cadastroBtn";
            this.cadastroBtn.Size = new System.Drawing.Size(134, 38);
            this.cadastroBtn.TabIndex = 55;
            this.cadastroBtn.Text = "Salvar";
            this.cadastroBtn.UseVisualStyleBackColor = true;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 497);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.cadastroBtn);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.confimarSenhaTxt);
            this.Controls.Add(this.erroEmailLbl);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.erroSenhaLbl);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.erroTelefoneLbl);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.telefoneTxt);
            this.Controls.Add(this.erroNomeLbl);
            this.Controls.Add(this.usuarioNome);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.erroCSenhaLbl);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label erroCSenhaLbl;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label quantidade;
        private System.Windows.Forms.TextBox confimarSenhaTxt;
        private System.Windows.Forms.Label erroEmailLbl;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label erroSenhaLbl;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label erroTelefoneLbl;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.TextBox telefoneTxt;
        private System.Windows.Forms.Label erroNomeLbl;
        private System.Windows.Forms.Label usuarioNome;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button cadastroBtn;
    }
}