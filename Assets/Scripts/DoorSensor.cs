using TMPro;
using UnityEngine;
using System.Collections;

public class enterDoor : MonoBehaviour
{
    public GameObject Door;
    public TextMeshProUGUI prompt_text;
    public float time = 10.0f;

    private void Start()
    {
        prompt_text.enabled = false;
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {

            StartCoroutine(ShowPrompt(time));

        }



    }
    IEnumerator ShowPrompt(float time)
    {
        prompt_text.enabled = true;
        yield return new WaitForSeconds(time);

        prompt_text.enabled = false;
    }
}