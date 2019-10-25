using System.Collections.Generic;

namespace contasLuz.Domain.Entities
{

    public class Imovel
    {
        public Imovel(){
        }

        public Imovel(int id, string identificacao, int numero, string bairro, string cidade, string estado){
            this.id = id;
            this.identificacao = identificacao;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;       
        }
            public int id { get; set; }
            public string identificacao { get; set; }
            public int numero { get; set; }
            public string bairro { get; set; }
            public string cidade {get; set; }
            public string estado { get; set; }

    }    

    
}