using System;

namespace diagramalivraria
{
    public class Usuarios
    {
        private string Nome{ get; set; }
        private string Local{ get; set; }
        private string Telefone{ get; set; }
        private string Senha{ get; set; }

        public void fazReserva(){
            Console.WriteLine("Reserva efetuada!");
        }
    }
}