using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Rigidbody2D rb2d;
    public BoxCollider2D bc2d;
    public bool canMove = true;

	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (canMove)
        {
            transform.Translate(new Vector2(-1.0f * Time.deltaTime, 0));
        }
    }

    IEnumerator canMoveAgain()
    {
        yield return new WaitForSeconds(3);
        Color colorTemp = this.gameObject.GetComponent<Renderer>().material.color;
        colorTemp.a = 1.0f;
        this.GetComponent<Renderer>().material.color = colorTemp;
        canMove = true;
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Wave"))
    //    {
    //        Debug.Log("Me toco una wea");
    //        Destroy(other.gameObject, 0.1f);
    //        Color colorTemp = this.gameObject.GetComponent<Renderer>().material.color;
    //        colorTemp.a = 0.5f;
    //        this.gameObject.GetComponent<Renderer>().material.color = colorTemp;
    //        this.canMove = false;
    //        StartCoroutine("canMoveAgain");
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Wave"))
        {
            Destroy(other.gameObject, 0.1f);
            Color colorTemp = other.gameObject.GetComponent<Renderer>().material.color;
            colorTemp.a = 0.5f;
            this.gameObject.GetComponent<Renderer>().material.color = colorTemp;
            this.canMove = false;
            StartCoroutine("canMoveAgain");
        }
    }
}
