using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tune : MonoBehaviour
{

    public GameObject index;
    public GameObject needle;
    public GameObject visor;
    public Renderer boundVisor;
    public bool isMoving;

    // Use this for initialization
    void Start()
    {
        index = GameObject.FindGameObjectWithTag("Index");
        needle = GameObject.FindGameObjectWithTag("Needle");
        visor = GameObject.FindGameObjectWithTag("Visor");
        boundVisor = visor.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(index.transform.rotation.z);

        //Min bound
        if (Input.GetKey(KeyCode.Z))
        {
            if (needle.transform.position.x > boundVisor.bounds.min.x + 0.3)
            {
                needle.transform.Translate(new Vector3(-1.0f * Time.deltaTime, 0, 0));
                index.transform.Rotate(new Vector3(0, 0, 1.0f));
            }
            else if (needle.transform.position.x == boundVisor.bounds.min.x + 0.3)
            {
                needle.transform.Translate(new Vector3(1.0f * Time.deltaTime, 0, 0));
                index.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }

        //Max bound
        if (Input.GetKey(KeyCode.X))
        {
            if (needle.transform.position.x < boundVisor.bounds.max.x - 0.29)
            {
                needle.transform.Translate(new Vector3(1.0f * Time.deltaTime, 0, 0));
                index.transform.Rotate(new Vector3(0, 0, -1.0f));
            }
            else if (needle.transform.position.x == boundVisor.bounds.max.x - 0.29)
            {
                needle.transform.Translate(new Vector3(-1.0f * Time.deltaTime, 0, 0));
                index.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }
    }
}