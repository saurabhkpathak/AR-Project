using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelTapController : MonoBehaviour {
	bool wheelMenuToggle;
	private GameObject lfWheel, lfWheel1, lfWheel2, lfWheel3;
	private GameObject lrWheel, lrWheel1, lrWheel2, lrWheel3;
	private GameObject rfWheel, rfWheel1, rfWheel2, rfWheel3;
	private GameObject rrWheel, rrWheel1, rrWheel2, rrWheel3;
	private float wheelSize;
	Material[] materials;
	private GameObject car;

	// Use this for initialization
	void Start () {
		car = GameObject.Find ("Car Model Changer");
		wheelMenuToggle = false;
		materials = car.GetComponent<colorChanger> ().materials;

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

		lfWheel = lfWheel1;
		lrWheel = lrWheel1;
		rfWheel = rfWheel1;
		rrWheel = rrWheel1;

		lfWheel.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
		lrWheel.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
		rfWheel.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
		rrWheel.GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown()
	{
		Debug.Log("wheel tapped");
		wheelMenuToggle = !wheelMenuToggle;
		GameObject.Find ("Car Model Changer").GetComponent<colorChanger> ().wheelMenuOn = wheelMenuToggle;
		if (wheelMenuToggle) {
			GameObject.Find ("Car Model Changer").GetComponent<colorChanger> ().chasisMenuOn = false;
		}
	}

	void OnGUI() {
		if (GameObject.Find ("Car Model Changer").GetComponent<colorChanger> ().wheelMenuOn) {
			GUIStyle customButton = new GUIStyle("button");
			customButton.fontSize = 40;

			GUIStyle customLabel = new GUIStyle("label");
			customLabel.fontSize = 36;

			GUI.Label (new Rect (20, 40, 300, 100), "Wheels Color", customLabel);

			if(GUI.Button(new Rect(20, 100, 200, 100), "Black", customButton)) {
				Debug.Log("Button Pressed");
				lfWheel.GetComponent<Renderer>().sharedMaterial = materials[1];
				lrWheel.GetComponent<Renderer>().sharedMaterial = materials[1];
				rfWheel.GetComponent<Renderer>().sharedMaterial = materials[1];
				rrWheel.GetComponent<Renderer>().sharedMaterial = materials[1];
			}

			if(GUI.Button(new Rect(20, 210, 200, 100), "Blue", customButton)) {
				Debug.Log("Button Pressed");
				lfWheel.GetComponent<Renderer>().sharedMaterial = materials[2];
				lrWheel.GetComponent<Renderer>().sharedMaterial = materials[2];
				rfWheel.GetComponent<Renderer>().sharedMaterial = materials[2];
				rrWheel.GetComponent<Renderer>().sharedMaterial = materials[2];
			}

			if(GUI.Button(new Rect(20, 320, 200, 100), "Green", customButton)) {
				Debug.Log("Button Pressed");
				lfWheel.GetComponent<Renderer>().sharedMaterial = materials[3];
				lrWheel.GetComponent<Renderer>().sharedMaterial = materials[3];
				rfWheel.GetComponent<Renderer>().sharedMaterial = materials[3];
				rrWheel.GetComponent<Renderer>().sharedMaterial = materials[3];
			}

			if(GUI.Button(new Rect(20, 430, 200, 100), "Red", customButton)) {
				Debug.Log("Button Pressed");
				lfWheel.GetComponent<Renderer>().sharedMaterial = materials[4];
				lrWheel.GetComponent<Renderer>().sharedMaterial = materials[4];
				rfWheel.GetComponent<Renderer>().sharedMaterial = materials[4];
				rrWheel.GetComponent<Renderer>().sharedMaterial = materials[4];
			}

			if(GUI.Button(new Rect(20, 540, 200, 100), "Yellow", customButton)) {
				Debug.Log("Button Pressed");
				lfWheel.GetComponent<Renderer>().sharedMaterial = materials[5];
				lrWheel.GetComponent<Renderer>().sharedMaterial = materials[5];
				rfWheel.GetComponent<Renderer>().sharedMaterial = materials[5];
				rrWheel.GetComponent<Renderer>().sharedMaterial = materials[5];
			}

			if(GUI.Button(new Rect(20, 650, 410, 100), "Change Wheel", customButton)) {
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
}
