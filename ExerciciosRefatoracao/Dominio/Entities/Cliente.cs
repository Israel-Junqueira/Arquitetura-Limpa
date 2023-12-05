using ExerciciosRefatoracao.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Dominio.Entities
{
    public class Cliente 
    {
        public List<ClientePessoaJuridica> lstPessoaJuridica = new List<ClientePessoaJuridica>();
        public List<ClientePessoaFisica> lstPessoaFisica = new List<ClientePessoaFisica>();

        
    }

    
}
