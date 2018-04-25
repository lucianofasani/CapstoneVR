using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberMask : MonoBehaviour {

    private MeshRenderer visible;
    private bool correctLights;

    public List<bool> requiredLights;
    public List<GameObject> lights;

	// Use this for initialization
	void Start () {
        visible = gameObject.GetComponent<MeshRenderer>();
        visible.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
		
        for(int i = 0; i < requiredLights.Count; i++)
        {
            if(requiredLights[i] != lights[i].activeSelf)
            {
                correctLights = true;
                break;
            }
            correctLights = false;
        }

        visible.enabled = correctLights;

	}
}
