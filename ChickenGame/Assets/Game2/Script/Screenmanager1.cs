using UnityEngine;
using System.Collections;

public class Screenmanager1 : MonoBehaviour {

	void Start () {
        Screen.orientation = ScreenOrientation.Landscape;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	void Update () {
	
	}
}
