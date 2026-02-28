using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText.text = "Final Score: " + Mathf.FloorToInt(ScoreManager.score);
    }
}