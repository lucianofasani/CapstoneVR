using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    public ChestTest unlock;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (unlock.puzzleSolved)
        {
            Destroy(gameObject);
        }
		
	}
}
