using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//---------------------------------------
// Author           : SU MYAT MYAT HTAY 
// Date             : 2023-02-11
// Description      : The main and start script for the maths mental calculation room. Both randomising the maths question and setting timer is run in this script. 
//---------------------------------------

public class ChangeQuestion : MonoBehaviour
{
    public float Countdown = 3.0f;

    public GameObject BrainMathsRoom;
    public GameObject CubeThrowingArea;
    public GameObject ScoreSheet;

    public GameObject MathsRoomAudio;

    public int finalTime;

    private string textValue;
    private string answerValue;

    [SerializeField] TextMeshProUGUI m_Object;
    [SerializeField] TextMeshProUGUI m_Answer;
    [SerializeField] TextMeshProUGUI m_Button1;
    [SerializeField] TextMeshProUGUI m_Button2;
    [SerializeField] TextMeshProUGUI m_Button3;
    [SerializeField] TextMeshProUGUI m_Button4;

    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button StartButton;
    public int timeTotal = 0;
    private int fate = new System.Random().Next(1, 5);

    //timer
    [SerializeField] TextMeshProUGUI m_Timer;

    private Text timerText;
    private float startTime;
    private bool finnished = false;

    private void Start()
    {
        BrainMathsRoom.SetActive(true);
        CubeThrowingArea.SetActive(false);
        ScoreSheet.SetActive(false);
        MathsRoomAudio.SetActive(true); 
    }

    public void StartTimer()
    {
        startTime = Time.time;
        StartButton.enabled = false; 
        
        var random = new System.Random();
        int first = random.Next(10, 32);
        int second = random.Next(6, 22);
        int third = random.Next(3, 20);

        

        //I will be giving 4 choices. but in random.next, minimum value(1 in this case) can return
        //but only number lesser than maximum value can return. (in this case 5 cannot return). 
        //int fate = random.Next(1, 5); 

        int answer = (first * second) + third; 

        //textValue is for printing out the question of the Maths problem. 
        textValue = "( " + first.ToString() + " * " + second.ToString() + " ) + " + third.ToString();
        //answerValue is for printing out the correct answer value. 
        answerValue = answer.ToString(); 

        m_Object.text = textValue;
        m_Answer.text = answerValue; 

        //to random the correct answer button for everytime playing the game. 
        if(fate == 1)
        {
            m_Button1.text = answerValue; 
        }
        else if (fate == 2)
        {
            m_Button2.text = answerValue; 
        }
        else if (fate == 3)
        {
            m_Button3.text = answerValue; 
        }
        else
        {
            m_Button4.text = answerValue; 
        }

        //To fill up other buttons with the wrong answer

        int firstFakeValue = answer + random.Next(1, 20);
        int secondFakeValue = answer + random.Next(1, 20);
        if(firstFakeValue == secondFakeValue)
        {
            secondFakeValue++; 
            if(firstFakeValue == answer)
            {
                firstFakeValue++;
                secondFakeValue++; 
            }
            
        }

        int thirdFakeValue = answer - random.Next(1, 20);
        int fourthFakeValue = answer - random.Next(1, 20); 
        if( thirdFakeValue == fourthFakeValue)
        {
            fourthFakeValue++; 
            if(thirdFakeValue == answer)
            {
                thirdFakeValue++;
                fourthFakeValue++; 
            }
        }

        if(fate != 1)
        {
            m_Button1.text = firstFakeValue.ToString(); 
        }
        if(fate != 2)
        {
            m_Button2.text = secondFakeValue.ToString(); 
        }
        if(fate != 3)
        {
            m_Button3.text = thirdFakeValue.ToString(); 
        }
        if(fate != 4)
        {
            m_Button4.text = fourthFakeValue.ToString(); 
        }

        //timer
        //startTime = Time.time;
        //m_Timer.text = timerText.ToString();
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        
    }

    IEnumerator LoadScene(float amount)
    {
        yield return new WaitForSeconds(amount);
        CubeThrowingArea.SetActive(true);
        BrainMathsRoom.SetActive(false);
    }

    void Update()
    {
        m_Answer.text = timeTotal.ToString();

        if (finnished)
        {       
                Button1.enabled = false;
                Button2.enabled = false;
                Button3.enabled = false;
                Button4.enabled = false;

            // BrainMathsRoom.SetActive(false);
            // CubeThrowingArea.SetActive(true);
            StartCoroutine(LoadScene(Countdown));

            
            ScoreSheet.SetActive(true);
            MathsRoomAudio.SetActive(false); 

            //UnityEngine.SceneManagement.SceneManager.LoadScene("Splash");
            return;
            
        }
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        Debug.Log((int)t % 60); 

        finalTime = (int)t % 60;
        if (StartButton.enabled == false)
        {
            m_Timer.text = minutes + ":" + seconds;
        }
    }

    public void Button1Click()
    {
        
        Button1.enabled = false;
        timeTotal += 15;

        if (Button1.enabled == false)
        {
            if (fate == 1)
            {
                timeTotal -= 15;
                finnished = true;
                //UnityEngine.SceneManagement.SceneManager.LoadScene("Splash");
            }
        }
    }

    public void Button2Click()
    {

        Button2.enabled = false;
        timeTotal += 15;

        if (Button2.enabled == false)
        {
            if (fate == 2)
            {
                timeTotal -= 15;
                finnished = true;
                //UnityEngine.SceneManagement.SceneManager.LoadScene("Splash");
            }
        }
    }

    public void Button3Click()
    {

        Button3.enabled = false;
        timeTotal += 15;

        if (Button3.enabled == false)
        {
            if (fate == 3)
            {
                timeTotal -= 15;
                finnished = true;
                //UnityEngine.SceneManagement.SceneManager.LoadScene("Splash");
            }
        }
    }

    public void Button4Click()
    {

        Button4.enabled = false;
        timeTotal += 15;

        if (Button4.enabled == false)
        {
            if (fate == 4)
            {
                timeTotal -= 15;
                finnished = true;
                //UnityEngine.SceneManagement.SceneManager.LoadScene("Splash");
            }
        }
    }

    public void Finish()
    {
        finnished = true;

    }

}
