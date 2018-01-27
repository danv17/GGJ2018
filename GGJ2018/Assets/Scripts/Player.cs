using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public BoxCollider2D bc2d;
    public Rigidbody2D rb2d;
    public Animator anim;
    public GameObject waveInstance;
    public GameObject wavePrefab;
    public bool isFacingUp;
    public bool isFacingRight;

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

        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.SetTrigger("playerChop");
            Instantiate(wavePrefab, transform.position, transform.rotation);

            /*waveInstance.GetComponent<Rigidbody2D>().velocity = waveInstance.transform.forward * 10.0f;
            waveInstance.transform.TransformDirection(Vector3.forward*5.0f);
            Debug.Log(waveInstance.transform.position.x);
            waveInstance.transform.Translate(new Vector2(5.0f, 0));
            Debug.Log(waveInstance.transform.position.x);
            Destroy(waveInstance, 8.0f);*/
        }
        if (x > 0.5f)
        {
            isFacingRight = true;
            anim.SetBool("isRight", true);

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
}
