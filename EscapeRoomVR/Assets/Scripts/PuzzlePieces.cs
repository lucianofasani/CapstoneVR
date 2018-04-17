using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieces : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;
    public GameObject piece4;
    public GameObject piece5;
    public GameObject piece6;
    public GameObject piece7;
    public GameObject piece8;
    public GameObject piece9;
    public GameObject piece10;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "piece2")
        {
            Destroy(col.gameObject);
        }
    }
}
