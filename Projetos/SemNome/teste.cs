using System;
using Internal;

class teste{
    public static void Main(){

        string[] Testes = new string[2]{"Null", "teste"};

        int CpfsCad = Array.IndexOf(Testes, "Null");
        if(CpfsCad < 0){
            Console.WriteLine(CpfsCad);
        }else{
            Console.WriteLine("Fodase");
        }
        

    }
}