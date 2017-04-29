using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasisTapController : MonoBehaviour {
	private GameObject carChasis, carChasis1, carChasis2, carChasis3;
	private GameObject car;
	Material[] materials;
	bool chasisMenuToggle;

	// Use this for initialization
	void Start () {
		var car = GameObject.Find ("Car Model Changer");

		carChasis1 = GameObject.Find ("Chassis1");
		carChasis2 = GameObject.Find ("Chassis2");
		carChasis3 = GameObject.Find ("Chassis3");
		carChasis = carChasis1;

		carChasis.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);

		materials = car.GetComponent<colorChanger> ().materials;

		chasisMenuToggle = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (carChasis1.GetComponent<Transform> ().localScale.x != 0) {
			carChasis = carChasis1;
		} else if (carChasis2.GetComponent<Transform> ().localScale.x != 0) {
			carChasis = carChasis2;
		} else if (carChasis3.GetComponent<Transform> ().localScale.x != 0) {
			carChasis = carChasis3;
		}
	}

	void OnMouseDown()
	{
		Debug.Log("chasis tapped");
		chasisMenuToggle = !chasisMenuToggle;
		GameObject.Find ("Car Model Changer").GetComponent<colorChanger> ().chasisMenuOn = chasisMenuToggle;
		if (chasisMenuToggle) {
			GameObject.Find ("Car Model Changer").GetComponent<colorChanger> ().wheelMenuOn = false;
		}
	}

	void OnGUI() {
		if (GameObject.Find ("Car Model Changer").GetComponent<colorChanger> ().chasisMenuOn) {
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
}
