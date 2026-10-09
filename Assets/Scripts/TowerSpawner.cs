using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    // Sleep in Unity je Toren-Prefab in dit vakje
    public GameObject towerPrefab;

    void Update()
    {
        // Controleer of de gebruiker op de linkermuisknop klikt (0 = linkermuisknop)
        if (Input.GetMouseButtonDown(0))
        {
            // 1. Bepaal een willekeurige positie op de X- en Y-as
            float randomX = Random.Range(-8f, 8f);
            float randomY = Random.Range(-4f, 4f);
            Vector3 randomPositie = new Vector3(randomX, randomY, 0f);

            // 2. Maak de toren aan (Instantiate)
            // Quaternion.identity betekent "geen rotatie"
            Instantiate(towerPrefab, randomPositie, Quaternion.identity);
        }
    }
}