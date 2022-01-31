using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_04
{
    class Aluno
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public double nota { get; set; }

        public void Nota()
        {
            Aluno[] aluno =
            {
                new Aluno{nome = "Santos", idade = 14 ,nota = 8},
                new Aluno{nome = "Silva", idade = 12, nota = 6},
                new Aluno{nome = "pereira", idade = 13, nota = 9},
                new Aluno{nome = "Santana", idade = 11, nota = 5}
            };
        }
    }
}