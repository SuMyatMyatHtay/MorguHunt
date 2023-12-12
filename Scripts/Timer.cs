using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private string answerValue;

    [SerializeField] TextMeshProUGUI m_Object;

    private Text timerText;
    private float startTime;
    private bool finnished = false; 
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        m_Object.text = timerText.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished)
        {
            return;
        }

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        m_Object.text = minutes + ":" + seconds; 
    }

    public void Finish()
    {
        finnished = true; 
        
    }
}
