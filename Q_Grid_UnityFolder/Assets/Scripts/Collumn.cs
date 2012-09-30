using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collumn : MonoBehaviour 
{
	public GameObject cannonPrefab;
	public float positionDivider = 3f;

	GameObject cannonTop;
	GameObject cannonBot;


	// Use this for initialization
	void Start () 
	{
		cannonTop =  (GameObject)Instantiate( cannonPrefab, transform.position, transform.localRotation );
		cannonBot =  (GameObject)Instantiate( cannonPrefab, transform.position, transform.localRotation );


		Vector3 tempPositionTop = transform.position;
		tempPositionTop.y += transform.localScale.y /positionDivider;
		cannonTop.transform.position = tempPositionTop;
		cannonTop.transform.Rotate( 0, 0, -90 );

		Vector3 tempPositionBot = transform.position;
		tempPositionBot.y -= transform.localScale.y /positionDivider;
		cannonBot.transform.position = tempPositionBot;
		cannonBot.transform.Rotate( 0, 0, 90 );

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


}
