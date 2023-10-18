using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadtoProfile : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Profile");
    }
 
}
