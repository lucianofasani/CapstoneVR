﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGrabObject : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device Controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }

    private GameObject collidingObject; //Reference to object hand is on
    private GameObject objectInHand; //Reference to object actually being held onto
    public bool objectGrabbed = false;

    //private Rigidbody rbody;

    private void SetCollidingObject(Collider col)
    {
        if(collidingObject || !col.GetComponent<Rigidbody>()) //If the player is already holding an object or the object does not have a rigidbody, don't make it grabbable
        {
            return;
        }

        collidingObject = col.gameObject; //Confirms object is grabbable and stages it as such
    }

    public void OnTriggerEnter(Collider other) //Sets target on object controller touches
    {
        SetCollidingObject(other);
    }

    public void OnTriggerStay(Collider other) //Makes sure target is still set correctly even when controller is held on the object
    {
        SetCollidingObject(other);
    }

    public void OnTriggerExit(Collider other) //Abandoning ungrabbed target
    {
        if (!collidingObject)
        {
            return;
        }

        collidingObject = null;
    }

    private void GrabObject()
    {

        //Moves the GameObject inside of the player's hand and removes it from the collidingObject variable
        objectInHand = collidingObject;
        collidingObject = null;
        //var joint = ;

        if(objectInHand.tag == "Door")
        {
            var joint = AddSpringJoint(); //Adds joint that connects the controller to the object that is now being held
            joint.connectedBody = objectInHand.GetComponent<Rigidbody>();

        }
        else
        {
            var joint = AddFixedJoint(); //Adds joint that connects the controller to the object that is now being held
            joint.connectedBody = objectInHand.GetComponent<Rigidbody>();
        }

    }

    private FixedJoint AddFixedJoint()
    {
        FixedJoint fx = gameObject.AddComponent<FixedJoint>();
        fx.breakForce = 20000; //High values so joint doesn't easily break
        fx.breakTorque = 20000;
        return fx;
    }

    private SpringJoint AddSpringJoint()
    {
        SpringJoint fx = gameObject.AddComponent<SpringJoint>();
        fx.breakForce = 20000; //High values so joint doesn't easily break
        fx.breakTorque = 20000;
        fx.spring = 10;
        fx.damper = 0.2f;
        return fx;
    }

    private void ReleaseObject()
    {
        if (GetComponent<FixedJoint>()) //Checks for an attached fixed joint
        {
            GetComponent<FixedJoint>().connectedBody = null; //Destroy joint attachment
            Destroy(GetComponent<FixedJoint>());

            objectInHand.GetComponent<Rigidbody>().velocity = Controller.velocity; //Match throwing spin and speed
            objectInHand.GetComponent<Rigidbody>().angularVelocity = Controller.angularVelocity;
        }
        else if(GetComponent<SpringJoint>())
        {
            GetComponent<SpringJoint>().connectedBody = null; //Destroy joint attachment
            Destroy(GetComponent<SpringJoint>());

            //objectInHand.GetComponent<Rigidbody>().velocity = Controller.velocity; //Match throwing spin and speed
            //objectInHand.GetComponent<Rigidbody>().angularVelocity = Controller.angularVelocity;
        }

        objectInHand = null; //Remove the reference to the GameObject that was in the player's hand since it should no longer be there
    }

    private void AddForceToHinge()
    {
        objectInHand = collidingObject;
        collidingObject = null;

        var joint = AddSpringJoint(); //Adds joint that connects the controller to the object that is now being held
        joint.connectedBody = objectInHand.GetComponent<Rigidbody>();
    }

    void Start()
    {
        //rbody = null;
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Controller.GetHairTriggerDown()) //If there is an object that can be grabbed when the player presses the trigger, grab it
        {

           /* if(collidingObject.tag == "Door")
            {
                AddForceToHinge();
            }
            else if(collidingObject.tag != "Receiver" && collidingObject.tag != "Immovable")
            {
                GrabObject();
                objectGrabbed = true;
            }*/

            if (collidingObject.tag != "Receiver" && collidingObject.tag != "Immovable")
            {
                GrabObject();
                objectGrabbed = true;
            }
        }

        if (Controller.GetHairTriggerUp()) //If there is an object in hand when the trigger is released, release it
        {
            if (objectInHand)
            {
                ReleaseObject();
                objectGrabbed = false;
                //rbody = null;
            }
        }



	}
}
