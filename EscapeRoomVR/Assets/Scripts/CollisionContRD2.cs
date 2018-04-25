using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionContRD2 : MonoBehaviour {
    public GameObject collider1;
    private CollisionCont collider1_script;
    private bool collider1Solved;
    public bool riddle2Solved = false;

	private GameObject riddleBoard2;
    private GameObject primaryBoard;
    private GameObject statusButton1;
    private GameObject keyBoard;

    public Material[] material;

	Renderer rend;
	Renderer rendStatus;
    Renderer rendPrimary;
    Renderer rendKey;



    void OnCollisionEnter(Collision col)
	{
        Debug.Log("Collision found");
		if (col.gameObject.tag == "radio")
        {
            Debug.Log("is a radio");
            rendStatus.sharedMaterial = material[2];
            riddle2Solved = true;
            if(riddle2Solved==true && collider1Solved==true)
            {
                rendPrimary.sharedMaterial= material[4];
                rendKey.sharedMaterial = material[1];
            }

		} else {
            Debug.Log("is not a radio");
            rendStatus.sharedMaterial = material [3];
            riddle2Solved = false;
		}
	}
	// Use this for initialization
	void Start () {
        collider1_script = collider1.GetComponent<CollisionCont>();
        collider1Solved = collider1_script.riddle1Solved;

        primaryBoard = GameObject.FindGameObjectWithTag("primaryB");
        rendPrimary = primaryBoard.GetComponent<Renderer>();
        rendPrimary.enabled = true;

        keyBoard = GameObject.FindGameObjectWithTag("keyBoard");
        rendKey = keyBoard.GetComponent<Renderer>();
        rendKey.enabled = true;

        riddleBoard2 = GameObject.FindGameObjectWithTag ("riddleBoard2");
		statusButton1 = GameObject.FindGameObjectWithTag("S2");

		rend = riddleBoard2.GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];

		rendStatus = statusButton1.GetComponent<Renderer>();
		rendStatus.enabled = true;
		rendStatus.sharedMaterial = material[2];
	}
    void OnCollisionExit(Collision col)
    {
            Debug.Log( "radio exit");
            rendStatus.sharedMaterial = material[3];
            riddle2Solved = false;

    }

    void onCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "radio")
        {
            rendStatus.sharedMaterial = material[2];
        }
        else
        {
            rendStatus.sharedMaterial = material[3];
        }
    }

    // Update is called once per frame
    void Update () {
        collider1Solved = collider1_script.riddle1Solved;

    }
}
