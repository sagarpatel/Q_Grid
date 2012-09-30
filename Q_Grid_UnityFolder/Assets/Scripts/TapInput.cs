using UnityEngine;
using System.Collections;



public class TapInput : MonoBehaviour 
{
	public float zDepth;
	public Vector3 testPosition;
	public bool isGUI;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		foreach (Touch touch in Input.touches)
		{
			testPosition = Camera.main.ScreenToWorldPoint(touch.position);
			testPosition.z = zDepth;
			if( isGUI == false)
			{
				transform.position = testPosition;
			}

		}


	}

}
