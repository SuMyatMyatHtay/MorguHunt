using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoIntoHouse : MonoBehaviour
{
    public float Countdown = 5.0f;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(LoadScene(Countdown));
        UnityEngine.SceneManagement.SceneManager.LoadScene("LoadingScreenBetweenGames");
        
    }

    IEnumerator LoadScene(float amount)
    {
        yield return new WaitForSeconds(amount);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Bomb");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
