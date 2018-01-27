using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public BoxCollider2D bc2d;
    public Rigidbody2D rb2d;
    public Animator anim;
    public Wave wave;
	float speed = 1.0f;

	// Use this for initialization
	void Start ()
    {
        bc2d = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
<<<<<<< HEAD
	{	
		
		if (Input.GetKeyDown(KeyCode.Z))
=======
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        this.movement(x, y);

        if (Input.GetKeyDown(KeyCode.Z))
>>>>>>> 7af1f6f1bc7ebebf2d6d2cf9fca35b1189a0639d
        {
            anim.SetTrigger("playerChop");
            Instantiate(wave, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            wave.transform.Translate(new Vector2(5 * wave.speed * Time.deltaTime, 0));
            this.waveDestroy(wave);
            
        }
        if (x > 0.5f)
        {
            //anim.SetTrigger ("playerMoveRight");

        }
<<<<<<< HEAD
        if ()
=======
        if (x < -0.5f)
>>>>>>> 7af1f6f1bc7ebebf2d6d2cf9fca35b1189a0639d
        {
            //anim.SetTrigger ("playerMoveLeft");

        }
        if (y > 0.5f)
        {
            //anim.SetTrigger ("playerMoveUp");

        }
        if (y < -0.5f)
        {
            //anim.SetTrigger ("playerMoveDown");

        }
    }

    IEnumerator waveDestroy(Wave w)
    {
        yield return new WaitForSeconds(5.0f);
        DestroyObject(w);
    }

    void movement(float x, float y)
    {
        this.transform.Translate(new Vector2(x, y) * Time.deltaTime);
    }
}
