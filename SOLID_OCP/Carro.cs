using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string Modelo { get; set; }
        public TipoCarro TipoCarro { get; set; }
    }
}
