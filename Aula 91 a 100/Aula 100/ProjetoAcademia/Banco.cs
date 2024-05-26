using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace ProjetoAcademia
{
    class Banco
    {
        private static SQLiteConnection conexao;
        
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = D:\\Jogos Não Steam\\Programação\\Aulas C#\\Aula 91 a 100\\Aula 100\\ProjetoAcademia\\banco\\banco_academia.db");
            conexao.Open();
            return conexao;
        }



    }
}
