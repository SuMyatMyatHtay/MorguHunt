using UnityEngine;
using UnityEngine.SceneManagement;
public class HouseLight : MonoBehaviour
{
    public string _tag;
    private GameObject lamps;
    public GameObject top;

    private void Update()
    {
        
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Awake:" + SceneManager.GetActiveScene().name);
        if (scene.name == "MainGame")
        {
            Debug.Log("SCene Name" + SceneManager.GetActiveScene().name);
            Turnon();

        }

    }

    private void Turnon()
    {

        GameObject lamps = GameObject.FindGameObjectWithTag("MainLamp");
        GameObject tmp = FindChildGameObjectByTag(lamps, _tag);
        Light tmplight = tmp.GetComponent<Light>();
        Light light = top.GetComponent<Light>();
        if (light.enabled == true)
        {

            if (tmp != null)
            {


                tmplight.enabled = true;
            }
        }



    }


    private GameObject FindChildGameObjectByTag(GameObject topParentGameObject, string gameObjectTag)
    {
        for (int i = 0; i < topParentGameObject.transform.childCount; i++)
        {
            if (topParentGameObject.transform.GetChild(i).tag == gameObjectTag)
            {
                return topParentGameObject.transform.GetChild(i).gameObject;
            }
            GameObject tmp = FindChildGameObjectByTag(topParentGameObject.transform.GetChild(i).gameObject, gameObjectTag);
            if (tmp != null)
            {
                return tmp;
            }
        }
        return null;
    }


}
