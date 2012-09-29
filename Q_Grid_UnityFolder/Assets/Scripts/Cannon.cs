using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cannon : MonoBehaviour 
{

	public float rotateRate = 1.0f;

	// Use this for initialization
	void Start () 
	{
		

	}
	
	// Update is called once per frame
	void Update () 
	{
		//rotate along the lenght / x axis
		transform.Rotate( rotateRate, 0 , 0 );


	}



}
