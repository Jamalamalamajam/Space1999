using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boid : MonoBehaviour {

	public float mass = 1;
	public float maximumSpeed = 10;

	public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = maximumSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);

	
	}
}
