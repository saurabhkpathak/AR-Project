using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour {
	private GameObject carChasis;
	public Material[] materials;

	// Use this for initialization
	void Start () {
		carChasis = GameObject.Find ("Chassis");
		carChasis.GetComponent<Renderer>().sharedMaterial = materials[1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
