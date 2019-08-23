using System;

namespace diagramalivraria
{
    public class Livros
    {
        private string Editora{ get; set; }
        private string Edicao{ get; set; }
        public string ISBN { get; set; }
        public string Autor { get; set; }

        private Artigos artigos = new Artigos();

        public void MostraDetalhes(){
            Console.WriteLine(this.Editora);
            Console.WriteLine(this.Edicao);
            Console.WriteLine(this.ISBN);
            Console.WriteLine(this.Autor);
            Console.WriteLine(this.artigos);
        }
    }
}  