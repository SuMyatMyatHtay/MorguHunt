using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformCube : MonoBehaviour
{
    public LevelCalculate lcscript; 

    // Start is called before the first frame update
    void OnEnable()
    {
        if(lcscript.finalscore <= 15)
        {
            transform.position = new Vector3(43, -6, 22); 
        }
        else
        {
            transform.position = new Vector3(25, 2, -3); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
