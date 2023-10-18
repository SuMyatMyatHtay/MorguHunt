using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadToMain : MonoBehaviour
{
	#region Variables
	//===================
	// Public Variables
	//===================
	public string Main;

	#endregion

	#region Own Methods
	public void LoadMyScene(string Main)
	{
		
		SceneManager.LoadScene("Main");
	}
	#endregion
}
