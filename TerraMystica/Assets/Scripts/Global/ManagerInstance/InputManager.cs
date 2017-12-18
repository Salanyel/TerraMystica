using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HexMapGenerator;
using UnityEngine.EventSystems;

public class InputManager : Singleton<InputManager> {

	HexGrid _map;

	public HexGrid Map {
		set { _map = value; }
	}

	#region Variables

	#endregion

	#region Unity

	void Update() {
		if (Input.GetMouseButton (0) && !EventSystem.current.IsPointerOverGameObject ()) {
			HandleInput ();
		}
	}

	#endregion

	#region Methods

	void HandleInput() {
		Ray inputRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (inputRay, out hit)) {
			HexCell currentCell = _map.GetCell (hit.point);
			if (currentCell) {
				TerraFormer.Instance.Terraform (currentCell);
			}
		}
	}
	
	#endregion
}
