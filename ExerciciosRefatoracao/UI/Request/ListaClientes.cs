using ExerciciosRefatoracao.Aplicação.Interfaces;
using ExerciciosRefatoracao.Dominio.Entities;
using ExerciciosRefatoracao.Infraestrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.UI
{
    public class ListaClientes
    {
   

        private IClienteServiceAplication _clientePFService;

        public ListaClientes(IClienteServiceAplication clientePFService)
        {
            this._clientePFService = clientePFService;
        }
        public Cliente GetListCliente()
        {
           return _clientePFService.GetListClientes();

        }
  
      
    }
}
