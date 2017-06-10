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
        private string pathArquivo3 = "../../MVC/DAL/Arquivos/ArquivoHash.txt";

        private string[,] registros = new string[27,3];
        private static int indice = 0;
        private bool indiceExcedido = false;

        public string[,] Registros { get => registros; set => registros = value; }

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

            if (indiceExcedido.Equals(false))
            {
                Registros[indice, 0] = frase[0];
                Registros[indice, 0] = frase[1];
                Registros[indice, 0] = frase[2];
                Registros[indice, 0] = frase[3];
            }

            if (indice < 27)
                indice++;
            else
                indiceExcedido = true;
        }


    }

}
