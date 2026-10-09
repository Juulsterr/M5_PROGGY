using UnityEngine;
using System.Linq;

public class HighestScore : MonoBehaviour
{
    public int[] Scores = { 1, 34, 900, 67, 21 };

    void Start()
    {
        int hoogste = Scores.Max();
        Debug.Log("De hoogste score is: " + hoogste);
    }
}