using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class trackableList : MonoBehaviour {
	GameObject mainCar;
	bool found = false;
	// Use this for initialization
	void Start () {
		mainCar = GameObject.Find ("Car Container");
	}
	
	// Update is called once per frame
	void Update () {
		// Get the Vuforia StateManager
		StateManager sm = TrackerManager.Instance.GetStateManager ();

		// Query the StateManager to retrieve the list of
		// currently 'active' trackables 
		//(i.e. the ones currently being tracked by Vuforia)
		IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();

		// Iterate through the list of active trackables
		foreach (TrackableBehaviour tb in activeTrackables) {
			if (tb.TrackableName == "notebook2") {
				mainCar.GetComponent<Transform> ().position = tb.transform.position;
			}
		}
	}
}
