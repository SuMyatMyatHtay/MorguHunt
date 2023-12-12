using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//---------------------------------------
// Author           : SU MYAT MYAT HTAY 
// Date             : 2023-02-11
// Description      : The cube will be destroyed if the cube is thrown to the different direction. 
//---------------------------------------

public class AcidFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "CubeThrowing")
        {
            Destroy(col.gameObject);
            Debug.Log("ACidFloor Collision Enter.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
