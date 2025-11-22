namespace SistemaBibliotecaPoo
{
    partial class LivroCard
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloLbl = new System.Windows.Forms.Label();
            this.autorLbl = new System.Windows.Forms.Label();
            this.alugarBtn = new System.Windows.Forms.Button();
            this.categoriaLbl = new System.Windows.Forms.Label();
            this.precoLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editarLivroBtn = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.deletarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.qtdLbl = new System.Windows.Forms.Label();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(63, 21);
            this.tituloLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(72, 22);
            this.tituloLbl.TabIndex = 0;
            this.tituloLbl.Text = "tituloLbl";
            // 
            // autorLbl
            // 
            this.autorLbl.AutoSize = true;
            this.autorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorLbl.Location = new System.Drawing.Point(90, 87);
            this.autorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autorLbl.Name = "autorLbl";
            this.autorLbl.Size = new System.Drawing.Size(61, 18);
            this.autorLbl.TabIndex = 1;
            this.autorLbl.Text = "autorLbl";
            // 
            // alugarBtn
            // 
            this.alugarBtn.Location = new System.Drawing.Point(35, 145);
            this.alugarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.alugarBtn.Name = "alugarBtn";
            this.alugarBtn.Size = new System.Drawing.Size(100, 28);
            this.alugarBtn.TabIndex = 2;
            this.alugarBtn.Text = "Alugar";
            this.alugarBtn.UseVisualStyleBackColor = true;
            this.alugarBtn.Click += new System.EventHandler(this.alugarBtn_Click);
            // 
            // categoriaLbl
            // 
            this.categoriaLbl.AutoSize = true;
            this.categoriaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLbl.Location = new System.Drawing.Point(113, 114);
            this.categoriaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoriaLbl.Name = "categoriaLbl";
            this.categoriaLbl.Size = new System.Drawing.Size(63, 18);
            this.categoriaLbl.TabIndex = 3;
            this.categoriaLbl.Text = "categLbl";
            // 
            // precoLbl
            // 
            this.precoLbl.AutoSize = true;
            this.precoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoLbl.Location = new System.Drawing.Point(90, 58);
            this.precoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precoLbl.Name = "precoLbl";
            this.precoLbl.Size = new System.Drawing.Size(65, 18);
            this.precoLbl.TabIndex = 4;
            this.precoLbl.Text = "precoLbl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor:";
            // 
            // editarLivroBtn
            // 
            this.editarLivroBtn.Location = new System.Drawing.Point(8, 67);
            this.editarLivroBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editarLivroBtn.Name = "editarLivroBtn";
            this.editarLivroBtn.Size = new System.Drawing.Size(87, 28);
            this.editarLivroBtn.TabIndex = 9;
            this.editarLivroBtn.Text = "Editar";
            this.editarLivroBtn.UseVisualStyleBackColor = true;
            this.editarLivroBtn.Click += new System.EventHandler(this.editarLivroBtn_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.qtdLbl);
            this.adminPanel.Controls.Add(this.label5);
            this.adminPanel.Controls.Add(this.statusLbl);
            this.adminPanel.Controls.Add(this.label4);
            this.adminPanel.Controls.Add(this.deletarBtn);
            this.adminPanel.Controls.Add(this.editarLivroBtn);
            this.adminPanel.Location = new System.Drawing.Point(-1, 135);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(209, 99);
            this.adminPanel.TabIndex = 10;
            // 
            // deletarBtn
            // 
            this.deletarBtn.Location = new System.Drawing.Point(103, 67);
            this.deletarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deletarBtn.Name = "deletarBtn";
            this.deletarBtn.Size = new System.Drawing.Size(87, 28);
            this.deletarBtn.TabIndex = 10;
            this.deletarBtn.Text = "Deletar";
            this.deletarBtn.UseVisualStyleBackColor = true;
            this.deletarBtn.Click += new System.EventHandler(this.deletarBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(100, 32);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(67, 18);
            this.statusLbl.TabIndex = 13;
            this.statusLbl.Text = "statusLbl";
            // 
            // qtdLbl
            // 
            this.qtdLbl.AutoSize = true;
            this.qtdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdLbl.Location = new System.Drawing.Point(127, 10);
            this.qtdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtdLbl.Name = "qtdLbl";
            this.qtdLbl.Size = new System.Drawing.Size(47, 18);
            this.qtdLbl.TabIndex = 15;
            this.qtdLbl.Text = "qtdLbl";
            // 
            // LivroCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.precoLbl);
            this.Controls.Add(this.categoriaLbl);
            this.Controls.Add(this.alugarBtn);
            this.Controls.Add(this.autorLbl);
            this.Controls.Add(this.tituloLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LivroCard";
            this.Size = new System.Drawing.Size(211, 237);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.Label autorLbl;
        private System.Windows.Forms.Button alugarBtn;
        private System.Windows.Forms.Label categoriaLbl;
        private System.Windows.Forms.Label precoLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editarLivroBtn;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button deletarBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label qtdLbl;
    }
}
