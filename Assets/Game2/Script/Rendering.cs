using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;

public class Rendering : MonoBehaviour {

    public float health;
    public int HealthLim;
    public Renderer JS;
    // Use this for initialization
    void Start()
    {
        JS = this.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        health = FlyingChicken.Life;
        if (health/2 < HealthLim)
        {
            JS.enabled = false;
        }
        else
        {
            JS.enabled = true;
        }
    }
}
