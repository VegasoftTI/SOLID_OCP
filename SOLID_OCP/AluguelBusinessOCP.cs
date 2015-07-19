
using System;
namespace SOLID_OCP
{
    public abstract class AluguelBusinessOCP
    {
        public abstract bool Tipo(TipoCarro tipoCarro);

        public abstract double ObterValorAluguel(DateTime dataEntrega);
    }
}
