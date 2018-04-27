using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour {

    public bool puzzleSolved = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("KEY HOLE TRIGGER entered");

        if (collider.tag == "FinalKey")
        {
            puzzleSolved = true;
            //GAME EXIT HERE EITHER TO FINAL CONGRATULATIONS SCREEN OR JUST OUT
            Destroy(collider.gameObject);
        }

    }
}
