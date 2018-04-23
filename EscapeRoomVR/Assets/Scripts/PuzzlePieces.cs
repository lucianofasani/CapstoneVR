using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieces : MonoBehaviour {

    public List<GameObject> collidedObjs;
    public HashSet<GameObject> actualCollisions = new HashSet<GameObject>();
    public bool piecesFixed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(collidedObjs.Count == actualCollisions.Count)
        {
            piecesFixed = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (collidedObjs.Contains(other.gameObject))
        {
            actualCollisions.Add(other.gameObject);
            Debug.Log("Entered with " + other.gameObject);
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (collidedObjs.Contains(other.gameObject))
        {
            actualCollisions.Remove(other.gameObject);
            Debug.Log("Exited with " + other.gameObject);
        }
    }
}
