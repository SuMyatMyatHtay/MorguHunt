using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightBulb : MonoBehaviour
{
    public GameObject wirePreb;
    public GameObject bulbBottom;
    public GameObject onButton;
    public GameObject offButton;
    public Light light;
    private List<LineRenderer> WireObjectLR = new List<LineRenderer>();
    private void Start()
    {
        onButton.SetActive(false);
        offButton.SetActive(false);
    }
   
    private  void OnTriggerEnter(Collider other)
    {
        //Spawns 2 wires as children, then assign the line render as a reference
        WireObjectLR.Add(Instantiate(wirePreb, transform).GetComponent<LineRenderer>());
        WireObjectLR.Add(Instantiate(wirePreb, transform).GetComponent<LineRenderer>());

        //Set wire position for wire 1
        WireObjectLR[0].SetPosition(0, transform.position);
        WireObjectLR[0].SetPosition(1, other.transform.GetChild(2).position); //PosEnd

        //Set wire position for wire 2
        WireObjectLR[1].SetPosition(0, bulbBottom.transform.position);
        WireObjectLR[1].SetPosition(1, other.transform.GetChild(3).position); //NegEnd

        //Turn on the light
        light.enabled = true;
        onButton.SetActive(true);
        offButton.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        //Update wire position
        //Set wire position for wire 1
        WireObjectLR[0].SetPosition(0, transform.position);
        WireObjectLR[0].SetPosition(1, other.transform.GetChild(2).position);

        //Set wire position for wire 2
        WireObjectLR[1].SetPosition(0, bulbBottom.transform.position);
        WireObjectLR[1].SetPosition(1, other.transform.GetChild(3).position);
        onButton.SetActive(true);
        offButton.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        //Destroy the wires
        Destroy(WireObjectLR[0]);
        Destroy(WireObjectLR[1]);

        //Clear the list of missing objects
        WireObjectLR.Clear();

        //Turn off the light
        light.enabled = false;
        onButton.SetActive(true);
        offButton.SetActive(true);

     
    }
  
}

