using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
    public static float Speed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * Time.deltaTime * Speed);
        if (transform.position.x < -10)
        {
            Vector3 pos = transform.position;
            pos.x = 10;
            transform.position = pos;
        }
	}
}
