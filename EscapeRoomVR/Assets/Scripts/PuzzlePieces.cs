using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieces : MonoBehaviour {

    public List<GameObject> collidedObjs;
    public int numObjsCollided = 0;
    public bool piecesFixed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (collidedObjs.Contains(other.gameObject))
        {
            numObjsCollided++;
            if (numObjsCollided == collidedObjs.Count)
                piecesFixed = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (!collidedObjs.Contains(other.gameObject))
        {
            numObjsCollided--;
            //piecesFixed = false;
        }
    }
}
