using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DebugScript : MonoBehaviour 
{


	public GUIText debugTextBox;
	public Vector3 position;

	public bool isHP;
	public bool isScore;

	// Use this for initialization
	void Start () 
	{
		//position = GetComponent<TapInput>().testPosition;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//position = GetComponent<TapInput>().testPosition;

		Target target = (Target)GameObject.Find("Target").GetComponent("Target");
		
		if(isHP)
		{

			debugTextBox.text =  "HP: " + target.currentHP.ToString();
		}

		else if( isScore )
		{
			debugTextBox.text =  "Score: " + target.score.ToString();
		}

	}



}
