using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public BoxCollider2D bc2d;
    public Rigidbody2D rb2d;
    public Animator anim;
    public Wave wave;


	// Use this for initialization
	void Start ()
    {
        bc2d = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("playerChop");
            Instantiate(wave, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            wave.transform.Translate(new Vector2(5 * wave.speed * Time.deltaTime, 0));
            DestroyObject(wave);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //anim.SetTrigger ("playerMove");

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //anim.SetTrigger ("playerMove");

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //anim.SetTrigger ("playerMoveUp");

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //anim.SetTrigger ("playerMove");

        }
    }
}
