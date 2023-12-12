using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombButton : MonoBehaviour
{
    public GameObject correctButton;
    private GameObject selectedButton;
    private void Start()
    {
        //button not in place yet so set active false
        correctButton.SetActive(false);
    }
    protected void OnTriggerEnter(Collider col)
    {
        selectedButton = col.gameObject;
    }
    public void isCorrectButton()
    {
        if (selectedButton.name == "BigButton")
        {
            //correctButton!!!
            correctButton.SetActive(true);
        }
    }
    //function called when player re-grabs clamps to put it somewhere else
    public void exitButton()
    {
        correctButton.SetActive(false);
    }
}
