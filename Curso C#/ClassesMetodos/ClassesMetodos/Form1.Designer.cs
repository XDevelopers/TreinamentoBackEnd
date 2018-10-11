namespace ClassesMetodos
{
    partial class Form1
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
            if (disposing && (components != null)) {
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
            this.cmd_executar = new System.Windows.Forms.Button();
            this.caixa_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(164, 163);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // caixa_texto
            // 
            this.caixa_texto.AutoSize = true;
            this.caixa_texto.Location = new System.Drawing.Point(12, 9);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(35, 13);
            this.caixa_texto.TabIndex = 1;
            this.caixa_texto.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 295);
            this.Controls.Add(this.caixa_texto);
            this.Controls.Add(this.cmd_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Label caixa_texto;
    }
}

