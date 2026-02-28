using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        InvokeRepeating("Spawn", 0f, 0.2f);
    }

    void Spawn() => Instantiate(prefab, transform.position, Quaternion.identity);
}