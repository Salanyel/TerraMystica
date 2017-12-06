using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using HexMapGenerator;
public class GameManager : MonoBehaviour {

	#region Variables

	[SerializeField]
	GameObject _mapPrefab;

	HexGrid _map;

	#endregion

	#region Methods

	public void Initialize() {
		Debug.Log ("--- Start Initialization");
		InitializeObjects ();
		InitializeReferences ();
	}

	void InitializeObjects() {
		MapInitialize ();
		Debug.Log ("--- Map Loaded");
	}

	void InitializeReferences() {
		FindObjectOfType<HexMapCamera> ().Grid = _map;
		Debug.Log ("--- HexMapCamera references initialized");
	}

	void MapInitialize () {
		string path = Path.Combine (Application.dataPath, "Resources/Map/TerraMystica.map");
		_map = Instantiate(_mapPrefab).GetComponent<HexGrid>();

		using (BinaryReader reader = new BinaryReader(File.OpenRead(path))) {

			int header = reader.ReadInt32 ();
			if (header == 0) {
				_map.Load (reader);
			} else {
				Debug.LogWarning ("Unknow map format " + header);
			}
		}
	}

	#endregion
}
