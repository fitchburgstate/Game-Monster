﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowParentVelocity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//transform.LookAt(transform.parent.GetComponent<Rigidbody>().velocity);
		//transform.rotation = Quaternion.LookRotation(transform.parent.GetComponent<Rigidbody>().velocity,transform.up);
		transform.Rotate (0, transform.parent.GetComponent<Rigidbody> ().velocity.magnitude, 0);

	}
}