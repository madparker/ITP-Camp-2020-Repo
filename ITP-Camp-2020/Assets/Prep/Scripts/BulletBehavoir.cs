using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavoir : MonoBehaviour {

	public float speed = 10;    //public var for bullet speed
	public float lifeSpan = 2;  //public var for how long to wait before destroying a bullet

	float timer = 0; //timer for tracking lifeSpan of the bullet

    Rigidbody2D rb2D; //reference to the rigidBody2D for this GameObject

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D>(); //get the Rigidbody2D attached to this GameObject

        rb2D.velocity = Vector3.up * speed; //set the velocity
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime; //increase time by deltaTime

		if(timer > lifeSpan){ //if enough time has passed
			Destroy(gameObject); //Destroy this bullet
		}
	}
}
