using System.Collections;
using UnityEngine;
//using UnityEngine.Video;
using UnityEngine.UI;

public class LateMovie : MonoBehaviour {

	//webcam数値
	private WebCamTexture webcamTexture;
	public int camNum = 0;
	public int width = 1920;
	public int height = 1080;
	public int fps = 30;

	//代入する云々
	private Texture2D setTexture;
	private Texture2DArray textureArray;
	private bool webcamIsPlaying = true;

	//何秒遅らせるか
	public int lateSec = 3;


	// Use this for initialization
	void Start () {

		WebCamInit ();
		Application.targetFrameRate = fps; //60FPSに設定

	}
		

	// Update is called once per frame
	void Update () {


		//最初の一回で代入先のtextureを初期化
		if(webcamTexture.width > 16 && webcamTexture.height > 16 && webcamIsPlaying){
			SetTextureInit ();
			webcamIsPlaying = false;
		}

		//全て初期化されたらここに入る
		if(webcamIsPlaying == false){

			textureArray.SetPixels (webcamTexture.GetPixels() , Time.frameCount % (lateSec * fps));
			StartCoroutine ("LateTimeMovie",Time.frameCount % (fps * lateSec));

//			textureArray.SetPixels (webcamTexture.GetPixels() , Time.frameCount % (lateSec * fps));
//			setTexture.SetPixels (textureArray.GetPixels (Time.frameCount % (lateSec * fps)));
//			setTexture.Apply ();

		}

	}

	void WebCamInit(){

		//webcamをスタートさせる
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

		//デバイスの名前一覧表示
		for (int i = 0; i < devices.Length; i++)
		{
			Debug.Log(devices[i].name);
		}
	}

	void SetTextureInit(){

		//テクスチャー配列、カラー、表示テクスチャーの初期化
		textureArray = new Texture2DArray(webcamTexture.width, webcamTexture.height,lateSec * fps, TextureFormat.RGB565,false);
		//textureArray = null;
		setTexture = new Texture2D(webcamTexture.width , webcamTexture.height,TextureFormat.RGB565,false);
		GetComponent<Renderer> ().material.mainTexture = setTexture;
	}

	IEnumerator LateTimeMovie(int i){
		yield return  new WaitForSeconds (1);
		setTexture.SetPixels (textureArray.GetPixels (i));
		setTexture.Apply ();
	}
		
}
