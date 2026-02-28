using Unity.VisualScripting;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject press;
    public GameObject bomb;
    public int randomNumber;

    public Transform spawnContainer;
    public Transform bombContainer;
    public float minX = -10f, maxX = 10f;
    public float minY = -5f, maxY = 5f;
    public float spawnInterval = 2f;
    public int maxChildren;

    void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnInterval);
    }

    void Spawn()
    {
        randomNumber = Random.Range(0, 10);
        Debug.Log(randomNumber);
        if (randomNumber <= 6)
        {
        Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Instantiate(press, randomPos, Quaternion.identity, spawnContainer);
        }

        if (randomNumber >= 7)
        {
        Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Instantiate(bomb, randomPos, Quaternion.identity, bombContainer);

        }

        if (spawnContainer.childCount >= maxChildren)  
        {
            Destroy(bomb);
            Destroy(press);
            Debug.Log("Limit reached!");
             CancelInvoke("Spawn");

    }
    }
}