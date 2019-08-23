using System;

namespace diagramalivraria
{
    public class Revistas
    {
        private string Colecao{ get; set; }
        private string Editora{ get; set; }
        private Artigos artigos = new Artigos();

        public void MostraDetalhes(){
            Console.WriteLine(this.Colecao);
            Console.WriteLine(this.Editora);
            Console.WriteLine(this.artigos);
        }
    }
}  