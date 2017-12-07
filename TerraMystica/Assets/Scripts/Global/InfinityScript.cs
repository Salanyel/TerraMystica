using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityScript : MonoBehaviour {

	[SerializeField]
	bool _shouldBeInvincible;

	// Use this for initialization
	void Start () {
		ApplyBehaviour (_shouldBeInvincible);
	}

	public void ApplyBehaviour(bool p_value) {
		_shouldBeInvincible = p_value;

		if (_shouldBeInvincible) {
			DontDestroyOnLoad (gameObject);
		}
	}
}
