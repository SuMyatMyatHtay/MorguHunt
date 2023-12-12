using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashNext : MonoBehaviour
{
    public float Countdown = 3.0f;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(LoadScene(Countdown));
    }

    IEnumerator LoadScene(float amount)
    {
        yield return new WaitForSeconds(amount);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
