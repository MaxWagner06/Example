using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpingVelocity = 5;  
    public bool triangleOnground = true;
    
        
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && triangleOnground == true){
            rb.velocity = Vector2.up * jumpingVelocity * 100 * Time.deltaTime;
            triangleOnground = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D Collision){
        if(Collision.gameObject.tag == "dick"){
            triangleOnground = true;
        }
    }

}