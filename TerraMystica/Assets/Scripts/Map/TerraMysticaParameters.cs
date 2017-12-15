using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TerraMysticaParameters {

	#region Variables

	public static string _mapPath = "";

	static bool _hasBeenInitialized = false;

	#endregion

	#region Methods

	public static void Initialize() {
		if (_hasBeenInitialized) {
			return;
		}

		_hasBeenInitialized = true;
		_mapPath = Path.Combine (Application.dataPath, "Resources/Map/TerraMystica.map");
	}

	#endregion
}
