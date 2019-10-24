namespace diagramalivraria
{
    public class Materiais
    {
        public Materiais(int codigo, string assunto, string titulo)
        {
            this.codigo = codigo;
            this.assunto = assunto;
            this.titulo = titulo;
        }

        public int codigo { get; set; }
        public string assunto { get; set; }
        public string titulo { get; set; }
        

        private Revistas revista ;

        public void emprestar(){

        }
        public void devolver(){

        }
    }
}