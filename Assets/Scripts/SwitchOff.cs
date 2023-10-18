using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOff : MonoBehaviour
{
    public Light light;
   


    public void off()
    {
        light.enabled = false;
    }
}
