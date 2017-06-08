using System;

public class Node
{
    private string nomeEstado;
    private string capitalEstado;
    private string regiaoDoEstado;
    private int quantMunicipios;
    private Node next;

    public Node(string nomeDoEstado,string capitalDoEstado,string regiaoEstado,int quantMunicipios)
    {
        this.nomeEstado = nomeDoEstado;
        this.capitalEstado = capitalDoEstado;
        this.regiaoDoEstado = regiaoEstado;
        this.quantMunicipios = quantMunicipios;
    }

}
