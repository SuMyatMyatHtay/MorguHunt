using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingCubes : MonoBehaviour
{
    public float Countdown = 3.0f;

    public LevelCalculate scriptLC; 

    // Start is called before the first frame update
    public GameObject Cube1ToThrow;
    public GameObject Cube2ToThrow;
    public GameObject Cube3ToThrow;
    public GameObject Cube4ToThrow;
    public GameObject LuckyCube;
    public GameObject RedCube; 
 
    void Start()
    {
        
    }

    private void OnEnable()
    {
        if(scriptLC.finalscore <= 15)
        {
            Cube1ToThrow.SetActive(true);
            Cube2ToThrow.SetActive(true);
            Cube3ToThrow.SetActive(true);
            Cube4ToThrow.SetActive(true); 
        }
        else if(scriptLC.finalscore <= 30)
        {
            Cube1ToThrow.SetActive(true);
            Cube2ToThrow.SetActive(true);
            Cube3ToThrow.SetActive(false);
            Cube4ToThrow.SetActive(false);
        }
        else if(scriptLC.finalscore <= 45)
        {
            Cube1ToThrow.SetActive(true);
            Cube2ToThrow.SetActive(false);
            Cube3ToThrow.SetActive(false);
            Cube4ToThrow.SetActive(false);
        }
        else
        {
            Cube1ToThrow.SetActive(true);
            Cube2ToThrow.SetActive(false);
            Cube3ToThrow.SetActive(false);
            Cube4ToThrow.SetActive(false); 
        }

        //The percentage to get the extra cube is 1/5. 
        var random = new System.Random();
        int luck = random.Next(1, 11);
        int luck1 = random.Next(1, 11);

        if ( luck <= 2)
        {
            LuckyCube.SetActive(true); 
        }
        else
        {
            LuckyCube.SetActive(false); 
        }

        //the percentage to get the red cube is 1/2. 
        if ( luck1 <= 5)
        {
            RedCube.SetActive(true); 
        }
        else
        {
            RedCube.SetActive(false);
        }

        //the percentage to get both cubes is 0.15. (if my maths dont fail:D) 
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("CubeThrowing").Length == 0)
        {
            //Debug.Log("pleaseeeeee"); 
            //UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
            StartCoroutine(LoadScene(Countdown));
        }

    }

    IEnumerator LoadScene(float amount)
    {
        yield return new WaitForSeconds(amount);
        Debug.Log("pleaseeeeee");
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }


}
