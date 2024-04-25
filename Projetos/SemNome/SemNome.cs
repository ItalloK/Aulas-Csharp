using System;
using System.Globalization;
using System.Threading.Tasks;
using Internal;

public class SemNome{

    static string[] Nomes = new string[5]{"Italo","Ana Clara","Bruno","Brenno","Pedro"};
    static int[] CPFS = new int[5]{123,456,789,098,765};
    static int VetNomeUtilizado = 0;
    static void Main(){
        //Console.Clear();
        DateTime Agora = DateTime.Now; // Define Agora como Date
        Console.WriteLine("Horario local: {0}",Agora.ToString()); // Exibe Data e Hora
        int Opcao;
        do{
            Console.WriteLine("1 - Cadastro.");
            Console.WriteLine("2 - Listar Cadastros.");
            Console.WriteLine("3 - Procurar por CPF.");
            Console.WriteLine("4 - Encerrar Programa.");
            Console.Write("Digite a opção desejada: ");
            Opcao = int.Parse(Console.ReadLine());
        }while(Opcao < 1 || Opcao > 3);
        switch(Opcao){
            case 1:{
                if(VetNomeUtilizado >= Nomes.Length){
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
                Console.Clear();
                Console.WriteLine("Encerrando Programa.");
                Environment.Exit(0);
                break;
            }
        }
    }

    static void Cadastro(){
        char Cond;
        //Console.Clear();
        Console.WriteLine("~~~~ CADASTRO ~~~~");
        for(int i = VetNomeUtilizado; i<Nomes.Length; i++){
            Console.Write("Digite o nome a ser cadastrado: ");
            Nomes[i] = Console.ReadLine();
            VetNomeUtilizado++;
            Console.WriteLine("Deseja cadastrar outro nome? [S/N]");
            Cond = char.Parse(Console.ReadLine());
            if(Cond == 'S' || Cond == 's'){
                if(VetNomeUtilizado >= Nomes.Length){
                    Console.WriteLine("Maximo de nomes ja cadastrados.");
                    Main();
                }
                continue;
            }else{
                Main();
            }
        }
    }
    static void ListarCadastros(){
        Console.Clear();
        Console.WriteLine("Nomes Cadastrados: ");
        foreach(string n in Nomes){
            Console.WriteLine(n);
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
        int CPF;
        Console.Write("Digite o CPF que deseja procurar: ");
        CPF = int.Parse(Console.ReadLine());
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

}