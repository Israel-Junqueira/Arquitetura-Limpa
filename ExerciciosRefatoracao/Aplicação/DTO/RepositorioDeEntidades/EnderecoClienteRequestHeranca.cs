using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Aplicação.DTO
{
    public abstract class EnderecoClienteRequestHeranca
    {
        public string EndLogradouro { get; set; }
        public string EndNumero { get; set; }
        public string EndComplemento { get; set; }
        public string EndCEP { get; set; }
        public string EndMunicipio { get; set; }
        public string EndUF { get; set; }
    }
}
