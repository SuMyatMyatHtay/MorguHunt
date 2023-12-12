using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//---------------------------------------
// Author           : SU MYAT MYAT HTAY 
// Date             : 2023-02-11
// Description      : This is if the player falls from the floor
//---------------------------------------

public class AccidentDeath : MonoBehaviour
{
    //move to the another scene after waiting for the countdown time. 
    public float Countdown = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "PlayerCamera")
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene("testing");
            //Debug.Log("On Collision Enter.");
            StartCoroutine(LoadScene(Countdown));
        }

    }

    IEnumerator LoadScene(float amount)
    {
        yield return new WaitForSeconds(amount);
        
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
