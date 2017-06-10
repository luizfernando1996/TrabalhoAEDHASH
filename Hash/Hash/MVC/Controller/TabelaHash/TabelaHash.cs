using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hash.MVC.Controller.Lista;

namespace Hash.MVC.Controller.TabelaHash
{
    class TabelaHash
    {
        public int tamanho;
        public string tipoDeTratamento;
        public int colisoes = 0;
        public Node[] tabela;

        public TabelaHash(int tamanho, string tipoDeTratamento)
        {
            this.tamanho = tamanho;
            this.tipoDeTratamento = tipoDeTratamento;
            tabela = new Node[tamanho];
        }

        public void insereHash(Node obj)
        {
            if (tipoDeTratamento == "aberto")
            {
                insereAberto
            }
            else
            {

            }
        }


        private void insereAberto(Node obj)
        {
            
            int posicao = FuncaoHash.EncontraPosicao(obj.NomeEstado, tamanho);
            int i = 0;
            bool inserido = false;

            while (i < tabela.Length)
            {
                if(i == posicao)
                {
                    if(tabela[i] == null)
                    {
                        tabela[i] = obj;
                        inserido = true;
                    }
                    else
                    {
                        colisoes++;
                        posicao++;
                    }
                }
                i++;
            }

            if(inserido == false)
            {
                posicao = 0;
                insereAberto(obj);

                if (inserido == false)
                    Console.WriteLine("Não há espaço para inserir todos os estados escolha um tamanho de hash maior!");
            }           

        }

    }
}
