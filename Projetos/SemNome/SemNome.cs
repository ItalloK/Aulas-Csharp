using System;
using System.Globalization;
using System.Threading.Tasks;
using Internal;

class SemNome{

    static string[] Nomes = new string[5];
    static int VetNomeUtilizado = 0;
    static void Main(){
        //Console.Clear();
        DateTime Agora = DateTime.Now; // Define Agora como Date
        Console.WriteLine("Horario local: {0}",Agora.ToString()); // Exibe Data e Hora
        int Opcao;
        do{
            Console.WriteLine("1 - Cadastro.");
            Console.WriteLine("2 - Listar Cadastros.");
            Console.WriteLine("3 - Encerrar Programa.");
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

}