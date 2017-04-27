using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour {
	private GameObject carChasis, carChasis1, carChasis2, carChasis3;
	private GameObject lfWheel, lfWheel1, lfWheel2, lfWheel3;
	private GameObject lrWheel, lrWheel1, lrWheel2, lrWheel3;
	private GameObject rfWheel, rfWheel1, rfWheel2, rfWheel3;
	private GameObject rrWheel, rrWheel1, rrWheel2, rrWheel3;
	private float wheelSize;

	public Material[] materials;
	public Texture2D[] textures;
	public int chasisIndex = 1;
	public int wheelIndex = 1;

	// Use this for initialization
	void Start () {
		carChasis1 = GameObject.Find ("Chassis1");
		carChasis2 = GameObject.Find ("Chassis2");
		carChasis3 = GameObject.Find ("Chassis3");

		lfWheel1 = GameObject.Find ("LF_Wheel1");
		lfWheel2 = GameObject.Find ("LF_Wheel2");
		lfWheel3 = GameObject.Find ("LF_Wheel3");

		lrWheel1 = GameObject.Find ("LR_Wheel1");
		lrWheel2 = GameObject.Find ("LR_Wheel2");
		lrWheel3 = GameObject.Find ("LR_Wheel3");

		rfWheel1 = GameObject.Find ("RF_Wheel1");
		rfWheel2 = GameObject.Find ("RF_Wheel2");
		rfWheel3 = GameObject.Find ("RF_Wheel3");

		rrWheel1 = GameObject.Find ("RR_Wheel1");
		rrWheel2 = GameObject.Find ("RR_Wheel2");
		rrWheel3 = GameObject.Find ("RR_Wheel3");

		carChasis = carChasis1;
		lfWheel = lfWheel1;
		lrWheel = lrWheel1;
		rfWheel = rfWheel1;
		rrWheel = rrWheel1;

		carChasis.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
		lfWheel.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
		lrWheel.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
		rfWheel.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
		rrWheel.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);

		textures = new Texture2D[5];
		textures[0] = new Texture2D(200, 200, TextureFormat.ARGB32, false);
		textures [0].SetPixel (1, 1, Color.black);
		textures [0].Apply ();

		textures[1] = new Texture2D(2, 2, TextureFormat.ARGB32, false);
		textures [1].SetPixel (1, 1, Color.blue);
		textures [1].Apply ();

		textures[2] = new Texture2D(2, 2, TextureFormat.ARGB32, false);
		textures [2].SetPixel (1, 1, Color.green);
		textures [2].Apply ();

		textures[3] = new Texture2D(2, 2, TextureFormat.ARGB32, false);
		textures [3].SetPixel (1, 1, Color.red);
		textures [3].Apply ();

		textures[4] = new Texture2D(2, 2, TextureFormat.ARGB32, false);
		textures [4].SetPixel (1, 1, Color.yellow);
		textures [4].Apply ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		//GUI.Box (new Rect (10, 10, 150, 120), "Change Color");
		GUIStyle customButton = new GUIStyle("button");
		customButton.fontSize = 40;

		if(GUI.Button(new Rect(20, 260, 410, 100), "Change Chasis", customButton)) {
			Debug.Log("Button Pressed");
			carChasis.GetComponent<Transform> ().localScale = new Vector3 (0, 0, 0);
			if (carChasis == carChasis1) {
				carChasis = carChasis2;
			} else if (carChasis == carChasis2) {
				carChasis = carChasis3;
			} else {
				carChasis = carChasis1;
			}
			carChasis.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
		}

		if(GUI.Button(new Rect(20, 370, 410, 100), "Change Wheel", customButton)) {
			Debug.Log("Button Pressed");
			lfWheel.GetComponent<Transform> ().localScale = new Vector3 (0, 0, 0);
			lrWheel.GetComponent<Transform> ().localScale = new Vector3 (0, 0, 0);
			rfWheel.GetComponent<Transform> ().localScale = new Vector3 (0, 0, 0);
			rrWheel.GetComponent<Transform> ().localScale = new Vector3 (0, 0, 0);

			if (lfWheel == lfWheel1) {
				lfWheel = lfWheel2;
				lrWheel = lrWheel2;
				rfWheel = rfWheel2;
				rrWheel = rrWheel2;
				wheelSize = 1;
			} else if (lfWheel == lfWheel2) {
				lfWheel = lfWheel3;
				lrWheel = lrWheel3;
				rfWheel = rfWheel3;
				rrWheel = rrWheel3;
				wheelSize = 1.9f;
			} else {
				lfWheel = lfWheel1;
				lrWheel = lrWheel1;
				rfWheel = rfWheel1;
				rrWheel = rrWheel1;
				wheelSize = 1;
			}
			lfWheel.GetComponent<Transform> ().localScale = new Vector3 (wheelSize, 1, 1);
			lrWheel.GetComponent<Transform> ().localScale = new Vector3 (wheelSize, 1, 1);
			rfWheel.GetComponent<Transform> ().localScale = new Vector3 (wheelSize, 1, 1);
			rrWheel.GetComponent<Transform> ().localScale = new Vector3 (wheelSize, 1, 1);
		}
	}
}
