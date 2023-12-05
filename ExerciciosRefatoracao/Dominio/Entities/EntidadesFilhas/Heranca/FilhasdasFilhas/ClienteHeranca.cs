using ExerciciosRefatoracao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Dominio.Entities.EntidadesFilhas
{
    public  abstract class ClienteHeranca
    {
        public string Nome { get; set; }
        public string EndBairro { get; set; }
        public EndEntrega EndEntrega { get; set; }
        public EndCobranca EndCobranca { get; set; }
        public EndFaturamento EndFaturamento { get; set; }
    }
}
