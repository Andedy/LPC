using System;

namespace diagramalivraria
{
    public class Livros : Materiais
    {
        private string editora{ get; set; }
        private string edicao{ get; set; }
        public string isbn { get; set; }
        public string autor { get; set; }

        private Artigos artigos = new Artigos();

        public Livros(int codigo, string assunto, string titulo) : base (codigo, assunto, titulo)
        {
            this.editora = editora;
            this.edicao = edicao;
            this.isbn = isbn;
            this.autor = autor;
        }

        public void MostraDetalhes(){
            Console.WriteLine(this.editora);
            Console.WriteLine(this.edicao);
            Console.WriteLine(this.isbn);
            Console.WriteLine(this.autor);
            Console.WriteLine(this.artigos);
        }
    }
}  