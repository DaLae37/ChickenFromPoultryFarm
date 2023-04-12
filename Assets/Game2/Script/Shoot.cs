using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    Rigidbody2D rig = null;
    public float movespeed = 0.5f;
    public GameObject SHootPrefab;
    public bool isShoot = true;
    float shootDelay = 0.5f;
    float shootTimer = 0;

    
    // Use this for initialization
    void Start () {
        rig = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (FlyingChicken.isGameOver == false)
        {
            if (Input.anyKeyDown)
            {
                rig.velocity = Vector2.zero;
                rig.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
                Instantiate(SHootPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
