﻿using UnityEngine;
using System.Collections;

public class movingBox : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D>().AddForce (transform.right * moveSpeed * Time.deltaTime);
	
	}
}
