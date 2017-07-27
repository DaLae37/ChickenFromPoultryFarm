using UnityEngine;
using System.Collections;

public class PaDo : MonoBehaviour {
    private float deltaX = 0.0f;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(FlyingChicken.Stop==false)
        {
            Time.timeScale = 1;
            deltaX += Time.deltaTime;
            this.transform.Translate(Vector3.up * Mathf.Sin(deltaX*7)*0.02f);
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
