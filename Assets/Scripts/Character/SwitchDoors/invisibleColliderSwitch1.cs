﻿using UnityEngine;
using System.Collections;

public class invisibleColliderSwitch1 : MonoBehaviour {

	public static bool mvdFrmSwitch=false;
	// Use this for initialization// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D( Collider2D col) {  
		
		if (col.gameObject.name == "pf_Character") { 
			mvdFrmSwitch=true;

			
		}
	}
}