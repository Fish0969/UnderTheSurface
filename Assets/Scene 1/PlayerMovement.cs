using UnityEngine;
using System.Collections;
using UnityEditor.Callbacks;
using System.Collections.Generic;



public class PlayerMovement : MonoBehaviour
{


    private Rigidbody2D rb;
    public float speed = 10f;


    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x, y);

        Walk(dir);
    }

    private void Walk(Vector2 dir)
    {
        rb.linearVelocity = (new Vector2(dir.x * speed, rb.linearVelocity.y));
    }
}
