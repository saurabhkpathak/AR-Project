using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour {
	private GameObject carChasis, carChasis1, carChasis2, carChasis3;
	public Material[] materials;
	public Texture2D[] textures;
	public int chasisIndex = 1;
	public int wheelIndex = 1;

	// Use this for initialization
	void Start () {
		carChasis1 = GameObject.Find ("Chassis1");
		carChasis2 = GameObject.Find ("Chassis2");
		carChasis3 = GameObject.Find ("Chassis3");
		carChasis = carChasis1;
		carChasis.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);

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

		GUIStyle customLabel = new GUIStyle("label");
		customLabel.fontSize = 36;

		GUI.Label (new Rect (20, 40, 200, 100), "Body Color", customLabel);

		if(GUI.Button(new Rect(20, 100, 200, 100), "Black", customButton)) {
			Debug.Log("Button Pressed");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[1];
		}

		if(GUI.Button(new Rect(230, 100, 200, 100), "Blue", customButton)) {
			Debug.Log("Button Pressed");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[2];
		}

		if(GUI.Button(new Rect(440, 100, 200, 100), "Green", customButton)) {
			Debug.Log("Button Pressed");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[3];
		}

		if(GUI.Button(new Rect(650, 100, 200, 100), "Red", customButton)) {
			Debug.Log("Button Pressed");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[4];
		}

		if(GUI.Button(new Rect(860, 100, 200, 100), "Yellow", customButton)) {
			Debug.Log("Button Pressed");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[5];
		}

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
	}
}
