﻿using System.Collections;
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
        //StartCoroutine("waveDestroy",wave);
	}

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        this.movement(x, y);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("playerChop");
            Instantiate(wave, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            wave.transform.Translate(Vector2.right);
            
        }
        if (x > 0.5f)
        {
            //anim.SetTrigger ("playerMoveRight");

        }
        if (x < -0.5f)
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
        yield return new WaitForSeconds(1.0f);
        Debug.Log("Paso el tiempo");
        DestroyImmediate(w);
        Debug.Log("Destruir");
    }

    void movement(float x, float y)
    {
        this.transform.Translate(new Vector2(x, y) * Time.deltaTime);
    }
}
