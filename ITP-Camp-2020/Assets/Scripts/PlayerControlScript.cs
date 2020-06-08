using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }
     
    // Update is called once per frame
    void Update()
    {
        //print("Hello Again!");

        rb2D.velocity = new Vector2(0, 0);

        if(Input.GetKey(KeyCode.A)){ //if I press the A key
            print("You pressed A");
            rb2D.velocity = new Vector2(-5, 0); //Go Left
        }

        if(Input.GetKey(KeyCode.D)){ //if I press the D key
            rb2D.velocity = new Vector2(5, 0); //Go Right
        }
    }
}
