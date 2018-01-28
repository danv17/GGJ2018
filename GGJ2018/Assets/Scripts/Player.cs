using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int hp = 5;
    public BoxCollider2D bc2d;
    public Rigidbody2D rb2d;
    public Animator anim;
    public GameObject wavePrefab;
    public GameObject energy;
    public int maxNumWave = 5;
    public int contEnergyHits = 0;
    public bool isCharging = false;
    public GameObject[] glasses;
    public AudioClip[] glassBreak;
    public AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        bc2d = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        energy = GameObject.FindGameObjectWithTag("Energy");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        this.loadEnergy();
        if (!isCharging && hp>0)
        {
            if(x != 0 || y != 0)
            {
                this.movement(x, y);
                anim.SetFloat("lastPosX", x);
                anim.SetFloat("lastPosY", y);
                anim.SetBool("isMoving", true);
                this.shoot();
            }
            
        }
        else
        {
            anim.SetBool("isMoving", false);
        }


        //if (energy.GetComponent<Battery>().cont == 0)
        //{
        //    this.loadEnergy();
        //}

        if (x > 0.5f || x < -0.5f)
        {
            anim.SetFloat("posX", x);

        }
        if (y > 0.5f || y < -0.5f)
        {
            anim.SetFloat("posY", y);
        }
    }

    void movement(float x, float y)
    {
        anim.SetBool("isMoving", true);
        this.transform.Translate(new Vector2(x, y) * Time.deltaTime * 3.0f);
    }

    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.C) && maxNumWave > 0)
        {
            //anim.SetTrigger("playerChop"); playerChop ya no existe para girl
            Instantiate(wavePrefab, transform.position, transform.rotation);
            SpriteRenderer[] b = energy.GetComponent<Battery>().batteries;
            int i = energy.GetComponent<Battery>().cont;
            b[i].enabled = false;
            maxNumWave--;
            if (maxNumWave == 0)
            {
                contEnergyHits = 0;
            }
        }
    }

    void loadEnergy()
    {
        SpriteRenderer[] b = energy.GetComponent<Battery>().batteries;
        int i = energy.GetComponent<Battery>().cont;
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            this.isCharging = true;
            //Se activa la animación solo cuando la energía es menor a 5
            if (i < 5)
            {
                anim.SetBool("isCharging", isCharging);
                audioSource.Stop();
                audioSource.PlayOneShot(audioSource.clip);
            }
            ++contEnergyHits;
            if (contEnergyHits == 8)
            {
                if (!b[1].isVisible)
                {
                    b[1].enabled = true;
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
            else if (contEnergyHits == 17)
            {
                if (!b[3].isVisible)
                {
                    b[3].enabled = true;
                    maxNumWave++;
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
            else if (contEnergyHits == 25)
            {
                if (!b[5].isVisible)
                {
                    b[5].enabled = true;
                    maxNumWave++;
                    contEnergyHits = 25;
                }
            }
            if (maxNumWave > 5)
            {
                maxNumWave = 5;
            }
            if (contEnergyHits >= 25 && i == 5)
            {
                this.isCharging = false;
                anim.SetBool("isCharging", isCharging);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            this.hp--;
            if(hp < 5 && hp > 0)
            {
                (Instantiate(glasses[hp-1], transform.position, transform.rotation) as GameObject).transform.parent = this.transform;
                audioSource.PlayOneShot(glassBreak[hp - 1]);
            }

            if (hp==0)
            {

                SceneManager.LoadScene("gameOver");
            }
            
        }
    }
}



//    if (Input.GetKey(KeyCode.RightControl))
//    {
//        this.isCharging = true;
//        //Se activa la animación solo cuando la energía es menor a 5
//        if (i< 5)
//        {
//            anim.SetTrigger("playerHit");
//        }
//        contEnergyHits++;
//        if (contEnergyHits == 25)
//        {
//            if (!b[5].isVisible)
//            {
//                b[5].enabled = true;
//                contEnergyHits = 0;
//                maxNumWave = 5;
//            }
//        }
//        else if (contEnergyHits == 21)
//        {
//            if (!b[4].isVisible)
//            {
//                b[4].enabled = true;
//                maxNumWave++;
//            }
//        }
//        else if (contEnergyHits == 17)
//        {
//            if (!b[3].isVisible)
//            {
//                b[3].enabled = true;
//                maxNumWave++;
//            }
//        }
//        else if (contEnergyHits == 13)
//        { 
//            if (!b[2].isVisible)
//            {
//                b[2].enabled = true;
//                maxNumWave++;
//            }
//        }
//        else if (contEnergyHits == 8)
//        {
//            if (!b[1].isVisible)
//            {
//                b[1].enabled = true;
//                maxNumWave++;
//            }
//        }
//    }
//    if(Input.GetKeyUp(KeyCode.RightControl))
//    {
//        this.isCharging = false;
//    }
//}
