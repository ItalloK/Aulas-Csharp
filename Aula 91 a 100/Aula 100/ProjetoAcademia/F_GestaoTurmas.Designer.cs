namespace ProjetoAcademia
{
    partial class F_GestaoTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_imprimirturma = new System.Windows.Forms.Button();
            this.btn_excluirturma = new System.Windows.Forms.Button();
            this.btn_salvaredicoes = new System.Windows.Forms.Button();
            this.btn_novaturma = new System.Windows.Forms.Button();
            this.lbl_professor = new System.Windows.Forms.Label();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_imprimirturma);
            this.panel1.Controls.Add(this.btn_excluirturma);
            this.panel1.Controls.Add(this.btn_salvaredicoes);
            this.panel1.Controls.Add(this.btn_novaturma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 29);
            this.panel1.TabIndex = 1;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(543, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(105, 23);
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_imprimirturma
            // 
            this.btn_imprimirturma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimirturma.Location = new System.Drawing.Point(411, 3);
            this.btn_imprimirturma.Name = "btn_imprimirturma";
            this.btn_imprimirturma.Size = new System.Drawing.Size(126, 23);
            this.btn_imprimirturma.TabIndex = 8;
            this.btn_imprimirturma.Text = "Imprimir Turma";
            this.btn_imprimirturma.UseVisualStyleBackColor = true;
            // 
            // btn_excluirturma
            // 
            this.btn_excluirturma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirturma.Location = new System.Drawing.Point(293, 3);
            this.btn_excluirturma.Name = "btn_excluirturma";
            this.btn_excluirturma.Size = new System.Drawing.Size(112, 23);
            this.btn_excluirturma.TabIndex = 7;
            this.btn_excluirturma.Text = "Excluir Turma";
            this.btn_excluirturma.UseVisualStyleBackColor = true;
            // 
            // btn_salvaredicoes
            // 
            this.btn_salvaredicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvaredicoes.Location = new System.Drawing.Point(161, 3);
            this.btn_salvaredicoes.Name = "btn_salvaredicoes";
            this.btn_salvaredicoes.Size = new System.Drawing.Size(126, 23);
            this.btn_salvaredicoes.TabIndex = 6;
            this.btn_salvaredicoes.Text = "Salvar Edições";
            this.btn_salvaredicoes.UseVisualStyleBackColor = true;
            // 
            // btn_novaturma
            // 
            this.btn_novaturma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novaturma.Location = new System.Drawing.Point(3, 3);
            this.btn_novaturma.Name = "btn_novaturma";
            this.btn_novaturma.Size = new System.Drawing.Size(152, 23);
            this.btn_novaturma.TabIndex = 5;
            this.btn_novaturma.Text = "Nova Turma";
            this.btn_novaturma.UseVisualStyleBackColor = true;
            // 
            // lbl_professor
            // 
            this.lbl_professor.AutoSize = true;
            this.lbl_professor.Location = new System.Drawing.Point(389, 12);
            this.lbl_professor.Name = "lbl_professor";
            this.lbl_professor.Size = new System.Drawing.Size(51, 13);
            this.lbl_professor.TabIndex = 2;
            this.lbl_professor.Text = "Professor";
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(392, 28);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(247, 21);
            this.cb_professor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maximo Alunos";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(529, 90);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(110, 21);
            this.cb_status.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horario";
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(392, 152);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(247, 21);
            this.cb_horario.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(392, 91);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(113, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.Location = new System.Drawing.Point(12, 12);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(371, 403);
            this.dgv_turmas.TabIndex = 11;
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.dgv_turmas);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.lbl_professor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salvaredicoes;
        private System.Windows.Forms.Button btn_novaturma;
        private System.Windows.Forms.Button btn_imprimirturma;
        private System.Windows.Forms.Button btn_excluirturma;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_professor;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dgv_turmas;
    }
}