using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hitDisplay : MonoBehaviour
{

    public GameObject mathQuestion;
    public TextMeshProUGUI wrongInput;
    private void Start()
    {
        mathQuestion.SetActive(false);
    }

    protected void OnTriggerEnter(Collider col)
    { 
       if (col.name == "Hammer")
        {
            transform.Translate(Vector3.forward);
            mathQuestion.SetActive(true);
            wrongInput.enabled = false;
        }
    }
}
