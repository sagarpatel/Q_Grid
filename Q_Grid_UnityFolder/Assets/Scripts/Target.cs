using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Target : MonoBehaviour 
{
	public float rotateRate = 1.0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate( 0, 0 , rotateRate );
	}
}