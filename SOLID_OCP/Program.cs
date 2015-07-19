using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    class Program
    {
        //Chamada por um ASP.NET MVC, Windows Forms, Mobile e etc...
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ID do carro que deseja alugar:");
            var carros = Context.Carros;
            foreach (var carro in carros)
            {
                Console.WriteLine(String.Format("ID: {0} - Carro: {1}", carro.CarroId, carro.Modelo));
            }
            int idCarro = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dias pretende ficar com o carro?");

            int qtdDias = Int32.Parse(Console.ReadLine());

            var carroEscolhido = carros.FirstOrDefault(x => x.CarroId == idCarro);

            AluguelBusiness aluguelBO = new AluguelBusiness();
            var valorAPagar = aluguelBO.ObterValorAluguel(DateTime.Today.AddDays(qtdDias), carroEscolhido.TipoCarro);
            Console.WriteLine(String.Format("Carro: {0} - Valor a Pagar: R$ {1}", carroEscolhido.Modelo, valorAPagar));

            //AluguelBusiness aluguelBO = new AluguelBusiness();
            //var valorAPagar = aluguelBO.ObterValorAluguel(DateTime.Today.AddDays(2), TipoCarro.Sedan);
            //Console.WriteLine(String.Format("Carro de categoria: {0} - Valor a Pagar: R$ {1}", TipoCarro.Sedan.ToString(), valorAPagar));

            Console.ReadLine();
        }
    }
}
