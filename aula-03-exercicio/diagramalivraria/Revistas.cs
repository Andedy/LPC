using System;

namespace diagramalivraria
{
    public class Revistas : Materiais
    {
    
        public Revistas(int codigo, string assunto, string titulo) : base (codigo,assunto,titulo)
        {
            this.colecao = colecao;
            this.editora = editora;
            this.codigo = codigo;
            this.assunto = assunto;
            this.titulo = titulo;
            
        }

        public string colecao { get; set; }
        public string editora { get; set; }
        public Materiais material { get; set; }

        public void mostraDetalhes(){
            Console.WriteLine(this.colecao);
            Console.WriteLine(this.editora);

        }
    }
}  
