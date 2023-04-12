using UnityEngine;
using System.Collections;

public class Screenmanager1 : MonoBehaviour {

	void Start () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	void Update () {
	
	}
}
