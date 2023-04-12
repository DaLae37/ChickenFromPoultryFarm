using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;

public class Invisible : MonoBehaviour
{
    //여따 체력 들가있는 스크립트 불러오기(변수명은 HealthScript로)
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
        health = FlyingChicken.HP;
        if (health < HealthLim) 
        {
         JS.enabled = false; 
        }
        else
        {
            JS.enabled = true;
        }
    }
}