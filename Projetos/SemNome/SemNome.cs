using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Internal;

/*  Coisas para implementar:
    1 - Trocar CPF de long para string ( está cortando o 0 na hora do cadastro )


*/

public class SemNome{

    static string[] Nomes = new string[5]{"NULL","NULL","NULL","NULL","NULL"};
    static long[] CPFS = new long[5]{123,456,789,987,654};
    static void Main(){
        //Console.Clear();
        DateTime Agora = DateTime.Now; // Define Agora como Date
        Console.WriteLine("Horario local: {0}",Agora.ToString()); // Exibe Data e Hora
        int Opcao;
        do{
            Console.WriteLine("1 - Cadastro.");
            Console.WriteLine("2 - Listar Cadastros.");
            Console.WriteLine("3 - Procurar por CPF.");
            Console.WriteLine("4 - Deletar Cadastro.");
            Console.WriteLine("5 - Encerrar Programa.");
            Console.Write("Digite a opção desejada: ");
            Opcao = int.Parse(Console.ReadLine());
        }while(Opcao < 1 || Opcao > 5);
        switch(Opcao){
            case 1:{
                int Procura = Array.IndexOf(Nomes, "NULL");
                if(Procura == -1){
                    Console.WriteLine("Maximo de nomes ja cadastrados.");
                    Main();
                }else{
                    Cadastro();
                }
                break;
            }
            case 2:{
                ListarCadastros();
                break;
            }
            case 3:{
                ProcurarPessoa();
                break;
            }
            case 4:{
                RemoverPessoas();
                break;
            }
            case 5:{
                Console.Clear();
                Console.WriteLine("Encerrando Programa.");
                Environment.Exit(0);
                break;
            }
        }
    }

    static void Cadastro(){ 
        Console.Clear();
        int Indice = Array.IndexOf(Nomes, "NULL");
        if(Indice != -1){
            Console.WriteLine("~~~~ CADASTRO ~~~~");
            Console.Write("Digite o nome a ser cadastrado: ");
            Nomes[Indice] = Console.ReadLine();
            Console.Write("Agora digite o CPF de {0} :", Nomes[Indice]);
            CPFS[Indice] = long.Parse(Console.ReadLine());
            Console.WriteLine("Nome: '{0}', CPF: '{1}', cadastrado com sucesso.", Nomes[Indice], CPFS[Indice]);
            Main();
        }else{
            Console.WriteLine("Não tem mais espaços para serem cadastrados.");
            Main();
        }        
    }
    static void ListarCadastros(){
        Console.Clear();
        Console.WriteLine("Nomes Cadastrados: ");
        for(int i = 0; i<Nomes.Length; i++){
            Console.WriteLine("Nome: '{0}' CPF: '{1}'", Nomes[i], CPFS[i]);
        }        
        
        char Cond;
        Console.WriteLine("Deseja voltar para o menu principal? [S/N]");
        Cond = char.Parse(Console.ReadLine());
        if(Cond == 'S' || Cond == 's'){
            Console.WriteLine("Voltando para menu principal.");
            Main();
        }else{
            Console.Clear();
            Console.WriteLine("Encerrando programa.");
            Environment.Exit(0);
        }
    }
    static void ProcurarPessoa(){
        Console.Clear();
        long CPF;
        Console.Write("Digite o CPF que deseja procurar: ");
        CPF = long.Parse(Console.ReadLine());
        int Indice = Array.IndexOf(CPFS, CPF);
        if(Indice != -1){
            Console.WriteLine("\nO CPF '{0}' foi encontrado no indice {1} o nome é: {2}", CPF, Indice, Nomes[Indice]);
        }else{
            Console.WriteLine("\nO CPF não foi encontrado.");
        }
        char Cond;
        Console.WriteLine("Deseja voltar para o menu principal? [S/N]");
        Cond = char.Parse(Console.ReadLine());
        if(Cond == 'S' || Cond == 's'){
            Console.WriteLine("Voltando para menu principal.");
            Main();
        }else{
            Console.Clear();
            Console.WriteLine("Encerrando programa.");
            Environment.Exit(0);
        }
    }

    static void RemoverPessoas(){
        Console.Clear();
        long CPF;
        Console.WriteLine("Digite o CPF da pessoa que deseja deletar: ");
        CPF = long.Parse(Console.ReadLine());
        int Indice = Array.IndexOf(CPFS, CPF);
        if(Indice != -1){
            Console.Write("\nO CPF procurado é: {0}, Nome:{1}... Deseja remover? [S/N]",CPF, Nomes[Indice]);
            char Cond;
            Cond = char.Parse(Console.ReadLine());
            if(Cond == 's' || Cond == 'S'){
                Console.WriteLine("Nome: '{0}' CPF: '{1}' Deletados com sucesso.", Nomes[Indice], CPFS[Indice]);
                Nomes[Indice] = "NULL";
                CPFS[Indice] = 000;
                Console.WriteLine("Voltando para o menu principal...");
                Main();
            }else if(Cond == 'n' || Cond == 'N'){
                Console.WriteLine("Esta pessoa não foi deletada... Voltando para menu principal.");
                Main();
            }else{
                Console.WriteLine("Condição digitada incorretamente... Encerrando programa.");
                Environment.Exit(0);
            }
        }else{
            Console.WriteLine("CPF não encontrado... Deseja tentar novamente? [S/N]");
            char Cond2;
            Cond2 = char.Parse(Console.ReadLine());
            if(Cond2 == 's' || Cond2 == 'S'){
                RemoverPessoas();
            }else{
                Console.WriteLine("Voltando para o menu principal...");
            }
        }
        
    }

}