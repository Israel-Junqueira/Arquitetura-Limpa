using ExerciciosRefatoracao.Aplicação.DTO;
using ExerciciosRefatoracao.UI.Interfaces.Servicos;


namespace ExerciciosRefatoracao.UI.Request.TiposCliente
{
    public class CadastroPF:IClientePFCadastro
    {
        public CLientePFDTO CriaObjetoPFRequestUI()
        {
            CLientePFDTO clientePessoaFisica = new CLientePFDTO();

            Console.Write("Nº CPF: ");
            clientePessoaFisica.CPF = Console.ReadLine();
            Console.Write("Nome Cliente: ");
            clientePessoaFisica.Nome = Console.ReadLine();
            Console.Write("Bairro Cliente: ");
            clientePessoaFisica.EndBairro = Console.ReadLine();

            SetEnderecoCobranca(clientePessoaFisica);
            SetEnderecoEntrega(clientePessoaFisica);
            SetEnderecoFaturamento(clientePessoaFisica);

            return clientePessoaFisica;
        }
        public void SetEnderecoCobranca(CLientePFDTO cliente)
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
        public void SetEnderecoEntrega(CLientePFDTO cliente)
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
        public void SetEnderecoFaturamento(CLientePFDTO cliente)
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
