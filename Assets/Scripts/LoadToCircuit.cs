using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadToCircuit : MonoBehaviour
{
	#region Variables
	//===================
	// Public Variables
	//===================
	public string CircuitDemo;

	#endregion
	private void OnMouseDown()
	{
		#region Variables
		//===================
		// Public Variables

		SceneManager.LoadScene("CircuitDemo");

		#endregion
	}
	
}


