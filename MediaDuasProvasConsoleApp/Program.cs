using System;

namespace MediaDuasProvasConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Aluno aluno = new Aluno();
            aluno.nome = "Marcos Lima";
            aluno.prova1 = 9.00m;
            aluno.prova2 = 10.00m;
            Console.WriteLine("Aluno {0} teve a media de {1}", aluno.nome, aluno.CalculaMedia().ToString("N2"));
            Console.ReadKey();
        }
    }
}
