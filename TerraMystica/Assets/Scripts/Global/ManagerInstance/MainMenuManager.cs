using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using HexMapGenerator;

public class MainMenuManager : Manager {

	#region Variables

	[SerializeField]
	GameObject _mapPrefab;

	MapInitializer _map;

	#endregion

	#region Override

	public override void Initialize() {
		TerraMysticaParameters.Initialize ();
		Debug.Log("--- Path: " + TerraMysticaParameters._mapPath);

		_map = gameObject.AddComponent<MapInitializer> ();
		_map.Initialize (_mapPrefab, TerraMysticaParameters._mapPath);
		_map.LoadMap ();
	}

	#endregion

	#region Methods

	#endregion

}
