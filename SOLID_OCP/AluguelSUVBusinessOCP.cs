using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    public class AluguelSUVBusinessOCP : AluguelBusinessOCP
    {
        public override bool Tipo(TipoCarro tipoCarro)
        {
            return tipoCarro == TipoCarro.SUV;
        }
        public override double ObterValorAluguel(DateTime dataEntrega)
        {
            return (dataEntrega.Subtract(DateTime.Today).TotalDays) * 100;
        }
    }
}
