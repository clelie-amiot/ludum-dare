﻿using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public float speed = 1f;
	public Rigidbody2D rb;
	public Transform firePoint;

	// Use this for initialization
	void Start () {
		rb.velocity = firePoint.right * speed;	
	}

	void OnTriggerEnter2D(Collider2D hitInfo) {
		Debug.Log (hitInfo.name);
		// Destroy (gameObject);
	}

}