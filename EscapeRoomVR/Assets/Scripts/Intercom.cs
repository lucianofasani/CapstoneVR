using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intercom : MonoBehaviour {

	public AudioSource speaker1;
	public AudioSource speaker2;
	public AudioSource speaker3;
	public AudioSource speaker4;

	//AudioSource[] speakers = new AudioSource[]{speaker1, speaker2, speaker3, speaker4};


	public AudioClip currentClip;
	// Use this for initialization
	void Start () {
		playClip (currentClip);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void playClip(AudioClip clip){
		speaker1.clip = clip;
		speaker2.clip = clip;
		speaker3.clip = clip;
		speaker4.clip = clip;
		speaker1.Play ();
		speaker2.Play ();
		speaker3.Play ();
		speaker4.Play ();
	}
}
