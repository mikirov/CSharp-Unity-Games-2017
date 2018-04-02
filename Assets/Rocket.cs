using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    Rigidbody rigidbody;
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) {
            rigidbody.AddRelativeForce(Vector3.up);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            else {
                audioSource.Stop();
            }
        }
        if (Input.GetKey(KeyCode.W)) {
            print("Up key");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            print("down key");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.back);
        }
    }
}
