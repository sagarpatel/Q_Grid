using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour 
{

	public GameObject target;
	public float speed = 1f;
	public Vector3 velocity;
	Vector3 position;

	// Use this for initialization
	void Start () 
	{
		target = GameObject.Find("Target");
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 direction = target.transform.position - transform.position;
		direction.z = 0; // force 2d movement
		velocity += direction * speed;
		position += velocity * Time.deltaTime;
		transform.position = position;
	
	}



}
