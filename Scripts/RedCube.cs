using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : MonoBehaviour
{
    public GameObject barrierName;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Barriers")
        {
            barrierName.SetActive(false); 
            Debug.Log("Barriers Destroyed.");
        }
        else
        {
            Debug.Log("wtf!");
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
