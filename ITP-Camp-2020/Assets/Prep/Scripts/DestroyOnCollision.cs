using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

//func alt enter for disabling stuff

public class DestroyOnCollision : MonoBehaviour
{
    GameObject player; //ref to the player GameObject

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player"); //get the player GameObject
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other) //if we collide with another gameObjecy with a collider
    {
        Destroy(other.gameObject); //destroy the other GameObject
        Destroy(gameObject);       //destroy this GameObject
    }
}