using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBread : MonoBehaviour
{
    public GameManager gameManager;
    public float Velocity = 1;
    private Rigidbody2D rb;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //jump
            rb.velocity = Vector2.up * Velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
