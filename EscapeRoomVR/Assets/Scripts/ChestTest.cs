using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTest : MonoBehaviour {

    public bool puzzleSolved = false;

    public LootCrate _lootCrate;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("CHEST TRIGGER entered");

        if(collider.tag == "Key")
        {
            puzzleSolved = true;
            _lootCrate.Open();
        }

        //pickup = collider.gameObject;
    }

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("CHEST TRIGGER exit");
        //pickup = null;
    }

}
