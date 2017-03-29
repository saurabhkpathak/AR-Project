using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour {
	private GameObject carChasis;
	public Material[] materials;

	// Use this for initialization
	void Start () {
		//carChasis = GameObject.Find ("Chassis");
		//carChasis.GetComponent<Renderer>().sharedMaterial = materials[1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		//GUI.Box (new Rect (10, 10, 150, 120), "Change Color");

		if(GUI.Button(new Rect(20, 40, 110, 80), "Button1")) {
			Debug.Log("Button Pressed");
			carChasis = GameObject.Find ("Chassis");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[1];
		}

		if(GUI.Button(new Rect(110, 40, 110, 80), "Button2")) {
			Debug.Log("Button Pressed");
			carChasis = GameObject.Find ("Chassis");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[2];
		}

		if(GUI.Button(new Rect(200, 40, 110, 80), "Button3")) {
			Debug.Log("Button Pressed");
			carChasis = GameObject.Find ("Chassis");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[3];
		}

		if(GUI.Button(new Rect(290, 40, 110, 80), "Button4")) {
			Debug.Log("Button Pressed");
			carChasis = GameObject.Find ("Chassis");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[4];
		}

		if(GUI.Button(new Rect(380, 40, 110, 80), "Button5")) {
			Debug.Log("Button Pressed");
			carChasis = GameObject.Find ("Chassis");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[5];
		}
	}
}
