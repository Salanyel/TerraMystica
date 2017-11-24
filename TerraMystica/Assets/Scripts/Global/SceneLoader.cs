using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	#region Methods

	public void LoadScene(int p_sceneIndex) {
		SceneManager.LoadScene (p_sceneIndex);
	}

	#endregion
}
