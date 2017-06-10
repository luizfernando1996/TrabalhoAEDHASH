using System;

public class Leitura
{
	public Leitura()
	{
	}

    public void lerArquivo()
    {
        using (StreamReader ler = new StreamReader("ArquivoHash.txt"))
        {
            while (ler.ReadLine()!=null)
            {
                leitura = ler.ReadLine();
                Console.WriteLine(leitura);
            }
        }

    }


}
