using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BtnScript : MonoBehaviour, IVirtualButtonEventHandler {
	private GameObject btnObject;
	private GameObject zombie;
	// Use this for initialization
	void Start () {
		btnObject = GameObject.Find ("playButton");
		zombie = GameObject.Find ("zombie");
		btnObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		zombie.GetComponent<Animation> ().Play ();
		Debug.Log ("Button Pressed!!!");
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		zombie.GetComponent<Animation> ().Stop ();
	}
}
