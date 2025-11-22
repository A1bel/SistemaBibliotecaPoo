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
            this.SuspendLayout();
            // 
            // flowLivrosPanel
            // 
            this.flowLivrosPanel.Location = new System.Drawing.Point(28, 68);
            this.flowLivrosPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLivrosPanel.Name = "flowLivrosPanel";
            this.flowLivrosPanel.Size = new System.Drawing.Size(1012, 471);
            this.flowLivrosPanel.TabIndex = 0;
            // 
            // CadastrarLivroBtn
            // 
            this.CadastrarLivroBtn.Location = new System.Drawing.Point(911, 22);
            this.CadastrarLivroBtn.Name = "CadastrarLivroBtn";
            this.CadastrarLivroBtn.Size = new System.Drawing.Size(129, 39);
            this.CadastrarLivroBtn.TabIndex = 1;
            this.CadastrarLivroBtn.Text = "Cadastrar Livro";
            this.CadastrarLivroBtn.UseVisualStyleBackColor = true;
            this.CadastrarLivroBtn.Click += new System.EventHandler(this.CadastrarLivroBtn_Click);
            // 
            // meusLivrosBtn
            // 
            this.meusLivrosBtn.Location = new System.Drawing.Point(919, 22);
            this.meusLivrosBtn.Name = "meusLivrosBtn";
            this.meusLivrosBtn.Size = new System.Drawing.Size(121, 39);
            this.meusLivrosBtn.TabIndex = 2;
            this.meusLivrosBtn.Text = "Meus Livros";
            this.meusLivrosBtn.UseVisualStyleBackColor = true;
            this.meusLivrosBtn.Click += new System.EventHandler(this.meusLivrosBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
    }
}