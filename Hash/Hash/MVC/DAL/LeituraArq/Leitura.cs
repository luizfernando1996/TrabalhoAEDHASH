using Hash.MVC.Controller.Lista;
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

        private Lista objLista = new Lista();

        internal Lista ObjLista { get => objLista; set => objLista = value; }

        public void lerArquivo()
        {
            using (StreamReader ler = new StreamReader(pathArquivo3))
            {
                string leitura= "a";
                string[] frase;
                while (leitura != null)
                {
                    leitura = ler.ReadLine();
                    if (leitura != null)
                    {
                        frase = leitura.Split(';');
                        criarObjeto(frase);
                    }
                }
            }

        }
        public void criarObjeto(string[]frase) {
            ObjLista.insereLista(frase[0],frase[1],frase[2],frase[3]);
        }


    }

}
