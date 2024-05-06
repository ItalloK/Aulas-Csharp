namespace Aula60
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
            this.btn_butaozinho = new System.Windows.Forms.Button();
            this.lb_apenasumtexto = new System.Windows.Forms.Label();
            this.tb_entradadetexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_butaozinho
            // 
            this.btn_butaozinho.BackColor = System.Drawing.Color.Black;
            this.btn_butaozinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_butaozinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_butaozinho.Location = new System.Drawing.Point(224, 158);
            this.btn_butaozinho.Name = "btn_butaozinho";
            this.btn_butaozinho.Size = new System.Drawing.Size(219, 45);
            this.btn_butaozinho.TabIndex = 0;
            this.btn_butaozinho.Text = "Butaozinho";
            this.btn_butaozinho.UseVisualStyleBackColor = false;
            // 
            // lb_apenasumtexto
            // 
            this.lb_apenasumtexto.AutoSize = true;
            this.lb_apenasumtexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_apenasumtexto.Location = new System.Drawing.Point(220, 135);
            this.lb_apenasumtexto.Name = "lb_apenasumtexto";
            this.lb_apenasumtexto.Size = new System.Drawing.Size(223, 20);
            this.lb_apenasumtexto.TabIndex = 1;
            this.lb_apenasumtexto.Text = "Apenas um Texto qualquer";
            // 
            // tb_entradadetexto
            // 
            this.tb_entradadetexto.Location = new System.Drawing.Point(224, 209);
            this.tb_entradadetexto.Name = "tb_entradadetexto";
            this.tb_entradadetexto.Size = new System.Drawing.Size(219, 20);
            this.tb_entradadetexto.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 428);
            this.Controls.Add(this.tb_entradadetexto);
            this.Controls.Add(this.lb_apenasumtexto);
            this.Controls.Add(this.btn_butaozinho);
            this.Name = "Form1";
            this.Text = "Curso de C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_butaozinho;
        private System.Windows.Forms.Label lb_apenasumtexto;
        private System.Windows.Forms.TextBox tb_entradadetexto;
    }
}

