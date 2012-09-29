using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RowsGenerator : MonoBehaviour 
{

	public GameObject rowObject;
	public List<GameObject> rowsList;
	public int rowsCount = 4;
	public int distanceBetweenRows = 10;


	// Use this for initialization
	void Start () 
	{

		rowsList = new List<GameObject>();
		for(int i = 0; i < rowsCount; i++)
		{
			
			rowsList.Add((GameObject)Instantiate(rowObject, transform.localPosition, transform.localRotation));
			
			// set as child of generator
			rowsList[i].transform.parent = transform;

			// set distance between, taking into account scale
			float tempSize = rowsList[i].transform.localScale.y;
			Vector3 tempPosition = rowsList[i].transform.localPosition;
			float newY = i * tempSize + i*distanceBetweenRows;
			tempPosition.y = newY;
			rowsList[i].transform.localPosition = tempPosition;

		}
	
	}


	
	// Update is called once per frame
	void Update () 
	{


	
	}




}
