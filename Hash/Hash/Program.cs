using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hash.MVC.DAL.LeituraArq;

namespace Hash
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para ");
            Leitura objLer = new Leitura();
            objLer.lerArquivo();
            Console.ReadKey();
        }

    }
}
