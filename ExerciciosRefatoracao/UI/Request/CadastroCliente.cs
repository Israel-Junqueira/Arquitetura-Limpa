using ExerciciosRefatoracao.Aplicação.Interfaces;
using ExerciciosRefatoracao.UI.Interfaces;
using ExerciciosRefatoracao.UI.Interfaces.Servicos;
using ExerciciosRefatoracao.UI.Request.TiposCliente;


namespace ExerciciosRefatoracao.UI
{
    public class CadastroCliente
    {
        private IClienteServiceAplication _clienteService;

        public CadastroCliente(IClienteServiceAplication clientePFService)
        {
            this._clienteService = clientePFService;
        }
        public void Load()
        {
            string tipoPessoa;

            do
            {
                Console.Write("Tipo Cliente (F - Física / J - Jurídica): ");
                tipoPessoa = Console.ReadLine();

                if (!tipoPessoa.Equals("F") && !tipoPessoa.Equals("J"))
                {
                    Console.WriteLine("Tipo de Cliente inválido! Opções válidas F - Física / J - Jurídica!");
                    Console.ReadKey();                    
                }
            } while (!tipoPessoa.Equals("F") && !tipoPessoa.Equals("J"));

            if (tipoPessoa.Equals("F"))
            {
                MostrarCabecalho();
                _clienteService.CadastrarPF(new CadastroPF().CriaObjetoPFRequestUI());// retono CLientePFDTO
            }
            else
                _clienteService.CadastrarPJ(new CadastroPJ().CriaObjetoPFRequestUI()); 
        }

        private void MostrarCabecalho()
        {
            Console.Clear();
            Console.WriteLine("\n[CADASTRO DE CLIENTE PESSOA FÍSICA]");
        }

    }
}
