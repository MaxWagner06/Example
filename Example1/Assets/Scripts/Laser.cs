using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject laser;
    void OnTriggerEnter2D(Collider2D trigger){
        if(trigger.gameObject.tag == "cat"){
            laser.transform.position = new Vector2(Random.Range(-7.0f,7.0f),Random.Range(-4.0f,4.0f));
        }
    }
}
