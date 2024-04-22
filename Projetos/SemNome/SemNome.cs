using System;
using Internal;

class SemNome{
    static void Main(){
        string[] Nomes = new string[10];

        DateTime Agora = DateTime.Now; // Define Agora como Date
        Console.WriteLine("Horario local: {0}",Agora.ToString()); // Exibe Data e Hora 

        for(int i=0; i < Nomes.Length; i++){
            Console.WriteLine("Digite o {0} nome: ", i+1);
            Nomes[i] = Console.ReadLine();
        }
        foreach(string n in Nomes){
            Console.WriteLine(n);
        }
    }
}