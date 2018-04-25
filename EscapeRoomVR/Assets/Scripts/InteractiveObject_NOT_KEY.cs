using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject_NOT_KEY : MonoBehaviour {

    Vector3 originalPos;

    // Use this for initialization
    void Start()
    {
        originalPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Receiver")
        {
            gameObject.transform.position = originalPos;
        }
    }
}
