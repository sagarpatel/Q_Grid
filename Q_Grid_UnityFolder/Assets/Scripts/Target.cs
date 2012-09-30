using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Target : MonoBehaviour 
{
	public float rotateRate = 1.0f;
	public int maxHP = 100;
	public int currentHP;

	public int score;

	// Use this for initialization
	void Start () 
	{
		currentHP = maxHP;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate( 0, 0 , rotateRate );

		if( currentHP < 0 )
		{
			Destroy(gameObject);
		}
	}


	void OnTriggerEnter(Collider other)
	{

		if( other.gameObject.tag == "Enemy" )
		{
			Debug.Log("Enemy hit target!");
			Destroy(other.gameObject);

			currentHP -= 5;
		}


	}

	public void EnemyKilled()
	{
		score += 10;
	}

}
