using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//---------------------------------------
// Author           : SU MYAT MYAT HTAY 
// Date             : 2023-02-11
// Description      : To quit the game
//---------------------------------------

public class ApplicationQuit : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit(); 
        //UnityEditor.EditorApplication.isPlaying = false; 
    }
}
