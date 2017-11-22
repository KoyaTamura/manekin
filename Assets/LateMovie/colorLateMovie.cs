using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class colorLateMovie : MonoBehaviour {

	public int camNum = 0;
	public int width = 1920;
	public int height = 1080;
	public int fps = 30;

	private WebCamTexture webcamTexture;


	private Color32[] c;
	private Color32[] LateColorNum;

	private Texture2D texture;

	public int lateSec = 10;

	// Use this for initialization
	void Start () {

		WebCamDevice[] devices = WebCamTexture.devices;

		if (devices.Length > camNum)
		{
			webcamTexture = new WebCamTexture(devices[camNum].name, width, height, fps);
			webcamTexture.Play();
		}
		else
		{
			Debug.Log("no camera");
		}

		LateColorNum = new Color32[(fps * (lateSec + 1))];
		c = new Color32[webcamTexture.width * webcamTexture.height];

		texture = new Texture2D(webcamTexture.width, webcamTexture.height);
		GetComponent<Renderer> ().material.mainTexture = texture;

	}

	// Update is called once per frame
	void Update () {
		//配列に入れる行為
		c = webcamTexture.GetPixels32();
		//LateColorNum [Time.frameCount % (fps * (lateSec + 1))] = c[];

		//		myTex.SetPixels(c,Time.frameCount % (fps * (lateSec + 1)));
		//		myTex.Apply();
		//		//配列からtextureを引き抜く行為
		//		GetCol.SetPixels (myTex.GetPixels (Time.frameCount % (fps * (lateSec + 1))));
		//		GetCol.Apply ();
		//		GetComponent<Renderer> ().material.mainTexture = GetCol;
		//		//StartCoroutine ("LateTimeMovie",Time.frameCount % (fps * (lateSec + 1)));


	}
		
}
