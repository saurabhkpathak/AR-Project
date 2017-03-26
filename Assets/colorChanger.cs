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
		GUI.Box (new Rect (10, 10, 90, 60), "Change Color");

		if(GUI.Button(new Rect(20, 40, 60, 20), "Button1")) {
			Debug.Log("Button Pressed");
			carChasis = GameObject.Find ("Chassis");
			carChasis.GetComponent<Renderer>().sharedMaterial = materials[1];
		}
	}
}
