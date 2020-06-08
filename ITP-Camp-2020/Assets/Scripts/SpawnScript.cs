using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject enemyPrefab; //var for a reference to the enemy prefab
    public float spawnTime = 2;     //public var for amount of time to make a new enemy

    // Start is called before the first frame update
    void Start()
    {
        MakeEnemy(); //call MakeEnemy

        //Use InvokeRepeating to call MakeEnemy after spawnTime seconds and repeat every spawnTime seconds
        InvokeRepeating("MakeEnemy", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeEnemy(){
        //create a new enemy from the enemy prefab
        GameObject newEnemy = Instantiate<GameObject>(enemyPrefab);

        //move the new enemy above the top of the screen and to a random location on the X
        newEnemy.transform.position =
                    new Vector2(Random.Range(-7, 7),
                        8);
    }
}
