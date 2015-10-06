﻿using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	public int typePower = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{

			PowerupController powerMgr = GameObject.Find ("Gun").GetComponent<PowerupController>();
			
			//Call Function
			powerMgr.addPowerup(typePower);

			Destroy(gameObject);
		}
	}
}
