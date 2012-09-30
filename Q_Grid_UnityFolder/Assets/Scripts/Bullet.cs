using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour 
{
	
	public Vector3 position;
	public Vector3 velocity;
	public float speed = 1f;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		position += velocity * Time.deltaTime * speed;	
		transform.position = position;
	}
	
	
}
