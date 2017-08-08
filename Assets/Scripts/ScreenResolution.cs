using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenResolution : MonoBehaviour {

	public Dropdown myDD;
	public static Resolution teneighty = new Resolution ();
	public static Resolution seventwenty = new Resolution ();
	public static Resolution fourteen40 = new Resolution ();
	Resolution[] resolutions = new Resolution[]{seventwenty, teneighty, fourteen40};
	string[] resNames = new string[]{"720p","1080p","1440p"};

	// Use this for initialization
	void Start () {
		seventwenty.width = 1280;
		seventwenty.height = 720;
		teneighty.width = 1920;
		teneighty.height = 1080;
		fourteen40.width = 2560;
		fourteen40.height = 1440;
		resolutions.SetValue (seventwenty, 0);
		resolutions.SetValue (teneighty, 1);
		resolutions.SetValue (fourteen40, 2);
		myDD.options.Clear ();

		for (int i = 0; i < resolutions.Length; i++) {
			print (resolutions[i].width + " x " + resolutions[i].height);
			myDD.options.Add (new Dropdown.OptionData (ResToString (resolutions [i])));
			myDD.options [i].text = resNames[i];
			if (resolutions [i].width == Screen.currentResolution.width && resolutions [i].height == Screen.currentResolution.height) {
				myDD.value = i;
			}
		}

		myDD.onValueChanged.AddListener (delegate {
			Screen.SetResolution (resolutions [myDD.value].width, resolutions [myDD.value].height, Screen.fullScreen);
		});
	}
	
	string ResToString(Resolution res) {
		return res.width + " x " + res.height;
	}
}
