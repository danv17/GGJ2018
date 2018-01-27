using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public BoxCollider2D bc2d;
    public Rigidbody2D rb2d;
    public float speed = 2f;

    // Use this for initialization
    void Start () {
        bc2d = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            
        }
	}
}
