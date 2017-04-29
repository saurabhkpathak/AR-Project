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
	private GameObject car;

	// Use this for initialization
	void Start () {
		car = GameObject.Find ("Car Model Changer");
		wheelMenuToggle = false;

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
		if (wheelMenuToggle) {
			GUIStyle customButton = new GUIStyle("button");
			customButton.fontSize = 40;

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
}
