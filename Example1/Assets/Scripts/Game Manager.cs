using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public float Counter = 60;
    public TextMeshProUGUI CounterText;
    private void Update(){
        Counter = Counter - Time.deltaTime;
        CounterText.text = Mathf.RoundToInt(Counter).ToString();
    }
}
