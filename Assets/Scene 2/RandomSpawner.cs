using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSpawner : MonoBehaviour
{
    public GameObject press;
    public GameObject goldenpress;
    public GameObject bomb;
    public int randomNumber;
    public int randomZumber;

    public Transform spawnContainer;
    public Transform bombContainer;
    public float minX = -10f, maxX = 10f;
    public float minY = -5f, maxY = 5f;
    public float spawnInterval;
    public int maxChildren;
    public AudioSource CLICKsOUND;

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
            randomZumber = Random.Range(1, 3);
            if (randomZumber == 1)
            {
                Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                Instantiate(press, randomPos, Quaternion.identity, spawnContainer);
            }
            else if (randomZumber == 2)
            {
                Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                Instantiate(goldenpress, randomPos, Quaternion.identity, spawnContainer);
            }
        }



        if (randomNumber >= 7)
        {
            Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate(bomb, randomPos, Quaternion.identity, bombContainer);
        }

        if (spawnContainer.childCount >= maxChildren)
        {
            Debug.Log("Limit reached!");
            CancelInvoke("Spawn");
             SceneManager.LoadScene("End");
        }
    }

    public void ClearAll()
    {
        CancelInvoke("Spawn");

        foreach (Transform child in spawnContainer)
            Destroy(child.gameObject);

        foreach (Transform child in bombContainer)
            Destroy(child.gameObject);
    }
}