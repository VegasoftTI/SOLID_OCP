using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    public class AluguelBusiness
    {
        private List<AluguelBusinessOCP> _tiposCarro;

        public AluguelBusiness()
        {
            _tiposCarro = new List<AluguelBusinessOCP>();
            _tiposCarro.Add(new AluguelSUVBusinessOCP());
            _tiposCarro.Add(new AluguelSedanBusinessOCP());
        }

        //public double ObterValorAluguel(DateTime dataEntrega, TipoCarro tipoCarro)
        //{
        //    switch (tipoCarro)
        //    {
        //        case TipoCarro.Hatch:
        //            return (dataEntrega.Subtract(DateTime.Today).TotalDays) * 30;
        //        case TipoCarro.Sedan:
        //            return (dataEntrega.Subtract(DateTime.Today).TotalDays) * 50;
        //        default:
        //            return 0;
        //    }
        //}

        public double ObterValorAluguel(DateTime dataEntrega, TipoCarro tipoCarro)
        {
            var tipo = _tiposCarro.Find(x => x.Tipo(tipoCarro));

            return tipo.ObterValorAluguel(dataEntrega);
        }
    }
}
