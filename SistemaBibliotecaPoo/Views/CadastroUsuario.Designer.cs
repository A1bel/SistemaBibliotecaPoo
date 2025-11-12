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
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.telefoneTxt = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmaSenhaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(168, 144);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(578, 22);
            this.nomeTxt.TabIndex = 1;
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.Location = new System.Drawing.Point(172, 198);
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(215, 22);
            this.telefoneTxt.TabIndex = 3;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(91, 204);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(61, 16);
            this.Telefone.TabIndex = 2;
            this.Telefone.Text = "Telefone";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(469, 198);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(301, 22);
            this.emailTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(172, 254);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(281, 22);
            this.senhaTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha";
            // 
            // confirmaSenhaTxt
            // 
            this.confirmaSenhaTxt.Location = new System.Drawing.Point(168, 306);
            this.confirmaSenhaTxt.Name = "confirmaSenhaTxt";
            this.confirmaSenhaTxt.Size = new System.Drawing.Size(419, 22);
            this.confirmaSenhaTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirme a senha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 590);
            this.Controls.Add(this.confirmaSenhaTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telefoneTxt);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.label1);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.TextBox telefoneTxt;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmaSenhaTxt;
        private System.Windows.Forms.Label label5;
    }
}