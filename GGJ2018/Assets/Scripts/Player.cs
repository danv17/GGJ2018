﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public BoxCollider2D bc2d;
    public Rigidbody2D rb2d;
    public Animator anim;
    public GameObject waveInstance;
    public GameObject wavePrefab;
    public bool isFacingUp;
    public bool isFacingRight;
    public GameObject energy;
    public int maxNumWave = 5;
    public int contEnergyHits = 0;

    // Use this for initialization
    void Start()
    {
        bc2d = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        energy = GameObject.FindGameObjectWithTag("Energy");
        //StartCoroutine("waveDestroy",wave);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        this.movement(x, y);
        this.shoot();
        this.loadEnergy();

        if (x > 0.5f)
        {
            isFacingRight = true;
            //anim.SetBool("isRight", true);

        }
        if (x < -0.5f)
        {
            isFacingRight = false;
            //anim.SetTrigger ("playerMoveLeft");

        }
        if (y > 0.5f)
        {
            isFacingUp = true;
            //anim.SetTrigger ("playerMoveUp");

        }
        if (y < -0.5f)
        {
            isFacingUp = false;
            //anim.SetTrigger ("playerMoveDown");

        }
        //Debug.Log("isRight: " + isFacingRight + ", isUpt: " + isFacingUp);
    }

    void movement(float x, float y)
    {
        this.transform.Translate(new Vector2(x, y) * Time.deltaTime * 3.0f);
        //Debug.Log(x + ", " + y);
    }

    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.C) && maxNumWave > 0)
        {
            anim.SetTrigger("playerChop");
            Instantiate(wavePrefab, transform.position, transform.rotation);
            SpriteRenderer[] b = energy.GetComponent<Battery>().batteries;
            int i = energy.GetComponent<Battery>().cont;
            b[i].enabled = false;
            maxNumWave--;
            contEnergyHits = 0;
        }
    }

    void loadEnergy()
    {
        SpriteRenderer[] b = energy.GetComponent<Battery>().batteries;
        int i = energy.GetComponent<Battery>().cont;
        rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Se activa la animación solo cuando la energía es menor a 5
            if (i < 5)
            {
                anim.SetTrigger("playerHit");
            }
            contEnergyHits++;
            //if (contEnergyHits == 8)
            //{
            //    if (!b[1].isVisible)
            //    {
            //        b[1].enabled = true;
            //        maxNumWave++;
            //    }
            //}
            //if (contEnergyHits == 13)
            //{
            //    if (!b[2].isVisible)
            //    {
            //        b[2].enabled = true;
            //        maxNumWave++;
            //    }
            //}
            //if (contEnergyHits == 17)
            //{
            //    if (!b[3].isVisible)
            //    {
            //        b[3].enabled = true;
            //        maxNumWave++;
            //    }
            //}
            //if (contEnergyHits == 21)
            //{
            //    if (!b[4].isVisible)
            //    {
            //        b[4].enabled = true;
            //        maxNumWave++;
            //    }
            //}
            //if (contEnergyHits == 25)
            //{
            //    if (!b[5].isVisible)
            //    {
            //        b[5].enabled = true;
            //        contEnergyHits = 0;
            //        maxNumWave = 5;
            //    }
            //}

            if (contEnergyHits == 25)
            {
                if (!b[5].isVisible)
                {
                    b[5].enabled = true;
                    contEnergyHits = 0;
                    maxNumWave = 5;
                }
            }
            else if (contEnergyHits == 21)
            {
                if (!b[4].isVisible)
                {
                    b[4].enabled = true;
                    maxNumWave++;
                }
            }
            else if (contEnergyHits == 17)
            {
                if (!b[3].isVisible)
                {
                    b[3].enabled = true;
                    maxNumWave++;
                }
            }
            else if (contEnergyHits == 13)
            {
                if (!b[2].isVisible)
                {
                    b[2].enabled = true;
                    maxNumWave++;
                }
            }
            else if (contEnergyHits == 8)
            {
                if (!b[1].isVisible)
                {
                    b[1].enabled = true;
                    maxNumWave++;
                }
            }
        }
    }
}
