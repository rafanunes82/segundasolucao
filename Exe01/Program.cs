using System;

namespace Exe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //quero cadastrar 2 alunos e suas 2 duas notas
            //quero calcular a média destas notas
            //se média maior 6 aprovado senão reprovado
            string aluno1 = "Michael";
            string aluno2 = "Andrea";

            double a1n1 = 0;
            double a1n2 = 0;
            double a2n1 = 0;
            double a2n2 = 0;

            double ma1 = 0;
            double ma2 = 0;

            if (ma1>6) { } else { }

            if (ma2<6) { } else { }

            Console.WriteLine($"Media aluno: {aluno1} - {ma1}");
            Console.WriteLine($"Media aluno: {aluno2} - {ma2}");
        }
    }
}
