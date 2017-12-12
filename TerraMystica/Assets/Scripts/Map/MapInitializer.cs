using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using HexMapGenerator;

public class MapInitializer : MonoBehaviour {

	#region Variables

	GameObject _mapPrefab;

	string _mapPath;

	HexGrid _map;

	public HexGrid Map {
		get { return _map; }
	}

	#endregion

	#region Methods 

	public void Initialize(GameObject p_mapGameObject, string p_path) {
		_mapPrefab = p_mapGameObject;
		_mapPath = p_path;
	}

	public void LoadMap() {
		InitializeObjects ();
	}

	void InitializeObjects() {
		MapInitialize ();
		Debug.Log ("--- Map Loaded");
	}
		
	void MapInitialize () {
		string path = _mapPath;
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
