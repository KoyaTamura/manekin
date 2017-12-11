using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class mirrorLive : MonoBehaviour {

    public int camNum = 1;
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

        for (int i = 0; i < devices.Length; i++)
        {
            Debug.Log(devices[i].name);
        }
    }
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
        //key set mirror
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 mirrorPos = gameObject.transform.position;
            mirrorPos.x = mirrorPos.x + 0.01f;
            gameObject.transform.position = mirrorPos;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 mirrorPos = gameObject.transform.position;
            mirrorPos.x = mirrorPos.x - 0.01f;
            gameObject.transform.position = mirrorPos;

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 mirrorPos = gameObject.transform.position;
            mirrorPos.y = mirrorPos.y + 0.01f;
            gameObject.transform.position = mirrorPos;

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 mirrorPos = gameObject.transform.position;
            mirrorPos.y = mirrorPos.y - 0.01f;
            gameObject.transform.position = mirrorPos;

        } else if (Input.GetKey(KeyCode.A)){
            transform.Rotate(new Vector3(0,0,-1));
        } else if (Input.GetKey(KeyCode.S)) {
            transform.Rotate(new Vector3(0, 0, 1));
        } else if (Input.GetKey(KeyCode.W)) {
            transform.Rotate(new Vector3(-1, 0, 0));
        } else if (Input.GetKey(KeyCode.Z)) {
            transform.Rotate(new Vector3(1, 0, 0));
        }
    }
=======
		if (Input.GetKey(KeyCode.RightArrow))
		{
			Vector3 mirrorPos = gameObject.transform.position;
			mirrorPos.x = mirrorPos.x + 0.02f;
			gameObject.transform.position = mirrorPos;
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			Vector3 mirrorPos = gameObject.transform.position;
			mirrorPos.x = mirrorPos.x - 0.02f;
			gameObject.transform.position = mirrorPos;

		}
		else if (Input.GetKey(KeyCode.UpArrow))
		{
			Vector3 mirrorPos = gameObject.transform.position;
			mirrorPos.y = mirrorPos.y + 0.02f;
			gameObject.transform.position = mirrorPos;

		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			Vector3 mirrorPos = gameObject.transform.position;
			mirrorPos.y = mirrorPos.y- 0.02f;
			gameObject.transform.position = mirrorPos;

		}else if (Input.GetKey(KeyCode.R))
		{
			transform.Rotate (new Vector3 (0f, 0f, 1f));

		}else if (Input.GetKey(KeyCode.L))
		{
			transform.Rotate (new Vector3 (0f, 0f, -1f));
		}
	}
>>>>>>> db771e8a14e1a58ef7849cf946a4ebdd9b8bc69d
}
