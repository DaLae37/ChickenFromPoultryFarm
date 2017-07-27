using UnityEngine;
using System.Collections;

public class Screenmanager_ : MonoBehaviour {

	void Start () {
        Screen.orientation = ScreenOrientation.Landscape;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	void Update () {
	
	}
}
