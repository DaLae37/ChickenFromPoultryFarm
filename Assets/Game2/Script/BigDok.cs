using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;

public class BigDok : MonoBehaviour {
    public GameObject Dok = null;
    public Renderer JS;
    static public int Damage = 0;
    private bool On = false;
    private int get = 4;
    private int check;
    Coroutine cn;
    static public bool re = false;
	// Use this for initialization
	void Start () {
        JS = this.gameObject.GetComponent<Renderer>();
        JS.enabled = false;
      
    }
    IEnumerator CreateObstruction()
    {
       
        while (true)
        {
                Instantiate(Dok, new Vector2(8, Random.Range(1.0f, 3.0f)), Quaternion.identity);
                SoundManager_.instance.bird_();
                yield return new WaitForSeconds(Random.Range(1f, 2.5f));
        }
        
    }
    // Update is called once per frame
    void Update () {
        if (Damage == 5)
        {
            StopCoroutine(cn);
            JS.enabled = false;
            re = false;
            On = true;
            Damage = 0;
        }
        if (FlyingChicken.score > 0 && On == false)
        {
            JS.enabled = true;
            re = true;
            cn = StartCoroutine(CreateObstruction());
            On = true;
            get = 0;
        }
        if(re == false)
        {
            if(check!=FlyingChicken.score)
            {
                get += 1;
                check = FlyingChicken.score;
            }
        }
        if(get==4)
        {
            On = false;
        }
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Bullet" && re==true)
        {
            Destroy(coll.gameObject);
            Damage += 1;
        }

    }
}
