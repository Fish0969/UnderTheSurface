using UnityEngine;

public class kodsf : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Dynamite"))
        Destroy(gameObject);
}
}
