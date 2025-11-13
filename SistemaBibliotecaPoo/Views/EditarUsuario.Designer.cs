namespace SistemaBibliotecaPoo.Views
{
    partial class EditarUsuario
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
            this.confirmaSenhaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telefoneTxt = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salvarbtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Editar Dados do Cadastro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // confirmaSenhaTxt
            // 
            this.confirmaSenhaTxt.Location = new System.Drawing.Point(165, 295);
            this.confirmaSenhaTxt.Name = "confirmaSenhaTxt";
            this.confirmaSenhaTxt.Size = new System.Drawing.Size(419, 22);
            this.confirmaSenhaTxt.TabIndex = 20;
            this.confirmaSenhaTxt.TextChanged += new System.EventHandler(this.confirmaSenhaTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirme a senha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(169, 243);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(281, 22);
            this.senhaTxt.TabIndex = 18;
            this.senhaTxt.TextChanged += new System.EventHandler(this.senhaTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(466, 187);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(301, 22);
            this.emailTxt.TabIndex = 16;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.Location = new System.Drawing.Point(169, 187);
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(215, 22);
            this.telefoneTxt.TabIndex = 14;
            this.telefoneTxt.TextChanged += new System.EventHandler(this.telefoneTxt_TextChanged);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(88, 193);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(61, 16);
            this.Telefone.TabIndex = 13;
            this.Telefone.Text = "Telefone";
            this.Telefone.Click += new System.EventHandler(this.Telefone_Click);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(165, 133);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(578, 22);
            this.nomeTxt.TabIndex = 12;
            this.nomeTxt.TextChanged += new System.EventHandler(this.nomeTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // salvarbtn
            // 
            this.salvarbtn.Location = new System.Drawing.Point(604, 360);
            this.salvarbtn.Name = "salvarbtn";
            this.salvarbtn.Size = new System.Drawing.Size(117, 36);
            this.salvarbtn.TabIndex = 22;
            this.salvarbtn.Text = "Salvar";
            this.salvarbtn.UseVisualStyleBackColor = true;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(443, 360);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(117, 36);
            this.cancelarBtn.TabIndex = 23;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.salvarbtn);
            this.Controls.Add(this.label2);
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
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmaSenhaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefoneTxt;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salvarbtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}