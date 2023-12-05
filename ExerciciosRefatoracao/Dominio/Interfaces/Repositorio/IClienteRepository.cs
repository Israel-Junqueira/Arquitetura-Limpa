using ExerciciosRefatoracao.Dominio.Entities;
using ExerciciosRefatoracao.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Dominio.Interfaces.Repositorio
{
    public interface IClienteRepository
    {
        public bool AdicionarPF(ClientePessoaFisica cliente);
        public bool AdicionarPJ(ClientePessoaJuridica cliente);
        public Cliente GetListCliente();

    }
}
