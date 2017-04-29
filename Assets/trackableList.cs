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
		int i = 0;
		int indexFoundAt = 0;
		bool found = false;
		TrackableItem[] trackableItems = new TrackableItem[2];
		for (int k =0; k < trackableItems.Length; k++) {
			trackableItems [k] = new TrackableItem ();
		}
		// Get the Vuforia StateManager
		StateManager sm = TrackerManager.Instance.GetStateManager ();

		// Query the StateManager to retrieve the list of
		// currently 'active' trackables 
		//(i.e. the ones currently being tracked by Vuforia)
		IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();

		// Iterate through the list of active trackables
		foreach (TrackableBehaviour tb in activeTrackables) {
			Debug.Log ("index at: " + i);
			trackableItems [i].name = tb.TrackableName;
			trackableItems [i].position = tb.transform.position;
			i++;
		}

		if (trackableItems.Length != 0) {
			for (int j = 0; j < trackableItems.Length; j++) {
				if (trackableItems [j].name == "notebook2") {
					found = true;
					indexFoundAt = j;
				}
			}
			if (found) {
				mainCar.GetComponent<Transform> ().position = trackableItems [indexFoundAt].position;
			} else {
				mainCar.GetComponent<Transform> ().position = trackableItems [0].position;
			}
		}
	}
}
public class TrackableItem {
	public string name;
	public Vector3 position;
	public TrackableItem() {
	}
}