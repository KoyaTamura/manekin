﻿using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class liveSphereChromaKey : MonoBehaviour {

	public int camNum = 0;
	public int width = 1920;
	public int height = 1080;
	public int fps = 30;

	private WebCamTexture webcamTexture;

	// Use this for initialization
	void Start () {
		WebCamDevice[] devices = WebCamTexture.devices;
		if (devices.Length > camNum)
		{
			webcamTexture = new WebCamTexture(devices[camNum].name, width, height, fps);
			GetComponent<Renderer>().material.mainTexture = webcamTexture;
			webcamTexture.Play();
		}
		else
		{
			Debug.Log("no camera");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}