using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CollumnsGenerator : MonoBehaviour 
{
	public GameObject collumnmObject;
	public List<GameObject> collumnsList;
	public int collumnsCount = 10;
	public float distanceBetweenCollumns = 10;

	// Use this for initialization
	void Start () 
	{

		collumnsList = new List<GameObject>();
		for(int i = 0; i < collumnsCount; i++)
		{
			
			collumnsList.Add((GameObject)Instantiate(collumnmObject, transform.localPosition, transform.localRotation));
			
			// set as child of generator
			collumnsList[i].transform.parent = transform;

			// set distance between, taking into account scale
			float tempSize = collumnsList[i].transform.localScale.x;
			Vector3 tempPosition = collumnsList[i].transform.localPosition;
			float newX = i * tempSize + i*distanceBetweenCollumns;
			tempPosition.x = newX;
			collumnsList[i].transform.localPosition = tempPosition;

		}
	
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}


}
