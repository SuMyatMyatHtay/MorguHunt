using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//---------------------------------------
// Author           : SU MYAT MYAT HTAY 
// Date             : 2023-02-11
// Description      : calculate the score and it will be shown after the user got the correct maths answer.
//---------------------------------------

public class LevelCalculate : MonoBehaviour
{

    public ChangeQuestion script;
    public int finalscore; 

    [SerializeField] TextMeshProUGUI m_FinalResult;

    void Update()
    {
        finalscore = script.timeTotal + script.finalTime;
        m_FinalResult.text = finalscore.ToString();
    }
}
