using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{

    public BoxCollider2D bc2d;
    public Rigidbody2D rb2d;
    public float speed = 7.0f;

    // Use this for initialization
    void Start()
    {
        float x = 10f;

        this.bc2d = GetComponent<BoxCollider2D>();
        this.rb2d = GetComponent<Rigidbody2D>();
        this.rb2d.velocity = Vector2.right * speed; //new Vector2(x, y) * speed; //rb2d.velocity.x
        //this.transform.Translate(new Vector2(x, y) * speed);
        //this.rb2d.AddForce(new Vector2(x, y));
        //rb2d.velocity = new Vector2(5f,5f) * speed;
        Destroy(this.gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(5f,0) * Time.deltaTime;
    }

    //public void OnTriggerEnter2D(Collider2D other)
    //{

    //    if (other.tag == "Enemy")
    //    {
    //        Destroy(this.gameObject, 0.1f);
    //        Color colorTemp = other.gameObject.GetComponent<Renderer>().material.color;
    //        colorTemp.a = 0.5f;
    //        other.gameObject.GetComponent<Renderer>().material.color = colorTemp;
    //        other.gameObject.GetComponent<Enemy>().canMove = false;
    //    }
    //}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    print("ajskdjoaksodjkoa");
    //    if (collision.CompareTag("Enemy"))
    //    {
    //        Destroy(collision.gameObject);
    //        print("entreaentro");
    //    }
    //}
}

