using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> aluno = new List<Aluno>();
            aluno.Add(new Aluno { nome = "Santos", idade = 14, nota = 8 });
            aluno.Add(new Aluno { nome = "Silva", idade = 12, nota = 6 });
            aluno.Add(new Aluno { nome = "Pereira", idade = 13, nota = 9 });
            aluno.Add(new Aluno { nome = "Santana", idade = 11, nota = 5 });

            foreach (var estudante in aluno)
            {
                Console.WriteLine((" " + estudante.nome + "\t"));
                Console.WriteLine((" Idade: " + estudante.idade + "\t"));

                Console.WriteLine(" Nota final: " + estudante.nota + "\t" + "\n");

            }
            int[] notas = { 8, 6, 9, 5 };
            int soma = notas.Sum();
            Console.WriteLine(" A Soma das notas: " + soma);
        }
    }
}
