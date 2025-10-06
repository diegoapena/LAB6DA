using UnityEditor.Build.Content;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private DarkSlime darkslime;
    private Slime slime;
    private Botiquin botiquin;

    void Start()
    {
        darkslime = new DarkSlime("Noooo!! Slime oscuro ", 50, 10);
        slime = new Slime("Orco Brutal", 100, 20, 15);

        botiquin = new Botiquin("Pasa botiquin", 25);

        Debug.Log("Fight!!");

        darkslime.HabilidadEspecial();
        slime.HabilidadEspecial();

        darkslime.Atacar(slime);
        slime.Atacar(darkslime);

        botiquin.Consumir(darkslime);

        darkslime.DropearItem();

        Debug.Log("K.O.");
    }
}
