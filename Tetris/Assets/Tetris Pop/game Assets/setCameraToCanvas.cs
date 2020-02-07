using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCameraToCanvas : MonoBehaviour {
	// Use this for initialization
	void Awake () {
				this.GetComponent<Canvas> ().worldCamera = Camera.main;
	}
}
