using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    //1st button - Pink button will be showing the welcome text. Number of cubes are based on the result of Maths.  
    //2nd button - will be telling that the player is on the air. which means the player will die once fall off the place or all ball gone. 
    //3rd button - will be telling the player to put the cube inside the box so then the route will appear. 
    //4th button - will be showing the hint that red cube is dangerous. 

    public GameObject pinkText;
    public GameObject grayText;
    public GameObject blueText;
    public GameObject orangeText; 

    // Start is called before the first frame update
    void Start()
    {
        pinkText.SetActive(true);
        grayText.SetActive(false);
        blueText.SetActive(false);
        orangeText.SetActive(false); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pinkButtonClick()
    {
        Debug.Log("pink button click!");
        pinkText.SetActive(true);
        grayText.SetActive(false);
        blueText.SetActive(false);
        orangeText.SetActive(false);
    }

    public void grayButtonClick()
    {
        Debug.Log("pink button click!");
        pinkText.SetActive(false);
        grayText.SetActive(true);
        blueText.SetActive(false);
        orangeText.SetActive(false);
    }

    public void blueButtonClick()
    {
        Debug.Log("pink button click!");
        pinkText.SetActive(false);
        grayText.SetActive(false);
        blueText.SetActive(true);
        orangeText.SetActive(false);
    }

    public void orangeButtonClick()
    {
        Debug.Log("pink button click!");
        pinkText.SetActive(false);
        grayText.SetActive(false);
        blueText.SetActive(false);
        orangeText.SetActive(true);
    }
}
