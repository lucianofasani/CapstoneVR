using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControlledNumber : MonoBehaviour {

    //public GameObject light;
    private MeshRenderer visible;

    public List<GameObject> lights; //Adding this so you can have a combination of lights to activate a number piece
    private bool allOn;

	// Use this for initialization
	void Start () {
        visible = gameObject.GetComponent<MeshRenderer>();
        allOn = false;
        visible.enabled = allOn;
	}
	
	// Update is called once per frame
	void Update () {

        foreach(GameObject light in lights)
        {
            if(!light.activeSelf)
            {
                allOn = false;
                break;
                //return;
            }
            allOn = true;
        }

        visible.enabled = allOn;

        //visible.enabled = light.activeSelf;

	}
}
