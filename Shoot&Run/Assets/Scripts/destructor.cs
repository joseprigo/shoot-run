﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "obstaculo" || other.gameObject.tag == "obstaculoabajo") {
			Destroy (other.gameObject);
		}
	}
}
