using UnityEngine;

public class EndGame : MonoBehaviour
{
    void OnMouseDown()
    {
        RandomSpawner randomSpawner = FindObjectOfType<RandomSpawner>();
        randomSpawner.GetComponent<RandomSpawner>().enabled = false;
    }
}
