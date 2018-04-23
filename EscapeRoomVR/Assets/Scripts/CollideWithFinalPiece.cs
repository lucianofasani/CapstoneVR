using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithFinalPiece : MonoBehaviour {
    public List<GameObject> pieces;
    public int contacts = 0;
    // Use this for initialization
    void Start () {
		
	}
	//the object here was a bit hacky. It seems that most of the pieces won't fit perfectly
    //therefore making complete collision less than likely
    //we will instead make sure that at least 8 pieces are colliding properly
    //and that all pieces are touching the final number piece before declaring it solved

	// Update is called once per frame
	void Update () {
		
	}

    void onCollisionEnter(Collision other)
    {
        if (pieces.Contains(other.gameObject)){
            contacts++;
        }
    }

    void onCollisionExit(Collision other)
    {
        if (pieces.Contains(other.gameObject)){
            contacts--;
        }
    }
}
