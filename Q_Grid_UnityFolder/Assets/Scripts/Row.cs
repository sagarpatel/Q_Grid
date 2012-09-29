using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Row : MonoBehaviour 
{

	public GameObject cannonPrefab;
	public float positionDivider = 3f;

	public GameObject cannonLeft;
	public GameObject cannonRight;

	// Use this for initialization
	void Start () 
	{

		cannonLeft =  (GameObject)Instantiate( cannonPrefab, transform.position, transform.localRotation );
		cannonRight =  (GameObject)Instantiate( cannonPrefab, transform.position, transform.localRotation );


		Vector3 tempPositionLeft = transform.position;
		tempPositionLeft.x += transform.localScale.x /positionDivider;
		cannonLeft.transform.position = tempPositionLeft;
		//cannonLeft.transform.Rotate( 0, 0, -90 );

		Vector3 tempPositionRight = transform.position;
		tempPositionRight.x -= transform.localScale.x /positionDivider;
		cannonRight.transform.position = tempPositionRight;
		cannonRight.transform.Rotate( 0, 0, 180 );
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


}
