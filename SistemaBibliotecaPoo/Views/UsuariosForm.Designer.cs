namespace SistemaBibliotecaPoo.Views
{
    partial class UsuariosForm
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
            this.voltarBtn = new System.Windows.Forms.Button();
            this.usuariosDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(26, 8);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(81, 33);
            this.voltarBtn.TabIndex = 2;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // usuariosDgv
            // 
            this.usuariosDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuariosDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuariosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDgv.Location = new System.Drawing.Point(26, 47);
            this.usuariosDgv.Name = "usuariosDgv";
            this.usuariosDgv.RowHeadersWidth = 51;
            this.usuariosDgv.RowTemplate.Height = 24;
            this.usuariosDgv.Size = new System.Drawing.Size(766, 391);
            this.usuariosDgv.TabIndex = 3;
            this.usuariosDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosDgv_CellClick);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.usuariosDgv);
            this.Controls.Add(this.voltarBtn);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.DataGridView usuariosDgv;
    }
}