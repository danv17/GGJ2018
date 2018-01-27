using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frecuencia : MonoBehaviour {

	// Use this for initialization
	public float speed = 10.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float translation = Input.GetAxis ("Horizontal") * speed;
		if (Input.GetKey(KeyCode.Z))
		{
			transform.Translate (new Vector3(0.02f,0,0));
		}
		if (Input.GetKey(KeyCode.X))
		{
			transform.Translate (new Vector3(-0.02f,0,0));
		}
	}
}
