using UnityEngine;
using System.Collections;

public class enemymove : MonoBehaviour {


	void Update () {
        transform.Translate(new Vector2(-3f, 0)*Time.deltaTime);
	}
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
