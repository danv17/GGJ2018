using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion_radio : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//while(z!=180 | z!=-180 ){
			if(Input.GetKey(KeyCode.Z)){//presiona A y se mueve la izquierda
				//transform.Rotate(new Vector3(0,0,-1.0f));
			transform.RotateAround(Vector3.zero,Vector3.forward,20 *Time.deltaTime);
			}	
			if(Input.GetKey(KeyCode.X)){//presiona A y se mueve la izquierda
				transform.Rotate(new Vector3(0,0,1.0f));
			}
		//}
	}	
}