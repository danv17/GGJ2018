using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    BoxCollider2D bc2d;
    Rigidbody2D rb2d;
    public float speed = 3.0f;    
   
   

    // Use this for initialization
    void Start ()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        bc2d = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = new Vector2(x, y) * speed; //rb2d.velocity.x

        Destroy(this.gameObject, 1);
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }

    public void waveMove(float x)
    {
        this.rb2d.velocity.Set(x,0);
    }
}
