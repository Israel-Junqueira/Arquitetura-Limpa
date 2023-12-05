using ExerciciosRefatoracao.Dominio.Entities;
using ExerciciosRefatoracao.Dominio.Interfaces.Repositorio;

namespace ExerciciosRefatoracao.Infraestrutura.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public Cliente Clientes;                     
        public ClienteRepository()
        {
            Clientes = new Cliente();
        }
         public bool AdicionarPF(ClientePessoaFisica cliente)
        {
            Console.WriteLine("Deseja Salvar o Cliente? (S/N)");
            string resposta = Console.ReadLine();
            if (resposta.Equals("S"))
            {

                Clientes.lstPessoaFisica.Add(cliente);
                
                 Console.WriteLine("Cliente Salvo com sucesso !!");
                
                return true;
            }
            return false;
        }

        public bool AdicionarPJ(ClientePessoaJuridica cliente)
        {
            Console.WriteLine("Deseja Salvar o Cliente? (S/N)");
            string resposta = Console.ReadLine();
            if (resposta.Equals("S"))
            {

                Clientes.lstPessoaJuridica.Add(cliente);

                Console.WriteLine("Cliente Salvo com sucesso !!");

                return true;
            }
            return false;
        }

        public Cliente GetListCliente()
        {
            return Clientes;
        }
    
    }
}
