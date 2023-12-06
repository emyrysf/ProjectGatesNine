using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float enemySpeed = 5;
    [SerializeField] private float jumpForce = 5;
    [SerializeField] private float jumpCooldown = 1;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Jump", 0, jumpCooldown);
        

    }
    private void Update()
    {
        rb.velocity = new Vector2(-enemySpeed, rb.velocity.y);
    }



    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
    }

}
