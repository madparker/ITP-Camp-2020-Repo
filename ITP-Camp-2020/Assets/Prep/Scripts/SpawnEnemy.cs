using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public float spawnTime = 2; //how often to spawn enemies
    public float startY = 8;    //y of start position for new enemy

    public GameObject enemyPrefab; //prefab (template) of an enemy GameObject

	// Use this for initialization
	void Start () {
        //calls "MakeEnemy" function after spawnTime seconds and then again every spawnTime seconds
		InvokeRepeating("MakeEnemy", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MakeEnemy(){
        GameObject newEnemy = Instantiate<GameObject>(enemyPrefab); //create a new enemy GameObject from prefab

		newEnemy.transform.position = new Vector2( //set the position of the new enemy
			Random.Range(-7, 7), //to a random x between -7 and 7
			startY); //and a y of startY
	}
}
