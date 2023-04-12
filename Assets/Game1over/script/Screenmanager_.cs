using UnityEngine;
using System.Collections;

public class Screenmanager_ : MonoBehaviour {

	void Start () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	void Update () {
	
	}
}
