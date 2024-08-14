using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{
    public GameObject laser;
    public int score;
    public TextMeshProUGUI scoreText;

    void OnTriggerEnter2D(Collider2D trigger){
        if(trigger.gameObject.tag == "cat"){
            laser.transform.position = new Vector2(Random.Range(-7.0f,7.0f),Random.Range(-4.0f,3.5f));
            score += 1;
        }
    }
    private void Update(){
        scoreText.text = Mathf.RoundToInt(score).ToString();
    }
}
