using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCont : MonoBehaviour {
    public GameObject collider2;
    private CollisionContRD2 collider2_script;
    private bool collider2Solved;
    public bool riddle1Solved = false;

    private GameObject primaryBoard;
    private GameObject riddleBoard1;
    private GameObject statusButton;
    private GameObject keyBoard;

    public Material[] material;

	Renderer rend;
    Renderer rendStatus;
    Renderer rendPrimary;
    Renderer rendKey;

    void OnCollisionEnter(Collision col)
	{
        Debug.Log("Collision found");
        if (col.gameObject.tag == "knife") {
			rendStatus.sharedMaterial = material[2];
            riddle1Solved = true;
            if (riddle1Solved == true && collider2Solved == true)
            {
                rendPrimary.sharedMaterial = material[4];
                rendKey.sharedMaterial = material[1];
            }
        } else {
			rendStatus.sharedMaterial = material [3];
		}
	}
	// Use this for initialization
	void Start () {
        collider2_script = collider2.GetComponent<CollisionContRD2>();
        collider2Solved = collider2_script.riddle2Solved;

        keyBoard = GameObject.FindGameObjectWithTag("keyBoard");
        rendKey = keyBoard.GetComponent<Renderer>();
        rendKey.enabled = true;

        primaryBoard = GameObject.FindGameObjectWithTag("primaryB");
        rendPrimary = primaryBoard.GetComponent<Renderer>();
        rendPrimary.enabled = true;

        riddleBoard1 = GameObject.FindGameObjectWithTag ("riddleBoard1");
        statusButton = GameObject.FindGameObjectWithTag("SB1");
        rend = riddleBoard1.GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];

        rendStatus = statusButton.GetComponent<Renderer>();
        rendStatus.enabled = true;
        rendStatus.sharedMaterial = material[3];
    }
	
	// Update is called once per frame
	void Update () {
        collider2Solved = collider2_script.riddle2Solved;
    }

    void OnCollisionExit(Collision col)
    {
        Debug.Log("radio exit");
        rendStatus.sharedMaterial = material[3];
        riddle1Solved = false;

    }
}
