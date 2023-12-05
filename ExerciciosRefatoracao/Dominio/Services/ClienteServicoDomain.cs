using ExerciciosRefatoracao.Dominio.Entities;
using ExerciciosRefatoracao.Dominio.Interfaces.Repositorio;
using ExerciciosRefatoracao.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Dominio.Services
{
    public class ClienteServicoDomain : IClienteServicoDomain
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteServicoDomain(IClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }
        public bool AdicionarPF(ClientePessoaFisica cliente)
        {
           return _clienteRepository.AdicionarPF(cliente);
        }

        public bool AdicionarPJ(ClientePessoaJuridica cliente)
        {
            return _clienteRepository.AdicionarPJ(cliente);
        }

        public Cliente GetListCliente()
        {
           return _clienteRepository.GetListCliente();
        }
    }
}
