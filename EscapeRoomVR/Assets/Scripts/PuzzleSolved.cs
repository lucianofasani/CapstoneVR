using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSolved : MonoBehaviour {
    private bool done;
    private List<string> pieces = new List<string>{"Piece1", "Piece2", "Piece3", "Piece4", "Piece5", "Piece6",
    "Piece7","Piece8","Piece9","Piece10"};
    public GameObject activate;
    public Light lt;

    // Use this for initialization
    void Start () {
        activate.SetActive(false);
        //lt = GetComponent<Light>();
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
            /*if(i >= 8)//this is plan B! Make sure at least 8 of the pieces are touching properly
            {
                done = true;
            }*/
            done = true;
        }
        if (done)
        {
            //Debug.Log("Puzzle Complete");
            lt.color = Color.green;
            for(int i = 0; i < pieces.Count; i++)
            {
                Destroy(GameObject.Find(pieces[i]));
            }
            activate.SetActive(true);
        }

    }

}
