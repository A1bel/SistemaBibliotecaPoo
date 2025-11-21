namespace SistemaBibliotecaPoo
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contaLbl = new System.Windows.Forms.LinkLabel();
            this.titulo = new System.Windows.Forms.Label();
            this.entrarBtn = new System.Windows.Forms.Button();
            this.erroLbl = new System.Windows.Forms.Label();
            this.erroSenhaLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(235, 172);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(330, 30);
            this.emailTxt.TabIndex = 1;
            // 
            // senhaTxt
            // 
            this.senhaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.Location = new System.Drawing.Point(235, 267);
            this.senhaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(330, 30);
            this.senhaTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // contaLbl
            // 
            this.contaLbl.AutoSize = true;
            this.contaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaLbl.Location = new System.Drawing.Point(231, 326);
            this.contaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contaLbl.Name = "contaLbl";
            this.contaLbl.Size = new System.Drawing.Size(168, 20);
            this.contaLbl.TabIndex = 7;
            this.contaLbl.TabStop = true;
            this.contaLbl.Text = "Não tenho uma conta";
            this.contaLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contaLbl_LinkClicked);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(285, 38);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(253, 39);
            this.titulo.TabIndex = 19;
            this.titulo.Text = "Acessar Conta";
            // 
            // entrarBtn
            // 
            this.entrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarBtn.ForeColor = System.Drawing.Color.Black;
            this.entrarBtn.Location = new System.Drawing.Point(552, 350);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(134, 38);
            this.entrarBtn.TabIndex = 20;
            this.entrarBtn.Text = "Entrar";
            this.entrarBtn.UseVisualStyleBackColor = true;
            // 
            // erroLbl
            // 
            this.erroLbl.AutoSize = true;
            this.erroLbl.ForeColor = System.Drawing.Color.Red;
            this.erroLbl.Location = new System.Drawing.Point(232, 204);
            this.erroLbl.Name = "erroLbl";
            this.erroLbl.Size = new System.Drawing.Size(0, 16);
            this.erroLbl.TabIndex = 21;
            // 
            // erroSenhaLbl
            // 
            this.erroSenhaLbl.AutoSize = true;
            this.erroSenhaLbl.ForeColor = System.Drawing.Color.Red;
            this.erroSenhaLbl.Location = new System.Drawing.Point(232, 299);
            this.erroSenhaLbl.Name = "erroSenhaLbl";
            this.erroSenhaLbl.Size = new System.Drawing.Size(0, 16);
            this.erroSenhaLbl.TabIndex = 22;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erroSenhaLbl);
            this.Controls.Add(this.erroLbl);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.contaLbl);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel contaLbl;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.Label erroLbl;
        private System.Windows.Forms.Label erroSenhaLbl;
    }
}

