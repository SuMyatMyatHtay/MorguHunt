using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class checkComplete : MonoBehaviour
{
    public GameObject passwordCanvas;
    public GameObject correctClamp;
    public GameObject correctLeftBatt;
    public GameObject correctRightBatt;
    public GameObject correctButton;
    public TextMeshProUGUI rightPassword;
    public TextMeshProUGUI secretPassword;
    // Start is called before the first frame update
    private void Start()
    {
        passwordCanvas.SetActive(false);
        rightPassword.enabled = false;
        
    }

    // Update is called once per frame
   private void Update()
    {
        
        if (correctClamp.activeSelf == true && correctLeftBatt.activeSelf == true && correctRightBatt.activeSelf == true && correctButton.activeSelf == true) 
        {
            passwordCanvas.SetActive(true);
            rightPassword.enabled = true;
            rightPassword.text = secretPassword.text;
        }
    }
}
