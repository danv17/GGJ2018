using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public BoxCollider2D bc2d;
    public Rigidbody2D rb2d;
    public Animator anim;
    public GameObject waveInstance;
    public GameObject wave;


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
            waveInstance = (GameObject) Instantiate(wave, transform.position, transform.rotation);
            waveInstance.transform.Translate(Vector2.right * Time.deltaTime, Space.World);

            this.transform.Rotate(new Vector3(0,0,3.0f));
            
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
