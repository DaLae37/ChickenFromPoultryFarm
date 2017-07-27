using UnityEngine;
using System.Collections;

public class moveblock : MonoBehaviour {

	void Update () {
        transform.Translate(new Vector2(0, -1f)*Time.deltaTime);
	}
}
