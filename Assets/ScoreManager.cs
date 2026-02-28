using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static float score = 0f;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        score += 10f * Time.deltaTime;
        scoreText.text = "Score: " + Mathf.FloorToInt(score);
    }
}