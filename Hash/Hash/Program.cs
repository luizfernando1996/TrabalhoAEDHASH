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

            recebeTamanhoDaEntrada();
            RecebeEstruturaDeDados();
            Console.ReadKey();

            Leitura objLer = new Leitura();
            objLer.lerArquivo();
            Console.ReadKey();

        }

        public static int recebeTamanhoDaEntrada()
        {
            string tamanho;
            int tamanhoHash = 2;
            bool sair = false;
            while (sair.Equals(false))
            {
                Console.WriteLine("Informe o tamanho da tabela hash");
                tamanho = Console.ReadLine();
                bool tamanhoTabelaExiste = int.TryParse(tamanho, out tamanhoHash);

                if (tamanhoTabelaExiste)
                {
                    sair = true;

                }
                else
                    Console.WriteLine("\nDigite numero inteiro para o tamanho da tabela por favor");
            }
            return tamanhoHash;
        }
        public static int RecebeEstruturaDeDados()
        {
            string opcaoSelecionada;
            int opcaoListaEncadeada = 1;
            bool sair = false;
            while (sair.Equals(false))
            {
                Console.WriteLine("Digite 1 para selecionar a estrutura de dados de listas encadeada");
                Console.WriteLine("Digite 2 para selecionar a estrutura de dados de endereçamento aberto");
                opcaoSelecionada = Console.ReadLine();

                bool numeroInteiro = int.TryParse(opcaoSelecionada, out opcaoListaEncadeada);
                if (numeroInteiro)
                {
                    sair = true;
                }
                else
                    Console.WriteLine("\nDigite numero inteiros para selecionar a estrutura de dados por favor");
            }
            return opcaoListaEncadeada;

        }
    }
}
