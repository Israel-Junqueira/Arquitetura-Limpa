using ExerciciosRefatoracao.Aplicação.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.UI.Interfaces.Servicos
{
    public interface IClientePJCadastro
    {
        public ClientePJDTO CriaObjetoPFRequestUI();
        public void SetEnderecoCobranca(CLientePFDTO cliente);
        public void SetEnderecoFaturamento(CLientePFDTO cliente);
        public void SetEnderecoEntrega(CLientePFDTO cliente);
    }
}
