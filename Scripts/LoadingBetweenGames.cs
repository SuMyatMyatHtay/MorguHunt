using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingBetweenGames : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LoadingScreenBetweenGames");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
