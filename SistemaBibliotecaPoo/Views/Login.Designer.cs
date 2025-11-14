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
            this.entrarBtn = new System.Windows.Forms.Button();
            this.erroLbl = new System.Windows.Forms.Label();
            this.contaLbl = new System.Windows.Forms.LinkLabel();
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
            this.label1.Location = new System.Drawing.Point(150, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(136, 88);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(76, 20);
            this.emailTxt.TabIndex = 1;
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(136, 143);
            this.senhaTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(76, 20);
            this.senhaTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // entrarBtn
            // 
            this.entrarBtn.Location = new System.Drawing.Point(136, 200);
            this.entrarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(56, 19);
            this.entrarBtn.TabIndex = 4;
            this.entrarBtn.Text = "Entrar";
            this.entrarBtn.UseVisualStyleBackColor = true;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // erroLbl
            // 
            this.erroLbl.AutoSize = true;
            this.erroLbl.Location = new System.Drawing.Point(133, 22);
            this.erroLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erroLbl.Name = "erroLbl";
            this.erroLbl.Size = new System.Drawing.Size(0, 13);
            this.erroLbl.TabIndex = 5;
            // 
            // contaLbl
            // 
            this.contaLbl.AutoSize = true;
            this.contaLbl.Location = new System.Drawing.Point(133, 237);
            this.contaLbl.Name = "contaLbl";
            this.contaLbl.Size = new System.Drawing.Size(110, 13);
            this.contaLbl.TabIndex = 7;
            this.contaLbl.TabStop = true;
            this.contaLbl.Text = "Não tenho uma conta";
            this.contaLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contaLbl_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.contaLbl);
            this.Controls.Add(this.erroLbl);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.Label erroLbl;
        private System.Windows.Forms.LinkLabel contaLbl;
    }
}

