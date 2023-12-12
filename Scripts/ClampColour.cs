using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampColour : MonoBehaviour
{
    public GameObject clampMesh;
    public GameObject clamp;
    public Material Red;
    public Material Blue;
    public Material Green;
    public Material Purple;
    public Material Yellow;
    private GameObject _selectedClamp;
    // Start is called before the first frame update
    void Start()
    {
        //get random number
        System.Random random = new System.Random();
        int num = random.Next(1, 6);
        //color of the clamp depends on the random number produced at the start of the game
        if (num == 1)
        {
            clampMesh.GetComponent<MeshRenderer>().material = Red;
            clampMesh.name = "RedClamp";

        }
        else if (num == 2)
        {
            clampMesh.GetComponent<MeshRenderer>().material = Blue;
            clampMesh.name = "BlueClamp";
        }
        else if (num == 3)
        {
            clampMesh.GetComponent<MeshRenderer>().material = Green;
            clampMesh.name = "GreenClamp";
        }
        else if (num == 4)
        {
            clampMesh.GetComponent<MeshRenderer>().material = Purple;
            clampMesh.name = "PurpleClamp";
        }
        else if (num == 5)
        {
            clampMesh.GetComponent<MeshRenderer>().material = Yellow;
            clampMesh.name = "YellowClamp";
        }
    }



  
}
