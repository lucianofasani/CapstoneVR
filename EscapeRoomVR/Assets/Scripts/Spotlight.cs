using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight : MonoBehaviour {

    public LightSwitch lightSwitch;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(lightSwitch.on)
        {
            gameObject.SetActive(false);
        }
	}
}
