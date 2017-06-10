using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash.MVC.DAL.LeituraArq
{
    class Leitura
    {
        public void lerArquivo()
        {
            using (StreamReader ler = new StreamReader("ArquivoHash.txt"))
            {
                while (ler.ReadLine() != null)
                {
                    leitura = ler.ReadLine();
                    Console.WriteLine(leitura);
                }
            }

        }

    }
}
