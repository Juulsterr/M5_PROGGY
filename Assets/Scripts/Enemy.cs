using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    // Maak direct een array van tekst/strings aan
    public string[] enemyNames = { "Orc", "Knight", "Wizard", "Ogre", "Dragon" };

    void Start()
    {
        List<string> vijanden = new List<string>();

        vijanden.Add("Bowser");
        vijanden.Add("Goomba");
        vijanden.Add("Koopa");
        vijanden.Add("Boo");
        vijanden.Add("Shy Guy");

        vijanden.Remove("Goomba");

        Debug.Log("--- Overgebleven Vijanden ---");
        foreach (string vijand in vijanden)
        {
            Debug.Log(vijand);
        }

        Debug.Log("Totaal aantal vijanden: " + vijanden.Count);
        for (int i = 0; i < enemyNames.Length; i++)
        {
            Debug.Log(enemyNames[i]);
        }
        
    }
}