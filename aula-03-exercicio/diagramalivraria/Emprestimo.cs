namespace diagramalivraria
{
    public class Emprestimo
    {
        private string DataEmprestimo{ get; set; }
        private string DataRetorno{ get; set; }
        private bool atraso{ get; set; }

        private Materiais material = new Materiais();

        private Usuarios usuario = new Usuarios();

        public void novo(){

        }
    }
}