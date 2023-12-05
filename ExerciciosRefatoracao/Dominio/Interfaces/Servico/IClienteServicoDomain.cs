using ExerciciosRefatoracao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Dominio.Interfaces.Servico
{
    public interface IClienteServicoDomain
    {
        public bool AdicionarPF(ClientePessoaFisica cliente);
        public bool AdicionarPJ(ClientePessoaJuridica cliente);
        public Cliente GetListCliente();
    }
}
