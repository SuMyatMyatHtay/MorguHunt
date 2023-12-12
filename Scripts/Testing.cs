using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
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
