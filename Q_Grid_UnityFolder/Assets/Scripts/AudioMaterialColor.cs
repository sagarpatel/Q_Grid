using UnityEngine;
using System.Collections;

public class AudioMaterialColor : MonoBehaviour 
{

	AudioDirector audioDirector;

	// Use this for initialization
	void Start () 
	{

		audioDirector = (AudioDirector) GameObject.Find("AudioDirector").GetComponent("AudioDirector");

		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Color tempColor = new Color(audioDirector.colorArray[0], audioDirector.colorArray[1], audioDirector.colorArray[2], audioDirector.colorArray[3]);


		renderer.material.color = tempColor;


	}


}
