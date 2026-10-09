using UnityEngine;

public class Speler : MonoBehaviour
{
    public string naam;
    public int hp;
    public int score;

    private void Mario()
    {
        naam = "Mario";
        hp = 100;
        score = 100;
        Debug.Log("In the first corner we have " + naam + " with an awesome max health of " + hp + " and a score of " + score);
    }

    private void Luigi()
    {
        naam = "Luigi";
        hp = 95;
        score = 80;
        Debug.Log("In the second corner we have " + naam + " with an awesome max health of " + hp + " and a score of " + score);
    }

    private void StelSpelerIn(string nieuweNaam, int nieuwHp, int nieuweScore, string hoek)
    {
        naam = nieuweNaam;
        hp = nieuwHp;
        score = nieuweScore;

        Debug.Log("In the " + hoek + " corner we have " + naam + " with an awesome max health of " + hp + " and a score of " + score);
    }
    void Start()
    {
        // Roep hier de methodes aan die je wilt uitvoeren bij het starten
        Mario();
        Luigi();
        StelSpelerIn("Mario", 100, 100, "first");
        StelSpelerIn("Luigi", 95, 80, "second");
        StelSpelerIn("Peach", 90, 70, "third");
    }

    void Update()
    {
        
    }
}