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
			if(Input.GetKey(KeyCode.Z)){//presiona Z y rota a la izquierda
				transform.Rotate(new Vector3(0,0,-1.0f));
				
			}	
			if(Input.GetKey(KeyCode.X)){//presiona X y rota a la derecha
				transform.Rotate(new Vector3(0,0,1.0f));
			}
		//}
	}	

}

