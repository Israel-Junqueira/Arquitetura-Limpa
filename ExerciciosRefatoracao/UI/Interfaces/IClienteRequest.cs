using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.UI.Interfaces
{
    public interface IClienteRequest
    {
        public void AddClientePessoaFisica();
        public void AddClientePessoaJuridica();
    }
}
