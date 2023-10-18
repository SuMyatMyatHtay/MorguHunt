using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadtoGame : MonoBehaviour
{
	#region Variables
	//===================
	// Public Variables
	//===================
	public string MainGame;
	public GameObject top;
	public string _tag;
	private GameObject lamps;
	
	#endregion

	#region Own Methods
	public void LoadMyScene(string MainGame)
	{
		Scene scene = SceneManager.GetActiveScene();
		if (scene.name == "CircuitDemo")
        {
			top.transform.parent = null;
			DontDestroyOnLoad(top.gameObject);
		}

	SceneManager.LoadScene("MainGame");
	
	}
	#endregion
		}

