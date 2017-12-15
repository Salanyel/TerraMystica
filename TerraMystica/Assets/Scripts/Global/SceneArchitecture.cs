using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneArchitecture : MonoBehaviour {

	#region Variables

	[SerializeField]
	Scene _sceneEnum;

	#endregion

	#region Unity

	void Awake() {
		switch (_sceneEnum) {

		case Scene.MainMenu:
			GameObject mainMenuManager = Instantiate (Resources.Load<GameObject>("Prefabs/Managers/MainMenuManager"));
			mainMenuManager.GetComponent<MainMenuManager> ().Initialize ();
			break;

		case Scene.Game:
			GameObject gameManager = Instantiate (Resources.Load<GameObject>("Prefabs/Managers/GameManager"));
			gameManager.GetComponent<GameManager> ().Initialize ();
			break;

		default:
			Debug.LogError("--- State not detected: " + _sceneEnum);
			break;
		}
	}

	#endregion
	
}
