﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Character"){
			col.gameObject.SendMessage("BananaPickup");
			Destroy(gameObject);

		}

	}
}
