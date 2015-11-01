using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tstChaveAssimetrica.Parceiros;

namespace tstChaveAssimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ana = new Ana();
            var _beto = new Beto();



            Console.WriteLine("Chave simétrica Ana:" + _ana.calculaChaveSimetrica(_beto));           
            Console.WriteLine("Chave simétrica Beto:" + _beto.calculaChaveSimetrica(_ana));

			Console.WriteLine("Chave pública Ana:" + _ana.chavePublica);
            Console.WriteLine("Chave pública Beto:" + _beto.chavePublica);
            Console.ReadKey();
        }
    }
}
