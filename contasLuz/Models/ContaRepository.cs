using System.Collections.Generic;
namespace contasLuz.Models
{
    public class ContaRepository
    {
        public static List<Conta> contas = new List<Conta>();
    
        public ContaRepository()
        {           
        }

        public void Create(Conta Conta)
        {
            contas.Add(Conta);
        }
        public List<Conta> GetAll()
        {
            return contas;
        }
        
        public Conta GetById(int numeroLeitura)
        {
            return contas.Find(i=>i.numeroLeitura == numeroLeitura);
        }
        public void Delete(int numeroLeitura)
        {
            contas.Remove(GetById(numeroLeitura));
        }

        public void Update(Conta Conta)
        {
            var i = contas.FindIndex(x=>x.numeroLeitura == Conta.numeroLeitura);
            contas[i].numeroLeitura = Conta.numeroLeitura;
            contas[i].dataLeitura = Conta.dataLeitura;
            contas[i].kwGasto = Conta.kwGasto;
            contas[i].valorPagar = Conta.valorPagar;
            contas[i].dataPagamento = Conta.dataPagamento;
            contas[i].mediaConsumo = Conta.mediaConsumo;
        }

    }
}
