using System;
using Internal;

class SemNome{

    static string[] Nomes = new string[5];
    static void Main(){
        DateTime Agora = DateTime.Now; // Define Agora como Date
        Console.WriteLine("Horario local: {0}",Agora.ToString()); // Exibe Data e Hora 
        for(int i=0; i < Nomes.Length; i++){
            Console.WriteLine("Digite o {0} nome: ", i+1);
            Nomes[i] = Console.ReadLine();
        }
        char Cond;
        Console.WriteLine("Deseja exibir nomes cadastrados? [S/N]");
        Cond = char.Parse(Console.ReadLine());
        switch(Cond){
            case 'S':
            case 's':{
                ExibirNomes();
                break;
            }
            case 'N':
            case 'n':{
                Console.WriteLine("Programa Encerrado.");
                break;
            }
            default:{
                Console.WriteLine("Letra incorreta, Encerrando Programa.");
                break;
            }
        }
    }
    static void ExibirNomes(){
        Console.WriteLine("Nomes Cadastrados: ");
        foreach(string n in Nomes){
            Console.WriteLine(n);
        }
    }

}