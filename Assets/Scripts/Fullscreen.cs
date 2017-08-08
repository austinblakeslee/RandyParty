using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fullscreen : MonoBehaviour {

	public Toggle checkbox;
	public Dropdown myDD;

	// Use this for initialization
	void Start () {
		Toggle btn = checkbox.GetComponent<Toggle> ();

		if (Screen.fullScreen == true) {
			btn.isOn = true;
		} else if (Screen.fullScreen == false) {
			btn.isOn = false;
		}

		print (Screen.fullScreen);
		print (btn.isOn);

		btn.onValueChanged.AddListener (delegate {
			if(btn.isOn == true) {
				Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
			}
			else if(btn.isOn == false){
				Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, false);
			}
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
