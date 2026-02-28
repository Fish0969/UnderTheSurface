using UnityEngine;
using TMPro;

public class KeyRandomizer : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public TextMeshProUGUI timerDisplay;

    private string[] keys = { "W", "A", "S", "D" };
    private string currentKey = "";
    private float timer = 0f;
    public float interval;
    public RandomSpawner spawnerScript;
    private bool gameOver = false;
    private bool keyPressedThisRound = false;

    void Start()
    {
        spawnerScript = GameObject.Find("Spawner").GetComponent<RandomSpawner>();
        currentKey = keys[Random.Range(0, keys.Length)];
        textDisplay.text = currentKey;
    }

    void Update()
    {
        if (gameOver) return;

        timer += Time.deltaTime;

        float timeLeft = interval - timer;
        timerDisplay.text = "Next: " + timeLeft.ToString("F1") + "s";

        if (timer >= interval)
        {
            if (!keyPressedThisRound)
            {
                GameOver();
                return;
            }

            timer = 0f;
            keyPressedThisRound = false;
            currentKey = keys[Random.Range(0, keys.Length)];
            textDisplay.text = currentKey;
        }

        if (Input.GetKeyDown(currentKey.ToLower()))
        {
            keyPressedThisRound = true;
            textDisplay.text = "Good";
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) ||
                 Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        if (spawnerScript != null)
        {
            spawnerScript.CancelInvoke("Spawn");
            Debug.Log("Spawning stopped.");
        }
        timerDisplay.text = "";
        textDisplay.text = "Bye!";
        gameOver = true;
    }
}