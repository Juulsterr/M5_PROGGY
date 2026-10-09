using UnityEngine;

public class Prog_Les1 : MonoBehaviour
{
    public string naam = "Julian";
    public string ELachternaam = "P";
    public int score;
    public int health;
    public bool isAlive; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Max: " + Max(3, 2));
        Debug.Log("Charizard doet 1000 schade maar door Pikachu zijn goede verdediging gaan daar 700 health van af. " + "Totale schade: " + BerekenSchade(1000, 700) + ".");
        Debug.Log("Gegroet meneer heer " + naam + " " + ELachternaam);
        isAlive = true;
        health = 100;
        score = 0;
         Debug.Log("naam: " + naam);
         Debug.Log("score: " + score);
         Debug.Log("Pikachu health: " + BerekenSchade(1000, 700));
         Debug.Log("isAlive: " + isAlive);
    }

    private int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    public int BerekenSchade(int aanval, int verdediging)
    {
        health -= aanval - verdediging;
        return aanval - verdediging;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            score += 100;
            health -= 10;
            Debug.Log("Health: " + health);
        }
        if(health <= 0)
            {
                isAlive = false;
                Debug.Log("isAlive: " + isAlive);
                Destroy(gameObject);
            }
    }
}
