using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class F_GestaoTurmas : Form
    {
        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            string vqueryDGV = @"
                SELECT 
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'Turma',
                    tbh.T_DSCHORARIO as 'Horario' 
                FROM 
                    tb_turmas as tbt
                INNER JOIN 
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
            ";
            dgv_turmas.DataSource = Banco.dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 40    ;
            dgv_turmas.Columns[1].Width = 120;
            dgv_turmas.Columns[2].Width = 85;

            /* Popular combobox professores */

            string vqueryProfessores = @"
                SELECT 
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR 
                FROM
                    tb_professores 
                ORDER BY 
                    N_IDPROFESSOR
            ";

            cb_professor.Items.Clear(); // sempre limpar antes de iniciar
            cb_professor.DataSource = Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            /* Popular Combobox Status (Ativa = A, Paralisada = P, Cancelada = C) */

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa"); // A = Key -- Ativa == Value 
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.Items.Clear();//limpar antes de criar
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            /* Popular Combobox Horarios */

            string vqueryHorarios = @"
                SELECT 
                    * 
                FROM
                    tb_horarios 
                ORDER BY 
                    T_DSCHORARIO
            ";

            cb_horario.Items.Clear(); // sempre limpar antes de iniciar
            cb_horario.DataSource = Banco.dql(vqueryHorarios);
            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";
        }
    }
}
