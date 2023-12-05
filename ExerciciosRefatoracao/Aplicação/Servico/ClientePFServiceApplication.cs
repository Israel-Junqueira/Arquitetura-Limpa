
using ExerciciosRefatoracao.Aplicação.DTO;
using ExerciciosRefatoracao.Aplicação.Interfaces;
using ExerciciosRefatoracao.Dominio.Entities;
using ExerciciosRefatoracao.Dominio.Interfaces.Servico;
using ExerciciosRefatoracao.UI;

namespace ExerciciosRefatoracao.Aplicação.Servico
{

    public class ClientePFServiceApplication : IClienteServiceAplication
    {

        private readonly IClienteServicoDomain _servicedomain;
        public ClientePFServiceApplication(IClienteServicoDomain clienteServicoDomain)
        {
            this._servicedomain = clienteServicoDomain;
        }
        public void CadastrarPF(CLientePFDTO clientePFRequest)
        {
         
            ClientePessoaFisica clientePessoaFisica = new ClientePessoaFisica()
            {
                CPF = clientePFRequest.CPF,
                EndBairro = clientePFRequest.EndBairro,
                EndEntrega = new Dominio.Entities.EndEntrega()
                {
                    EndCEP = clientePFRequest.EndEntrega.EndCEP,
                    EndComplemento = clientePFRequest.EndEntrega.EndComplemento,
                    EndLogradouro = clientePFRequest.EndEntrega.EndLogradouro,
                    EndMunicipio = clientePFRequest.EndEntrega.EndMunicipio,
                    EndNumero = clientePFRequest.EndEntrega.EndNumero,
                    EndUF = clientePFRequest.EndEntrega.EndUF
                },
                EndCobranca = new Dominio.Entities.EndCobranca()
                {
                    EndCEP = clientePFRequest.EndCobranca.EndCEP,
                    EndComplemento = clientePFRequest.EndCobranca.EndComplemento,
                    EndLogradouro = clientePFRequest.EndCobranca.EndLogradouro,
                    EndMunicipio = clientePFRequest.EndCobranca.EndMunicipio,
                    EndNumero = clientePFRequest.EndCobranca.EndNumero,
                    EndUF = clientePFRequest.EndCobranca.EndUF
                },
                EndFaturamento = new Dominio.Entities.EndFaturamento()
                {
                    EndCEP = clientePFRequest.EndFaturamento.EndCEP,
                    EndComplemento = clientePFRequest.EndFaturamento.EndComplemento,
                    EndLogradouro = clientePFRequest.EndFaturamento.EndLogradouro,
                    EndMunicipio = clientePFRequest.EndFaturamento.EndMunicipio,
                    EndNumero = clientePFRequest.EndFaturamento.EndNumero,
                    EndUF = clientePFRequest.EndFaturamento.EndUF
                },
                Nome = clientePFRequest.Nome


            };
             _servicedomain.AdicionarPF(clientePessoaFisica);
        }
        public void CadastrarPJ(ClientePJDTO clientePJRequest)
        {
            ClientePessoaJuridica clientePessoaJuridica = new ClientePessoaJuridica()
            {
                CNPJ = clientePJRequest.CNPJ,
                EndBairro = clientePJRequest.EndBairro,
                EndEntrega = new Dominio.Entities.EndEntrega()
                {
                    EndCEP = clientePJRequest.EndEntrega.EndCEP,
                    EndComplemento = clientePJRequest.EndEntrega.EndComplemento,
                    EndLogradouro = clientePJRequest.EndEntrega.EndLogradouro,
                    EndMunicipio = clientePJRequest.EndEntrega.EndMunicipio,
                    EndNumero = clientePJRequest.EndEntrega.EndNumero,
                    EndUF = clientePJRequest.EndEntrega.EndUF
                },
                EndCobranca = new Dominio.Entities.EndCobranca()
                {
                    EndCEP = clientePJRequest.EndCobranca.EndCEP,
                    EndComplemento = clientePJRequest.EndCobranca.EndComplemento,
                    EndLogradouro = clientePJRequest.EndCobranca.EndLogradouro,
                    EndMunicipio = clientePJRequest.EndCobranca.EndMunicipio,
                    EndNumero = clientePJRequest.EndCobranca.EndNumero,
                    EndUF = clientePJRequest.EndCobranca.EndUF
                },
                EndFaturamento = new Dominio.Entities.EndFaturamento()
                {
                    EndCEP = clientePJRequest.EndFaturamento.EndCEP,
                    EndComplemento = clientePJRequest.EndFaturamento.EndComplemento,
                    EndLogradouro = clientePJRequest.EndFaturamento.EndLogradouro,
                    EndMunicipio = clientePJRequest.EndFaturamento.EndMunicipio,
                    EndNumero = clientePJRequest.EndFaturamento.EndNumero,
                    EndUF = clientePJRequest.EndFaturamento.EndUF
                },
                Nome = clientePJRequest.Nome

            };
            _servicedomain.AdicionarPJ(clientePessoaJuridica);
        }

        public Cliente GetListClientes()
        {
           return _servicedomain.GetListCliente();
        }

        public void CadastrarCliente() { 
        }
    }
}