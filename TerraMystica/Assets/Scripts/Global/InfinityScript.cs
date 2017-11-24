using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityScript : MonoBehaviour {

	[SerializeField]
	bool _shouldBeInvincible;

	// Use this for initialization
	void Start () {
		if (_shouldBeInvincible) {
			DontDestroyOnLoad (gameObject);
		}
	}
}
