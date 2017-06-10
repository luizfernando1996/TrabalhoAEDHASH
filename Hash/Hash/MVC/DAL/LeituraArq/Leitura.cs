using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash.MVC.DAL.LeituraArq
{

    class Leitura
    {
        //caminho relativo implementado
        string pathArquivo3 = "../../MVC/DAL/Arquivos/ArquivoHash.txt";

        public void lerArquivo()
        {
            using (StreamReader ler = new StreamReader(pathArquivo3))
            {
                string leitura="a";
                while (leitura != null)
                {
                    leitura = ler.ReadLine();
                    Console.WriteLine(leitura);
                }
            }

        }

    }

}
