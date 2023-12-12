using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//---------------------------------------
// Author           : SU MYAT MYAT HTAY 
// Date             : 2023-02-11
// Description      : this script is no longer in use.
//---------------------------------------

public class LuckyCube : MonoBehaviour
{
    public GameObject cubeDoor; 
    private void OnColliderEnter(Collision col)
    {
        if (col.gameObject.tag == "CubeThrowingDoor")
        {
            cubeDoor.SetActive(false); 
            Debug.Log("CubeThrowingDoor Destroyed.");
        }
        else
        {
            Debug.Log("collision enter thanks god");
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
