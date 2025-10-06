using UnityEngine;

public abstract class Item
{
    private string nombre;

    public Item(string nombre)
    {
        this.nombre = nombre;
    }

    public string Nombre { get { return nombre; } }
}

public class Botiquin : Item, IConsumible
{
    private int curacion;

    public Botiquin(string nombre, int curacion) : base(nombre)
    {
        this.curacion = curacion;
    }

    public void Consumir(Enemigo enemigo)
    {
        enemigo.Vida += curacion;
        Debug.Log(enemigo.Nombre + " usa " + Nombre + " y recupera " + curacion + " de vida.");
    }
}