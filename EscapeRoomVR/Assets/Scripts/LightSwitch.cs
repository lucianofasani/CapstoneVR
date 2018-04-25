using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

    private GameObject collidingObject;
    public GameObject light;
    public GameObject physicalSwitch;
    public bool on;

    private Vector3 rotation;

    // Use this for initialization
    void Start () {
        rotation.x = 0;
        rotation.y = 180;
        rotation.z = 0;
        if (on)
        {
            physicalSwitch.transform.Rotate(rotation);
            light.SetActive(true);
        }
        else
        {
            light.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {


        if(col.gameObject.tag == "Player")
        {
            light.SetActive(!light.activeSelf);
            physicalSwitch.transform.Rotate(rotation);
            on = !on;
        }
    }
}
