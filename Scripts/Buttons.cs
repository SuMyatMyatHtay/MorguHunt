using System;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public TextMeshProUGUI passwordText;
    public void AddOne()
    {
        passwordText.text += "1";
    }
    public void AddTwo()
    {
        passwordText.text += "2";
    }
    public void AddThree()
    {
        passwordText.text += "3";
    }
    public void AddFour()
    {
        passwordText.text += "4";

    }
    public void RemoveLastChar()
    {
        string input = passwordText.text;
        passwordText.text = input.Remove(input.Length - 1, 1);
    }
}
