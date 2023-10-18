using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WallSensor : MonoBehaviour
{
    public GameObject[] characters;
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject character in characters)
        {
            if (character != null)
            {
                character.GetComponent<Animator>().SetTrigger("OnTriggerEnter");
            }
        }
    }
}

