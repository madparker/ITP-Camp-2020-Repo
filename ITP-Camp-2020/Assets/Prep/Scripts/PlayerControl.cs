using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    public GameObject bulletPrefab; //prefab (template) for a bullet GameObject

	Rigidbody2D rigidBody2D; //reference to the rigidBody2D for this GameObject

    // Use this for initialization
    void Start () {
		rigidBody2D = GetComponent<Rigidbody2D>(); //get the Rigidbody2D attached to this GameObject
    }
	
	// Update is called once per frame
	void Update () {

        rigidBody2D.velocity = Vector2.zero; //set the rigidBody2D velocity to zero

        if (Input.GetKey(KeyCode.A)) //if player presses A
        {
            rigidBody2D.velocity = new Vector2(-10, 0); //velocity left
        }
            
        if (Input.GetKey(KeyCode.D)) //if player presses D
        {
            rigidBody2D.velocity = new Vector2(10, 0);  //velocity right
        }

        if(Input.GetKeyDown(KeyCode.Space)){ //if player presses Space
            //create a new bullet from the bullet Prefab
            GameObject bullet = Instantiate<GameObject>(bulletPrefab); 

            //set the position of the bullet to just above the player
			bullet.transform.position = new Vector3(
					transform.position.x,
					transform.position.y + 0.75f,
					transform.position.z);
		}
	}
}
