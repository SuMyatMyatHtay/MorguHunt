using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
   public GameObject correctLeftBattery;
    public GameObject correctRightBattery;
    private GameObject _selectedBattery;
    private void Start()
    {
        correctLeftBattery.SetActive(false);
        correctRightBattery.SetActive(false);
    }
    protected void OnTriggerEnter(Collider col)
    {
        _selectedBattery = col.gameObject;
    }
    public void isCorrectBatt()
    {
        if (gameObject.name == "LeftBatterySocket")
        {
            if (_selectedBattery.name == "LeftBattery")
            {
                correctLeftBattery.SetActive(true);
                Debug.Log("corerctLeft" + _selectedBattery);
            }
        }
        else if (gameObject.name == "RightBatterySocket")
        {
            if (_selectedBattery.name == "RightBattery")
            {
                correctRightBattery.SetActive(true);
                Debug.Log("corerctRight" + _selectedBattery);
            }
        }
    }
    //function called when player re-grabs clamps to put it somewhere else
    public void exitBatt()
    {
        if (gameObject.name == "LeftBatterySocket")
        {           
                correctLeftBattery.SetActive(false);
        }
        else if (gameObject.name == "RightBatterySocket")
        {
            correctRightBattery.SetActive(false);

        }
    }
}
