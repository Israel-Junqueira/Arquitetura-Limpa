
using ExerciciosRefatoracao.Dominio.Entities.EntidadesFilhas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Dominio.Entities
{
    public class ClientePessoaJuridica : ClienteHeranca
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

    }
}
