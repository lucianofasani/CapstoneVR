using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadKeys : MonoBehaviour {

    private KeypadControl keypad;
    public string value;

	// Use this for initialization
	void Start () {
        keypad = GetComponentInParent<KeypadControl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Press ()
    {
        keypad.SendMessage("updateEntry", value);
    }
}
