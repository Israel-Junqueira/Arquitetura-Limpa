
using ExerciciosRefatoracao.Aplicação.DTO;
using ExerciciosRefatoracao.Aplicação.Interfaces;
using ExerciciosRefatoracao.Aplicação.Servico;
using ExerciciosRefatoracao.Dominio.Interfaces.Repositorio;
using ExerciciosRefatoracao.Dominio.Interfaces.Servico;
using ExerciciosRefatoracao.Dominio.Services;
using ExerciciosRefatoracao.Infraestrutura.Repository;
using ExerciciosRefatoracao.UI.Interfaces.Servicos;

namespace ExerciciosRefatoracao.UI
{
    public class TelaPrincipal
    {
        IClienteRepository _clienteRepositoryDomainRepository;
        IClienteServicoDomain _clienteServicoDomainService;
        IClienteServiceAplication _clienteServiceAplication;
      
        public TelaPrincipal(ConsoleColor ForegroundColor)
        {
         
            this._clienteRepositoryDomainRepository = new ClienteRepository();
                       
            this._clienteServicoDomainService = new ClienteServicoDomain(_clienteRepositoryDomainRepository);
            
            
            this._clienteServiceAplication = new ClientePFServiceApplication(_clienteServicoDomainService);            
            Console.ForegroundColor = ForegroundColor;
        
            
           
        }

        public void Load()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(MostrarCabecalho());
                Console.WriteLine(MostrarMenu());
                opcao = LerOpcaoMenu();
                ProcessarOpcaoMenu(opcao);
            } while (opcao != "0");
        }

        private static string MostrarCabecalho()
        {
            return "[ CADASTRO DE CLIENTES - EMPRESA FORNECEDORA DO BRASIL ]\n";
        }

        private static string MostrarMenu()
        {
            string menu = "   Escolha uma opção:\n\n" +
                            "   1 - Cadastrar Cliente\n" +
                            "   2 - Listar Clientes\n" +
                            "   0 - Sair do Programa \n";
            return menu;
        }

        private static string LerOpcaoMenu()
        {
            string opcao;
            Console.Write("Opção desejada: ");
            opcao = Console.ReadLine();
            return opcao;
        }

        private void ProcessarOpcaoMenu(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    new CadastroCliente(this._clienteServiceAplication).Load();
                    break;
                case "2":
                    var Cliente = new ListaClientes(this._clienteServiceAplication).GetListCliente();
                    if (Cliente.lstPessoaFisica.Count > 0)
                        foreach (var item in Cliente.lstPessoaFisica)
                    {

                        Console.WriteLine("===Dados do Cliente Pessoa Fisica===\n");
                        Console.WriteLine($"CPF: {item.CPF}\n");
                        Console.WriteLine($"Nome:  {item.Nome}\n");
                        Console.WriteLine($"Endereço Faturamento: -CEP - {item.EndFaturamento.EndComplemento} - {item.EndFaturamento.EndCEP} - {item.EndFaturamento.EndMunicipio} - {item.EndFaturamento.EndUF}");
                        Console.WriteLine($"Endereço Cobrança: -CEP  {item.EndCobranca.EndComplemento} - {item.EndCobranca.EndCEP} - {item.EndCobranca.EndMunicipio} - {item.EndCobranca.EndUF}");
                        Console.WriteLine($"Endereço Entrega: - CEP  {item.EndEntrega.EndComplemento} - {item.EndEntrega.EndCEP} - {item.EndEntrega.EndMunicipio} - {item.EndEntrega.EndUF}");
                    }
                    if(Cliente.lstPessoaJuridica.Count > 0)
                    foreach (var item in Cliente.lstPessoaJuridica)
                    {

                        Console.WriteLine("===Dados do Cliente Pessoa Juridica===\n");
                        Console.WriteLine($"CPF: {item.CNPJ}\n");
                        Console.WriteLine($"Nome:  {item.Nome}\n");
                        Console.WriteLine($"Endereço Faturamento: -CEP - {item.EndFaturamento.EndComplemento} - {item.EndFaturamento.EndCEP} - {item.EndFaturamento.EndMunicipio} - {item.EndFaturamento.EndUF}");
                        Console.WriteLine($"Endereço Cobrança: -CEP  {item.EndCobranca.EndComplemento} - {item.EndCobranca.EndCEP} - {item.EndCobranca.EndMunicipio} - {item.EndCobranca.EndUF}");
                        Console.WriteLine($"Endereço Entrega: - CEP  {item.EndEntrega.EndComplemento} - {item.EndEntrega.EndCEP} - {item.EndEntrega.EndMunicipio} - {item.EndEntrega.EndUF}");
                    }
                    break;
                case "0":
                    Console.WriteLine("Obrigado por utilizar o programa.");
                    break;
                default:
                    Console.WriteLine("Opção de menu inválida!");
                    break;
            }
        }
    }
} 
