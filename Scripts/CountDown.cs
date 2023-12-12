using System;
using System.Collections;
using System.Linq;
using System.Threading;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CountDown : MonoBehaviour
{
    private float duration = 300;
    public TextMeshProUGUI countdownText;
    public TextMeshProUGUI passwordText;
    public TextMeshProUGUI wrongInputText;
    public TextMeshProUGUI secretPassword;
    private string password;
    private float time = 3.0f;

    private void Start()
    {
        if (gameObject.name == "Enter")
        {
            passwordText.text = "";
            Debug.Log("Game Started");
            //Generate random numbers
            System.Random random = new System.Random();
            int firstNum = random.Next(1, 5);
            int secondNum = random.Next(1, 5);
            int thirdNum = random.Next(1, 5);
            int fourthNum = random.Next(1, 5);
            int fifthNum = random.Next(1, 5);
            password = firstNum + "" + secondNum + "" + thirdNum + "" + fourthNum + "" + fifthNum;
            secretPassword.text = password;
            wrongInputText.enabled = false;
            Debug.Log(secretPassword.text);
        }
    }

    private void Update()
    {
        //minus 1 every second
        duration -= 1 * Time.deltaTime;
        var minutes = Math.Floor(duration / 60);
        var seconds = Math.Floor(duration - minutes * 60);
        if (minutes == 0 && seconds == 00)
        {
            if (countdownText.enabled == true)
            {
                SceneManager.LoadScene("GameOver");
            }

        }
        else
        {
            countdownText.text = "0" + minutes + ":" + seconds.ToString().PadLeft(2, '0');
        }

    }

    public void Submit()
    {

        string passwordInput = passwordText.text;
        Debug.Log("CorrectPassword" + password);
        Debug.Log("password" + passwordInput);
        if (passwordInput.Trim() == password)
        {
            countdownText.text = "Congrats!";
            SceneManager.LoadScene("Complete");

        }
        else
        {
            StartCoroutine(WrongPassword(time));
            duration -= 30;
        }
    }

    public void wrongAns()
    {
        duration -= 10;
        StartCoroutine(WrongInput(2.0f));
    }
    public void quit()
    {
        duration -= 30;
    }
    IEnumerator WrongInput(float time)
    {
        wrongInputText.enabled = true;
        yield return new WaitForSeconds(time);

        wrongInputText.enabled = false;
    }
    IEnumerator WrongPassword(float time)
    {
        passwordText.text = "Wrong";
        yield return new WaitForSeconds(time);

        passwordText.text = "";
    }
}