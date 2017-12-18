using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HexMapGenerator;

public class TerraFormer : Singleton<TerraFormer> {

	#region Variables 

	public int _elevation;
	public int _terrainType;

	public int Elevation {
		set { _elevation = value; }
	}

	public int TerrainType {
		set { _terrainType = value; }
	}

	#endregion

	#region Unity

	#endregion

	#region Methods

	public void Terraform(HexCell p_cell) {
		p_cell.TerrainTypeIndex = _terrainType;
		p_cell.Elevation = _elevation;
	}

	#endregion
}
