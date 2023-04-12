using UnityEngine;
using System.Collections;

public class Background_ : MonoBehaviour {

    private new Renderer renderer;

    public float Scroll_speed = 3f;
    public float Offset;

	void Start () {
        renderer = GetComponent<Renderer>();
    }
	void Update () {
        Offset = Time.time * Scroll_speed;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(0, Offset));
    }
}
