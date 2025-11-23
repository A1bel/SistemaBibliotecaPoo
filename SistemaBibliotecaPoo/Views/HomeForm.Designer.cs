namespace SistemaBibliotecaPoo.Views
{
    partial class HomeForm
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
            this.flowLivrosPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CadastrarLivroBtn = new System.Windows.Forms.Button();
            this.meusLivrosBtn = new System.Windows.Forms.Button();
            this.sairBtn = new System.Windows.Forms.Button();
            this.usuariosBtn = new System.Windows.Forms.Button();
            this.alterarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLivrosPanel
            // 
            this.flowLivrosPanel.AutoScroll = true;
            this.flowLivrosPanel.Location = new System.Drawing.Point(77, 68);
            this.flowLivrosPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLivrosPanel.Name = "flowLivrosPanel";
            this.flowLivrosPanel.Size = new System.Drawing.Size(977, 484);
            this.flowLivrosPanel.TabIndex = 0;
            // 
            // CadastrarLivroBtn
            // 
            this.CadastrarLivroBtn.Location = new System.Drawing.Point(77, 12);
            this.CadastrarLivroBtn.Name = "CadastrarLivroBtn";
            this.CadastrarLivroBtn.Size = new System.Drawing.Size(129, 39);
            this.CadastrarLivroBtn.TabIndex = 1;
            this.CadastrarLivroBtn.Text = "Cadastrar Livro";
            this.CadastrarLivroBtn.UseVisualStyleBackColor = true;
            this.CadastrarLivroBtn.Click += new System.EventHandler(this.CadastrarLivroBtn_Click);
            // 
            // meusLivrosBtn
            // 
            this.meusLivrosBtn.Location = new System.Drawing.Point(77, 12);
            this.meusLivrosBtn.Name = "meusLivrosBtn";
            this.meusLivrosBtn.Size = new System.Drawing.Size(129, 39);
            this.meusLivrosBtn.TabIndex = 2;
            this.meusLivrosBtn.Text = "Meus Livros";
            this.meusLivrosBtn.UseVisualStyleBackColor = true;
            this.meusLivrosBtn.Click += new System.EventHandler(this.meusLivrosBtn_Click);
            // 
            // sairBtn
            // 
            this.sairBtn.Location = new System.Drawing.Point(799, 12);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(126, 39);
            this.sairBtn.TabIndex = 3;
            this.sairBtn.Text = "Sair";
            this.sairBtn.UseVisualStyleBackColor = true;
            this.sairBtn.Click += new System.EventHandler(this.sairBtn_Click);
            // 
            // usuariosBtn
            // 
            this.usuariosBtn.Location = new System.Drawing.Point(222, 12);
            this.usuariosBtn.Name = "usuariosBtn";
            this.usuariosBtn.Size = new System.Drawing.Size(129, 39);
            this.usuariosBtn.TabIndex = 4;
            this.usuariosBtn.Text = "Usuários";
            this.usuariosBtn.UseVisualStyleBackColor = true;
            this.usuariosBtn.Click += new System.EventHandler(this.usuariosBtn_Click);
            // 
            // alterarBtn
            // 
            this.alterarBtn.Location = new System.Drawing.Point(635, 12);
            this.alterarBtn.Name = "alterarBtn";
            this.alterarBtn.Size = new System.Drawing.Size(149, 39);
            this.alterarBtn.TabIndex = 5;
            this.alterarBtn.Text = "Alterar meus dados";
            this.alterarBtn.UseVisualStyleBackColor = true;
            this.alterarBtn.Click += new System.EventHandler(this.alterarBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.alterarBtn);
            this.Controls.Add(this.usuariosBtn);
            this.Controls.Add(this.sairBtn);
            this.Controls.Add(this.meusLivrosBtn);
            this.Controls.Add(this.CadastrarLivroBtn);
            this.Controls.Add(this.flowLivrosPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLivrosPanel;
        private System.Windows.Forms.Button CadastrarLivroBtn;
        private System.Windows.Forms.Button meusLivrosBtn;
        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.Button usuariosBtn;
        private System.Windows.Forms.Button alterarBtn;
    }
}