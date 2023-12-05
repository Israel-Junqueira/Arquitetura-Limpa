using ExerciciosRefatoracao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Aplicação.DTO
{
    public class CLientePFDTO
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string EndBairro { get; set; }
        public EndEntregaPFRequest EndEntrega { get; set; }
        public EndCobrancaPFRequest EndCobranca { get; set; }
        public EndFaturamentoPFRequest EndFaturamento { get; set; }
        public CLientePFDTO()
        {
            // Inicialize as instâncias para evitar NullReferenceException
            EndEntrega = new EndEntregaPFRequest();
            EndCobranca = new EndCobrancaPFRequest();
            EndFaturamento = new EndFaturamentoPFRequest();
        }
    }
 
    public class EndCobrancaPFRequest : EnderecoClienteRequestHeranca
    {

    }

    public class EndFaturamentoPFRequest : EnderecoClienteRequestHeranca
    {

    }

    public class EndEntregaPFRequest : EnderecoClienteRequestHeranca
    {
    }
}
