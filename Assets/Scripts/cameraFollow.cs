using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	public Transform TargetShip;
	Vector3 mainPos;


	Vector3 offsetV;

	public float lerp = 1;

	// Use this for initialization
	void Start () {
		offsetV = transform.position - TargetShip.position;
	}
	
	// Update is called once per frame
	void Update () {
		mainPos = offsetV + TargetShip.position;
		mainPos.x = transform.position.x;
		transform.position = Vector3.Lerp (transform.position, mainPos, Time.deltaTime * lerp);
	}
	}

