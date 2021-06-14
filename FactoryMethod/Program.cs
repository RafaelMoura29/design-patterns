using System;
using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;
            Console.WriteLine("Digite o tipo de cartão que gostaria de obter:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "black":
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                case "titanium":
                    cartaoFactory = new TitaniumFactory(10000, 500);
                    break;
                case "platinum":
                    cartaoFactory = new PlatinumFactory(5000, 1000);
                    break;
                default:
                    break;
            }

            CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
            Console.WriteLine(cartaoCredito.TipoCartao);
            Console.WriteLine(cartaoCredito.CobrancaoAnual);
            Console.WriteLine(cartaoCredito.LimiteCredito);
        }
    }
}
