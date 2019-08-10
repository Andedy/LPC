using System.Collections.Generic;

namespace aula02
{
    public class Correntista
    {
        public Correntista(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public int codigo { get; private set; } 
        public string nome { get; private set; }

 
    }
}