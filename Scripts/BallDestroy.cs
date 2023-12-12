using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//---------------------------------------
// Author           : SU MYAT MYAT HTAY 
// Date             : 2023-02-11
// Description      : This is for red cube. If the red cube touch the barrier, the barrier will be destroyed. 
//---------------------------------------

public class BallDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "CubeThrowing")
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene("testing");
            Debug.Log("YoYo touch the wall");
            Destroy(col.gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
