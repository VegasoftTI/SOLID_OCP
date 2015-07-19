using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    public class Context
    {
        private static List<Carro> _carros = new List<Carro> 
        {
             new Carro { CarroId = 1, Modelo = "Ford EcoSport", TipoCarro = TipoCarro.SUV },
             new Carro { CarroId = 2, Modelo = "Chevrolet Cruze", TipoCarro = TipoCarro.Sedan },
             new Carro { CarroId = 3, Modelo = "Fiat Novo Palio", TipoCarro = TipoCarro.Hatch }
        };
        public static List<Carro> Carros
        {
            get
            {
                return _carros;
            }
        }
    }
}
