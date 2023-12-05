using ExerciciosRefatoracao.Aplicação.DTO;
using ExerciciosRefatoracao.Aplicação.Interfaces;
using ExerciciosRefatoracao.Dominio.Interfaces.Repositorio;
using ExerciciosRefatoracao.Infraestrutura.Repository;
using ExerciciosRefatoracao.UI.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.UI.Request.TiposCliente
{
    public class CadastroPJ 
    {
        public ClientePJDTO CriaObjetoPFRequestUI()
        {
            ClientePJDTO clientePessoaJuridica = new ClientePJDTO();

            Console.Write("Nº CPF: ");
            clientePessoaJuridica.CNPJ = Console.ReadLine();
            Console.Write("Nome Cliente: ");
            clientePessoaJuridica.Nome = Console.ReadLine();
            Console.Write("Bairro Cliente: ");
            clientePessoaJuridica.EndBairro = Console.ReadLine();

            SetEnderecoCobranca(clientePessoaJuridica);
            SetEnderecoEntrega(clientePessoaJuridica);
            SetEnderecoFaturamento(clientePessoaJuridica);

            return clientePessoaJuridica;
        }

        public void SetEnderecoCobranca(ClientePJDTO cliente)
        {

            Console.WriteLine("");
            Console.WriteLine("********* Informe abaixo o Endereço de Cobrança **************");
            Console.Write("Logradouro: ");
            cliente.EndCobranca.EndLogradouro = Console.ReadLine();
            Console.Write("Número: ");
            cliente.EndCobranca.EndNumero = Console.ReadLine();
            Console.Write("Complemento: ");
            cliente.EndCobranca.EndComplemento = Console.ReadLine();
            Console.Write("CEP: ");
            cliente.EndCobranca.EndCEP = Console.ReadLine();
            Console.Write("Municipio: ");
            cliente.EndCobranca.EndMunicipio = Console.ReadLine();
            Console.Write("UF: ");
            cliente.EndCobranca.EndUF = Console.ReadLine();
        }

        public void SetEnderecoEntrega(ClientePJDTO cliente)
        {
            Console.WriteLine("");
            Console.WriteLine("********* Informe abaixo o Endereço de Entrega **************");
            Console.Write("Logradouro: ");
            cliente.EndEntrega.EndLogradouro = Console.ReadLine();
            Console.Write("Número: ");
            cliente.EndEntrega.EndNumero = Console.ReadLine();
            Console.Write("Complemento: ");
            cliente.EndEntrega.EndComplemento = Console.ReadLine();
            Console.Write("CEP: ");
            cliente.EndEntrega.EndCEP = Console.ReadLine();
            Console.Write("Municipio: ");
            cliente.EndEntrega.EndMunicipio = Console.ReadLine();
            Console.Write("UF: ");
            cliente.EndEntrega.EndUF = Console.ReadLine();
        }

        public void SetEnderecoFaturamento(ClientePJDTO cliente)
        {
            Console.WriteLine("");
            Console.WriteLine("********* Informe abaixo o Endereço de Faturamento **************");
            Console.Write("Logradouro: ");
            cliente.EndFaturamento.EndLogradouro = Console.ReadLine();
            Console.Write("Número: ");
            cliente.EndFaturamento.EndNumero = Console.ReadLine();
            Console.Write("Complemento: ");
            cliente.EndFaturamento.EndComplemento = Console.ReadLine();
            Console.Write("CEP: ");
            cliente.EndFaturamento.EndCEP = Console.ReadLine();
            Console.Write("Municipio: ");
            cliente.EndFaturamento.EndMunicipio = Console.ReadLine();
            Console.Write("UF: ");
            cliente.EndFaturamento.EndUF = Console.ReadLine();
        }
    }
}
