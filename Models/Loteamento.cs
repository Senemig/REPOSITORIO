using System;

namespace Etapa_No._2.Models
{
    
    public class Loteamento
    {
        // representar os atributos da classe considerando a tipagem
    
        public int Id {get; set;}
        public string Nome_Lote {get; set;}
        public string Nome_Cliente {get; set;} 
        public string CPF {get; set;} 
        public float Valor_Lote {get; set;}
        public float Entrada {get; set;}
        public int Qtd_Parcelas {get; set;}
        public float Valor_Parcela {get; set;}
        public DateTime Data_Contrato {get; set;}
       
        // representar os atributos da classe considerando a tipagem
   }
}