using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Aplicação.DTO
{
    public class ClientePJDTO
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string EndBairro { get; set; }
        public EndEntregaPJRequest EndEntrega { get; set; }
        public EndCobrancaPJRequest EndCobranca { get; set; }
        public EndFaturamentoPJRequest EndFaturamento { get; set; }
        public ClientePJDTO()
        {
            // Inicialize as instâncias para evitar NullReferenceException
            EndEntrega = new EndEntregaPJRequest();
            EndCobranca = new EndCobrancaPJRequest();
            EndFaturamento = new EndFaturamentoPJRequest();
        }
    }

    public class EndCobrancaPJRequest : EnderecoClienteRequestHeranca
    {

    }

    public class EndFaturamentoPJRequest : EnderecoClienteRequestHeranca
    {

    }

    public class EndEntregaPJRequest : EnderecoClienteRequestHeranca
    {
    }
}

