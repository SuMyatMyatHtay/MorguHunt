using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MathQuestion2 : MonoBehaviour
{
   //math question text
    public TextMeshProUGUI mathQuestion;
    //buttons of all the options
    public GameObject optionsButton;
    //'Press' button
    public GameObject activateQuestion;
    //Cover of button pizza box
    public GameObject topCover;

    private void Start()
    {
        optionsButton.SetActive(false);
    }
    //when click 'Press' Button
    public void loadQuestion()
    {
        mathQuestion.text = "Solve 4(3(2))";
        activateQuestion.SetActive(false);
        optionsButton.SetActive(true);
    }
    //when click correct option
    public void correctOption()
    {
        topCover.SetActive(false);
        optionsButton.SetActive(false);
        mathQuestion.enabled = false;
    }
}
