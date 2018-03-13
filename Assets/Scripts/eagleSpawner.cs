using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagleSpawner : MonoBehaviour {

	public float gap = 20;
	public float followers = 2;
	public GameObject prefab;

	public float maximumSpeed = 10;

	public Transform target;

	public GameObject prefab1, prefab2, prefab3, prefab4, prefab5;
	// Use this for initialization
	void Awake(){

		float step = maximumSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);

		Instantiate (prefab1, new Vector3 (0, 0, 0), Quaternion.identity);
		Instantiate (prefab2, new Vector3 (gap, 0, -gap), Quaternion.identity);
		Instantiate (prefab3, new Vector3 (gap + gap, 0, -gap - gap), Quaternion.identity);
		Instantiate (prefab4, new Vector3 (-gap, 0, -gap), Quaternion.identity);
		Instantiate (prefab4, new Vector3 (-gap - gap, 0, -gap - gap), Quaternion.identity);
	
		//Instantiate (prefab);
		//Instantiate (prefab, new Vector3 (gap, 0, gap), Quaternion.identity);
		//Instantiate (prefab, new Vector3 (gap, 0, gap), Quaternion.identity);

	}
	void Start () {
		Awake ();
	}
	
	// Update is called once per frame
	void Update () {


	}
}
