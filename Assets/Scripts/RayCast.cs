using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class RayCast : MonoBehaviour
{
   
    public Camera _camera;
    public float Ray_dist;
    public TextMeshProUGUI completeMapText;
    public TextMeshProUGUI completeCharacterShootingText;
    public TextMeshProUGUI updateCharacterShot;
    public float time = 10.0f;
    public AudioSource completeAudio;
    public AudioSource hitAudio;
    public GameObject Switch;
    private GameObject[] cubes;
    private int count=0;
    private List<string> colorList = new List<string>();
    private void Start()
    {
       completeMapText.enabled = false;
        completeCharacterShootingText.enabled = false;
        updateCharacterShot.enabled = false;
        cubes = GameObject.FindGameObjectsWithTag("Cube");
    }
    private void Update()
    {

        if (Input.GetMouseButtonDown(0)) //left click
        {
            Ray _ray = new Ray(_camera.transform.position, _camera.transform.forward);
            RaycastHit _hit;
            //Debug is for debug purposes, it does not show up in the game view
            Debug.DrawRay(_camera.transform.position, _camera.transform.forward * Ray_dist, Color.red);

            if (Physics.Raycast(_ray, out _hit, Ray_dist))
            {
                
                //for map
                if (_hit.transform.gameObject.tag == "Cube")
                {
                    hitAudio.Play();
                    _hit.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                    checkIfMapGameComplete();
                }

                //for character shooting
                if (_hit.transform.gameObject.tag == "Enemies")
                {
                    //when player hits the enemy, impact sfx plays
                    hitAudio.Play();

                    //count number of character hit
                    count += 1;
                    updateCharacterShot.text = "Hit " + _hit.transform.gameObject.tag +" \n"+ count + "/6 remaining";
                    UpdateShooting(time);
                    //if hit all 6 characters
                    if (count == 6)
                    {
                        completeAudio.Play();
                        StartCoroutine(CharacterCompleteText(time));
                        
                    }
                    Destroy(_hit.transform.gameObject);
                }

                //for switch (altenative to pressing it)
                if (_hit.transform.gameObject == Switch){
                    triggerSwitch();
                }
            }
        }
    }

    //for when switch is hit by raycast, go to "CircuitDemo"
    private void triggerSwitch()
    {
        #region Variables
        //===================
        // Public Variables

        SceneManager.LoadScene("CircuitDemo");

        #endregion
    }
   //Show complete text when all chracters are shoot for character shooting game;
    IEnumerator CharacterCompleteText(float time)
    {
        updateCharacterShot.enabled = false;
        completeCharacterShootingText.enabled = true;
        yield return new WaitForSeconds(time);
        completeCharacterShootingText.enabled = false;
    }

    IEnumerator UpdateShooting(float time)
    {
       
        updateCharacterShot.enabled = true;
        yield return new WaitForSeconds(time);
        updateCharacterShot.enabled = false;
    }

    //basically a function that checks if the map game is complete
    private void checkIfMapGameComplete()
    {
        cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach (GameObject cube in cubes)
        {

            //add the colors to colorList
            colorList.Add(cube.GetComponent<Renderer>().material.GetColor("_Color").ToString());

        };


        for (int i = 0; i < 23; i++)
        {
            //if one element in the colorList does not match the color,it will clear the colourList
            //and check the new colorList when cthe cube is hit;
            if (colorList[i] != "RGBA(1.000, 0.000, 0.000, 1.000)")
            {
                i = 25;
                count = 0;
                colorList.Clear();
            }
            //if all element have red rgba value, it means game is complete
            else if (colorList[i] == "RGBA(1.000, 0.000, 0.000, 1.000)")
            {
                count += 1;
            }
            if (count == 23)
            {
                completeAudio.Play();
                completeMapText.enabled = true;
            }
        }
    }
}