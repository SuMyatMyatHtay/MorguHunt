using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp: MonoBehaviour
{
    public GameObject clamp;
    public GameObject correctClampCheck;
   
   private GameObject _selectedClamp;
    // Start is called before the first frame update
    void Start()
    {
        //empty gameobjects that appears only when the clamp is place at the correct spots
        correctClampCheck.SetActive(false);
    }
   
 

    protected void OnTriggerEnter(Collider col)
    {
        //Get the clamp that will be snapped to socket
        _selectedClamp = col.gameObject;
        Debug.Log("col: ["+ _selectedClamp.name + "]");
    }
    public void isCorrectClamp()
    {
        //Check if clamp name concat with "ClampSocket" is equivalent to the socket name
        //Name the meshes of the clamps with colliders have to be named correctly vs the socket names

    

        if ((_selectedClamp.name + "Socket") == gameObject.name)
        {
            Debug.Log("Correct Match");
            //empty gameobjects appears
            correctClampCheck.SetActive(true);

        }
        else
        {
           Debug.Log("Mismatch");
            
        }
    }
    //function called when player re-grabs clamps to put it somewhere else
    public void exitClamp()
    {
        correctClampCheck.SetActive(false);
        Debug.Log("exit");
    }
    }
