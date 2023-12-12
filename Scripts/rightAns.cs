using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightAns : MonoBehaviour
{
    public GameObject MathQuestion;
  public void correctAns()
    {
        MathQuestion.SetActive(false);
    }
}
