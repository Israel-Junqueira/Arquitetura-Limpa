using ExerciciosRefatoracao.Dominio.Entities.EntidadesFilhas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Dominio.Entities
{
    public class ClientePessoaFisica: ClienteHeranca
    {
       public string CPF { get; set; }

    }
}
