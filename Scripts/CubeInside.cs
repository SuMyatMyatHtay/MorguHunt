using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInside : MonoBehaviour
{
    public GameObject slide;
    public GameObject doorToExit; 
    // Start is called before the first frame update
    void Start()
    {
        slide.SetActive(false);
        doorToExit.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "CubeThrowing")
        {
            slide.SetActive(true);
            doorToExit.SetActive(false); 
            Debug.Log("On Collision Enter.");
        }
        else
        {
            Debug.Log(col.gameObject); 
        }
    }

}
