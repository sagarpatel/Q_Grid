using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour 
{
	
	public Vector3 position;
	public Vector3 velocity;
	public float speed = 1f;
	public float currentLifeTime;
	public float maxLifeTime = 8f;

	GameObject target;
	
	// Use this for initialization
	void Start () 
	{
		target = GameObject.Find("Target");
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		position += velocity * Time.deltaTime * speed;	
		transform.position = position;


		currentLifeTime += Time.deltaTime;
		if(currentLifeTime > maxLifeTime)
		{
			Destroy(gameObject);
			//Debug.Log("Selftdestruct!");	
		}
	}

	void OnTriggerEnter(Collider other)
	{

		if( other.gameObject.tag == "Enemy" )
		{
			Debug.Log("Enemy hit target!");
			Destroy(other.gameObject);

			target.SendMessage("EnemyKilled");
		}


	}
	
	
}
