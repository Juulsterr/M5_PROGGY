using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string naam = "Julian";
    public int score = 13000000;
    public int health = 100;
    public bool isAlive = true;
        class PROG_Les1
    {
        static void Main(string[] args)
        {
            Debug.Log("Hello World!");
        }
    }
    public void LevendCheck()
    {
        if(health <= 0)
        {
            isAlive = false;
            Destroy(gameObject);
        }
    }
}
