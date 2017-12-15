using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using HexMapGenerator;
public abstract class Manager : Singleton<Manager> {

	#region Variables

	protected MapInitializer _mapInitializer;

	#endregion

	#region Methods

	public abstract void Initialize ();

	#endregion
}
