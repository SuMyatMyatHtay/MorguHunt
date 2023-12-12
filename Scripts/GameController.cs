using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; 

public class GameController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Catcher;
    // Start is called before the first frame update
    void Start()
    {
        m_Catcher.text = StateNameContoller.CatcherLevel;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
