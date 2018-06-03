using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityCap : MonoBehaviour {
    public float TopSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //check velocity
        //print(GetComponent<Rigidbody>().velocity);
        // Clamp the Max Velocity of the Object (To limit dynamic objects phasing through static objects OR Excessive Velocity Multiplication)
        GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, TopSpeed);
    }
}
