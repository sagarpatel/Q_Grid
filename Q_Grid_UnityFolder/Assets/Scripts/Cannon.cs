using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cannon : MonoBehaviour 
{

	public float rotateRate = 1.0f;
	public Bullet bulletPrefab;
	public Vector3 spawnOffset;
	Vector3 spawnPosition;

	public Vector3 bulletVector;
	public float bulletRotation;

	public Vector3 testVector;

	// Use this for initialization
	void Start () 
	{
		spawnPosition = transform.position + spawnOffset;
		// transform.right, need to clean it up
		int x = (int)transform.right.x;
		int y = (int)transform.right.y;
		int z = (int)transform.right.z;

		bulletVector = new Vector3( (float)x, (float)y, (float)z );

	}
	
	// Update is called once per frame
	void Update () 
	{
		//rotate along the lenght / x axis
		transform.Rotate( rotateRate, 0 , 0 );

		testVector = transform.right;
	}


	void OnTriggerEnter(Collider other)
	{

		if( other.gameObject.name == "TouchCursor" )
		{
			Debug.Log("Cannon FIIIIIIIRE");
			Bullet currentBullet = (Bullet)Instantiate(bulletPrefab, transform.position, transform.localRotation);

			currentBullet.transform.Rotate( 0, 0, bulletRotation );
			currentBullet.position = spawnPosition;
			currentBullet.velocity = bulletVector;

			currentBullet.renderer.material.color = renderer.material.color;
		}


	}



}
