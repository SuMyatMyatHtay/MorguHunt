using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class LoadingBar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI progressText;
    private float currentTime = 0f;
    public float Countdown = 5.0f;
 
    private void Start()
    {
        slider.maxValue = Countdown;
        slider.value = 0;
        currentTime = Countdown;
        StartCoroutine(LoadScene(Countdown));

       
    }
        IEnumerator LoadScene(float amount)
    {
      
        yield return new WaitForSeconds(amount);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Bomb");
       
    }
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        var progress = Countdown - currentTime;
    
        
        if (progress < Countdown)
        {
            slider.value = progress;
            progressText.text = Math.Round( progress/Countdown * 100f )+ "%";

        }

    }
  
}
