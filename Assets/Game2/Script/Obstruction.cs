using UnityEngine;
using System.Collections;

public class Obstruction : MonoBehaviour
{
    public static float Speed = 5.0f;
	void Start ()
    {
        Destroy(this.gameObject, 5f);
	}
	void Update ()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
	}
}
