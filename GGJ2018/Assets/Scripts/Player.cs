using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public BoxCollider2D bc2d;
    public Rigidbody2D rb2d;
    public Animator anim;

	// Use this for initialization
	void Start () {

        bc2d = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetTrigger("playerChop");
        }
	}
}
