using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Destroy(this.gameObject, 8f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * 2);
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.name=="FlyingChicken")
        {
            FlyingChicken.Life -= 1;
            Destroy(this.gameObject);
        }
        if(coll.gameObject.tag== "Bullet")
        {
            Destroy(this.gameObject);
            Destroy(coll.gameObject);
        }
    }
}
