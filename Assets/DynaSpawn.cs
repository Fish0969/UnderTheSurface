using Unity.VisualScripting;
using UnityEngine;

public class DynaSpawn : MonoBehaviour
{
    public GameObject press;
    public int randomNumber;

    public Transform spawnContainer;
    public float minX = -10f, maxX = 10f;
    public float minY = -5f, maxY = 5f;
    public float spawnInterval;
    public int maxChildren;

    void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnInterval);
    }

    void Spawn()
    {
            Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate(press, randomPos, Quaternion.identity, spawnContainer);



        if (spawnContainer.childCount >= maxChildren)
        {
            Debug.Log("Limit reached!");
            CancelInvoke("Spawn");
        }
    }
}