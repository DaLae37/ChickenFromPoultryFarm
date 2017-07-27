using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;

public class GoGo : MonoBehaviour {
    public int random;
    public int num;
    public Renderer JS;
    // Use this for initialization
    void Start()
    {
        JS = this.gameObject.GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        num = FlyingChicken.score;
        if (num/2==0)
         {
            random = Random.RandomRange(0, 10);
            if (random < 10)
            {
                JS.enabled = true;
                StartCoroutine(Over());
                JS.enabled = false;
            }
        }
        else
        {
            JS.enabled = false;
        }
    }
    IEnumerator Over()
    {
        yield return new WaitForSeconds(1f);
    }
}
