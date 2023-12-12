using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuController : MonoBehaviour
{
    public void LoadGame (string input)
    {
        StateNameContoller.CatcherLevel = input; 
        SceneManager.LoadScene("Testing"); 
    }
}
