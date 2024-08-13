using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float chVelocity;
    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate(){
        rb.MovePosition(rb.position + movement * chVelocity * Time.deltaTime);
    }
}
