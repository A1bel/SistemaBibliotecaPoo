namespace SistemaBibliotecaPoo.Views
{
    partial class MeusLivros
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
            this.MeusLivrosDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MeusLivrosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MeusLivrosDgv
            // 
            this.MeusLivrosDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeusLivrosDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MeusLivrosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MeusLivrosDgv.Location = new System.Drawing.Point(12, 29);
            this.MeusLivrosDgv.Name = "MeusLivrosDgv";
            this.MeusLivrosDgv.RowHeadersWidth = 51;
            this.MeusLivrosDgv.RowTemplate.Height = 24;
            this.MeusLivrosDgv.Size = new System.Drawing.Size(763, 399);
            this.MeusLivrosDgv.TabIndex = 0;
            this.MeusLivrosDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MeusLivrosDgv_CellClick);
            // 
            // MeusLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MeusLivrosDgv);
            this.Name = "MeusLivros";
            this.Text = "MeusLivros";
            ((System.ComponentModel.ISupportInitialize)(this.MeusLivrosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MeusLivrosDgv;
    }
}