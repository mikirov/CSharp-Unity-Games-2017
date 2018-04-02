using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rocket : MonoBehaviour {
    [SerializeField] float rotationSpeed = 250f;
    [SerializeField] float mainThrust = 2f;
    Rigidbody rigidbody;
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();
        Thrust();
	}
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                break;
            case "Finish":
                SceneManager.LoadScene(1);
                break;
            default:
                SceneManager.LoadScene(0);
                break;
        }
    }
    private void Rotate() {
        rigidbody.freezeRotation = true;

        float rotationVectorMultiplier = rotationSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(Vector3.back * rotationVectorMultiplier);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationVectorMultiplier);
        }
        rigidbody.freezeRotation = false;
    }
    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space)) {
            rigidbody.AddRelativeForce(Vector3.up * mainThrust);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            else {
                audioSource.Stop();
            }
        }

    }
}
