using UnityEngine;
using System.Collections;

public class Changemove : MonoBehaviour {

    void OnBecameInvisible()
    {
        if (this.gameObject.tag == "right"){
            this.transform.gameObject.tag = "left";
        }
        else
        {
            this.transform.gameObject.tag = "right";
        }
    }
}
