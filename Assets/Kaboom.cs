using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Kaboom : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Kaboom"))
    Debug.Log("Kaboom!");
        Destroy(gameObject);
        SceneManager.LoadScene("End");
        
}
}
