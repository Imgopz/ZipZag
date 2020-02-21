﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	[SerializeField]
	private float speed;
	bool started;
	bool gameOver;

	Rigidbody rb;  // alias Rigid body function to rb

	void Awake(){
		rb = GetComponent<Rigidbody> (); // Get Rigid body component
		// from ball object
	}
    // Start is called before the first frame update
    void Start()
    {
    	started = false;
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(!started) {
    		if(Input.GetMouseButtonDown (0)) {
    			rb.velocity = new Vector3 (speed, 0, 0);
    			started = true;
    		}
    	}

    	if(!Physics.Raycast (transform.position, Vector3.down, 1f)){
    		gameOver = true;
    		rb.velocity = new Vector3 (0, -25f, 0);

    		Camera.main.GetComponent<CameraFollow> ().gameOver = true;
    	}

        if (Input.GetMouseButtonDown (0) && !gameOver ) {
        	SwitchDirection ();
        }
    }

    void SwitchDirection(){
    	if(rb.velocity.z > 0 ) {
    		rb.velocity = new Vector3 (speed, 0, 0);
    	} else if (rb.velocity.x >0 ) {
    		rb.velocity = new Vector3 (0, 0, speed);
    	}
    }
}
