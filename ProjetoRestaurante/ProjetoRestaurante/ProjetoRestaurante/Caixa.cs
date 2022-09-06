using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante
{
    class Caixa
    {
        public double totalizarComanda(Comanda mesa)
        {
            mesa.setValorTotal(mesa.getValorConsumo() + mesa.getValorEstacionamento() + mesa.getValorCouvert() - mesa.getValorDescontoPromocional());
            return mesa.getValorTotal();
        }
    }
}
