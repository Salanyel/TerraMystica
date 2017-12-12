using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using HexMapGenerator;

public class GameManager : Manager {

	#region Variables

	[SerializeField]
	GameObject _mapPrefab;

	MapInitializer _map;

	#endregion

	#region Override

	public override void Initialize() {
		_map = gameObject.AddComponent<MapInitializer> ();
		_map.Initialize (_mapPrefab, TerraMysticaParameters._mapPath);
		_map.LoadMap ();

		InitializeCamera ();
	}

	#endregion

	#region Methods

	void InitializeCamera() {
		FindObjectOfType<HexMapCamera> ().Grid = _map.Map;
	}

	#endregion
		
}