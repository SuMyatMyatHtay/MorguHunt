using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameScreen : MonoBehaviour
{
    public void IwantSceneChange()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("GameStart");
    }
}
