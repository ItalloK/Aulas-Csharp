using System;
using Internal;

struct Usuario{
    public string[] Nome = new string[5];
    public int[] Idade = new Idade[5];
    public string[] Email = new string[5];
}

class Program{
    static void Main(){
        Usuario US1;
        for(int i = 0; i<5; i++){
            Console.WriteLine("Digite o nome do Usuario: ");
            US1[i].Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do Usuário: ");
            US1[i].Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email do Usuario: ");
            US1[i].Email = Console.ReadLine();
        }
        for(int i = 0; i<5; i++){
            Console.WriteLine("ID{0}... Nome: {1}, Idade: {2}, Email: {3}", i+1, US1.Nome, US1.Idade, US1.Email);
        }
        

    }
}