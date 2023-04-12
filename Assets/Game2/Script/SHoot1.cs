using UnityEngine;
using System.Collections;

public class SHoot1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 5f);
    }
    
    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * 8);
	}
}
