using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion_radio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Z)){//presiona A y se mueve la izquierda
			transform.Rotate(new Vector3(0,0,-1.0f));
		}	
		if(Input.GetKey(KeyCode.X)){//presiona A y se mueve la izquierda
			transform.Rotate(new Vector3(0,0,1.0f));
		}
	}	
}