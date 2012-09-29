using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DebugScript : MonoBehaviour 
{


	public GUIText debugTextBox;
	public Vector3 position;

	// Use this for initialization
	void Start () 
	{
		position = GetComponent<TapInput>().testPosition;
	}
	
	// Update is called once per frame
	void Update ()
	{
		position = GetComponent<TapInput>().testPosition;
		debugTextBox.text =  position.ToString();
	}



}
