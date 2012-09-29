using UnityEngine;
using System.Collections;



public class TapInput : MonoBehaviour 
{

	public Vector3 testPosition;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		 foreach (Touch touch in Input.touches)
		{
			testPosition = touch.position;
			transform.position = testPosition;
		}



	}

}
