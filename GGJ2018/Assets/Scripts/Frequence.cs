using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frequence : MonoBehaviour {
    public AudioClip[] freqs;

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        int r = Random.Range(0, 3);
        if (other.CompareTag("Freq")) {
            
            AudioSource source = GetComponent<AudioSource>();
            source.Stop();
            print(r);
            source.PlayOneShot(freqs[r]);
            source.volume = 0.5f;
        }
    }


}
