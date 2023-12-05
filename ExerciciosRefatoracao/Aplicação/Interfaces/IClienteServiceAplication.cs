

using ExerciciosRefatoracao.Aplicação.DTO;
using ExerciciosRefatoracao.Dominio.Entities;
using ExerciciosRefatoracao.UI;

namespace ExerciciosRefatoracao.Aplicação.Interfaces
{
    public interface IClienteServiceAplication
    {
        public void CadastrarPF(CLientePFDTO clientePFRequest);
       public void CadastrarPJ(ClientePJDTO clientePJRequest);
       public Cliente GetListClientes();
    }
}
