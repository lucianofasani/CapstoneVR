using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSolved : MonoBehaviour {
    private bool done;
    private List<string> pieces = new List<string>{"Piece1", "Piece2", "Piece3", "Piece4", "Piece5", "Piece6",
    "Piece7","Piece8","Piece9","Piece10"};

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < pieces.Count; i++)
        {
            if (!GameObject.Find(pieces[i]).GetComponent<PuzzlePieces>().piecesFixed)
            {
                done = false;
                break;
            }
            done = true;
        }
        if (done)
        {
            Debug.Log("Puzzle Complete");
        }

    }

}
