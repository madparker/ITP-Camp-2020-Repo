using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Called when 2 GameObjects w/ 2D collision collide
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("I GOT HIT!");            //print
        Destroy(gameObject);            //destroy this gameObject
        Destroy(collision.gameObject);  //destroy the other gameObject we hit
    }
}
