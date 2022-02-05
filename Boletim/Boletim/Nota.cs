using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    class Nota
    {
        private string nome;
        private string turma;
        private double nota1;
        private double nota2;
        private double media;

        public string Nome { get => nome; set => nome = value; }
        public string Turma { get => turma; set => turma = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Media { get => media; set => media = value; }
    }
}
