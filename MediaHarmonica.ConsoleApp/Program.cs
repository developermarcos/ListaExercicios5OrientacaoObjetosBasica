using System;

namespace MediaHarmonica.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Aluno aluno = new Aluno();
            aluno.nome = "Marcos Lima";
            aluno.nota1 = 9.00m;
            aluno.nota2 = 7.00m;
            aluno.nota3 = 6.00m;
            aluno.nota4 = 8.00m;
            Console.WriteLine("Aluno {0} teve a media harmonica de {1}", aluno.nome, aluno.CalcularMediaHarmonica().ToString("N2"));
            Console.ReadKey();
        }
    }
}
