using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBlinking : MonoBehaviour
{
    public float minTime = 0.8f;
    public float maxTime = 0.8f;

    private float timer;
    public TextMeshProUGUI textFlicker;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minTime,maxTime); 
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; 
        if (timer <= 0)
        {
            textFlicker.enabled = !textFlicker.enabled;
            timer = Random.Range(minTime, maxTime); 
        }
    }
}
