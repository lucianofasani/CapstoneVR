using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactSound : MonoBehaviour {

	public AudioSource mySource;
	public AudioClip floorSound;
	public AudioClip pickUpSound;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Floor") {
			mySource.clip = floorSound;
		} else {
			mySource.clip = pickUpSound;
		}
		mySource.Play ();
	}
}
