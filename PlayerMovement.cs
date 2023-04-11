using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed; //part1
    public GameObject deathParticles;
    private float maxSpeed = 5f;//part1
    private Vector3 input; //xyz coordinate -> one variable to hold three values//part1
    private Vector3 spawn;

	// Use this for initialization
	void Start () {
        spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));//x-horizontal    								             //y-no jump; z- vertical
  									     //part1

        if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)         //part1
        {
            GetComponent<Rigidbody>().AddForce(input * moveSpeed);
        }

        if (transform.position.y < -2)
        {
            Die();
        }
		
	}

    private void OnCollisionEnter(Collision other) //part3
    {
        if(other.transform.tag == "Enemy")
        {
            //print("I hit enemy");
            Die();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Goal")
        {
            GameManager.CompleteLevel();
        }
    }

    void Die()
    {
        Instantiate(deathParticles, transform.position, Quaternion.Euler(270,0,0));
            transform.position = spawn;
    }
}
