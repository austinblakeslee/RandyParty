using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectHit : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	ScoreUI player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("ScoreTracker").GetComponent<Text> ().GetComponentInChildren<ScoreUI> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if(Physics.Raycast(ray, out hit)) {
			if (hit.collider.tag == "Stain" && hit.distance < 1.0) {
				player.increaseScore (50);
				Destroy (hit.transform.gameObject);
			}
		}
	}
}
