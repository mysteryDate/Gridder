﻿using UnityEngine;
using System.Collections;

public class WaterRise : MonoBehaviour {

	[HideInInspector]
	public float waterLevel = -10;
	public Transform waterRep;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		waterLevel += Time.deltaTime/5;
		waterRep.position = new Vector3 (waterRep.position.x, waterLevel ,waterRep.position.z);
	}
}
