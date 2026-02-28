using UnityEngine;

public class Jump2D : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().linearVelocity.y == 0)
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 5, ForceMode2D.Impulse);
    }
}