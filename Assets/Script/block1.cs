using UnityEngine;
using System.Collections;

public class block1 : MonoBehaviour {

    public static block1 instance;
    bool change=true;
    public float speed = 5f;
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    void Update()
    {
        if(change==true)
            transform.Translate(new Vector2(1f, 0) * speed * Time.deltaTime);
        else
            transform.Translate(new Vector2(-1f, 0) * speed * Time.deltaTime);
    }
    void OnBecameInvisible()
    {
        if (change == true)
            change = false;
        else
            change = true;
    }
}