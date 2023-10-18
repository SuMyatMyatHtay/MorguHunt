using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public string apiKey;
    public float lat = 43.7f;
    public float lon = -120.4371f;
    public float zoom = 4.9f;
    private string style_id = "streets-v11";

    private string url = "";
    private int mapWidth = 500;
    private int mapHeight = 500;
    private bool mapIsLoading = false; //not used. Can be used to know that the map is loading 
    private Rect rect;

    private string apiKeyLast;
    private float latLast = 43.7f;
    private float lonLast = -120.4371f;
    private float zoomLast = 4.9f;
    private string style_idLast = "streets-v11";
    private bool updateMap = true;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetMapBox());
        rect = gameObject.GetComponent<RawImage>().rectTransform.rect;
        mapWidth = (int)Math.Round(rect.width);
        mapHeight = (int)Math.Round(rect.height);
    }

    // Update is called once per frame
    void Update()
    {
        if (updateMap && (apiKeyLast != apiKey || !Mathf.Approximately(latLast, lat) || !Mathf.Approximately(lonLast, lon) || zoomLast != zoom ))
            {
            rect = gameObject.GetComponent<RawImage>().rectTransform.rect;
            mapWidth = (int)Math.Round(rect.width);
            mapHeight = (int)Math.Round(rect.height);
            StartCoroutine(GetMapBox());
            updateMap = false;
        }
    }


    IEnumerator GetMapBox()
    {
        url = "https://api.mapbox.com/styles/v1/mapbox/" +style_id+"/static/"+ lon + "," + lat +","+zoom +"/"+ mapWidth + "x" + mapHeight + "?"+"access_token=" + apiKey;
        mapIsLoading = true;
        Debug.Log(url);
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log("WWW ERROR: " + www.error);
        }
        else
        {
            mapIsLoading = false;
            gameObject.GetComponent<RawImage>().texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            apiKeyLast = apiKey;
            latLast = lat;
            lonLast = lon;
            zoomLast = zoom;
            style_idLast = style_id;
            updateMap = true;
        }
    }

}
