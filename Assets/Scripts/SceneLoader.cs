using System.Collections;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public float Countdown = 5.0f;
    private void Start()
    {
        StartCoroutine(LoadScene(Countdown));
    }
    IEnumerator LoadScene(float amount)
    {
        yield return new WaitForSeconds(amount);
        UnityEngine.SceneManagement.SceneManager.LoadScene("LoadingScene");

    }
}
