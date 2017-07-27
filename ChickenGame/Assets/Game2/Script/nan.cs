using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class nan : MonoBehaviour {

    Rigidbody2D rig = null;

    void Awake()
    {
        rig = this.GetComponent<Rigidbody2D>();
    }
    void Start () {
	
	}

    void Update()
    {
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch t = Input.GetTouch(i);
                if (t.phase == TouchPhase.Began)
                {
                    RaycastHit2D hitinfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(t.position), Vector2.zero);
                    if (hitinfo.collider != null)
                    {
                        string collidername = hitinfo.collider.name;
                        if (collidername == "Rightbutton")
                        {
                            rig.velocity = Vector2.zero;
                            rig.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
                        }
                    }
                }
                if (t.phase == TouchPhase.Stationary)
                {
                    RaycastHit2D hitinfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(t.position), Vector2.zero);
                    if (hitinfo.collider != null)
                    {
                        string collidername = hitinfo.collider.name;

                        if (collidername == "Leftbutton")
                        {
                        }
                    }
                }
            }
        }
    }
}
