using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    class Candidato
    {
        public string Numero { get; set; }
        public string Nome { get; set; }
        public string Chapa { get; set; }
        public string Imagem { get; set; }
        public int Voto { get; set; }

        public Candidato(string numero, string nome, string chapa, string imagem, int voto)
        {
            this.Numero = numero;
            this.Nome = nome;
            this.Chapa = chapa;
            this.Imagem = imagem;
            this.Voto = voto; 
        }
    }
}
