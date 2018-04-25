using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControlledNumber : MonoBehaviour {

    public GameObject light;
    private MeshRenderer visible;

	// Use this for initialization
	void Start () {
        visible = gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        visible.enabled = light.activeSelf;
	}
}
