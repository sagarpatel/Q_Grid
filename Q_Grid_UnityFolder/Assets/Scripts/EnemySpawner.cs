using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour 
{

	public Enemy enemyPrefab;
	public Vector3 initialVelocity;
	public float spawnThreashold = 1f;

	public int rgbaIndex;

	AudioDirector audioDirector;

	// Use this for initialization
	void Start () 
	{
		audioDirector = (AudioDirector) GameObject.Find("AudioDirector").GetComponent("AudioDirector");
   
	}
	
	// Update is called once per frame
	void Update () 
	{


		float colorValue = audioDirector.colorArray[rgbaIndex];
		if(colorValue > spawnThreashold)
		{
			Enemy spawnedEnemy = (Enemy)Instantiate( enemyPrefab, transform.position, transform.rotation );
			spawnedEnemy.velocity = initialVelocity;
		}


	}


}
