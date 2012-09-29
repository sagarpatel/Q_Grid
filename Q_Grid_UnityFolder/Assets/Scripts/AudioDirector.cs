using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioDirector : MonoBehaviour 
{

	public float[] sampleArrayFreq = new float[64];
	public float[] colorArray =  new float[4];
	public float rgbAverage;

	public float rScale = 20.0f;
	public float gScale = 20.0f;
	public float bScale = 20.0f;
	public float aScale = 20.0f;

	public AudioSource audioSource;

	// Use this for initialization
	void Start () 
	{
		
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () 
	{

		AudioListener.GetSpectrumData(sampleArrayFreq, 0, FFTWindow.Rectangular);


		float sum = 0;
		for(int c = 0; c<4; c++)
		{
			for(int i= c * 16; i < c*16 + 16; i++)
			{
				sum += sampleArrayFreq[i];
			}
			colorArray[c] = sum/16 ;

			sum = 0;
		}

		colorArray[0] *= rScale;
		colorArray[1] *= gScale;
		colorArray[2] *= bScale;
		colorArray[3] *= aScale;

		rgbAverage = (colorArray[0] + colorArray[1] + colorArray[2])/3.0f;


	}



}
