using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class mirrorLive : MonoBehaviour
{

	public int camNum = 1;
	public int width = 1920;
	public int height = 1080;
	public int fps = 30;

	private WebCamTexture webcamTexture;

<<<<<<< HEAD
    // Use this for initialization
    void Start()
    {
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
    void Update()
    {
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
            mirrorPos.y = mirrorPos.y - 0.02f;
            gameObject.transform.position = mirrorPos;

        }
        else if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(new Vector3(0f, 0f, 1f));
=======
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
>>>>>>> c212098c25cd5468d05e6a61e1a585ed94e7b149

        }
        else if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(new Vector3(0f, 0f, -1f));
        }
        else if (Input.GetKey(KeyCode.U))
        {
            transform.Rotate(new Vector3(1f, 0f, 0f));

<<<<<<< HEAD
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(-1f, 0f, 0f));
        }
    }
=======
		}else if (Input.GetKey(KeyCode.L))
		{
			transform.Rotate (new Vector3 (0f, 0f, -1f));
		}else if (Input.GetKey(KeyCode.U))
		{
			transform.Rotate (new Vector3 (1f, 0f, 0f));

		}else if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate (new Vector3 (-1f, 0f, 0f));
		}
	}
>>>>>>> c212098c25cd5468d05e6a61e1a585ed94e7b149
}