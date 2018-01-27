using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion_radio : MonoBehaviour {

	public float smooth = 2.0F;
	public float tiltAngle = 30.0F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)){//presiona A y se mueve la izquierda
			float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
			Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
		}	

	}	
}