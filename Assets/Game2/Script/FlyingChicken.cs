using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlyingChicken : MonoBehaviour
{
    Rigidbody2D rig = null;
    public Text scoreText;
    static public bool isGameOver=false;
    static public int score = 0;
    float NeedForSpeed = 0;
    int check = 0;
    bool Plus = false;
    static public bool underthesea = false;
    static public int Life = 10;
    static public bool Stop;
    public static float HP = 100;
    int a = 0;
    void Awake()
    {
        rig = this.GetComponent<Rigidbody2D>();
        
    }
	void Start ()
    {
        SoundManager_.instance.PlaySound_();
        Time.timeScale = 0;
        score = 0;
        HP = 100;
        Life = 10;
        Stop = true;
	}
	void Update ()
    {

        if(isGameOver==true)//게임 오버시 isGameOver 변수가 true가 됨
        {
            isGameOver = false;
            SceneManager.LoadScene("gameover2");
        }
        if(Life<=0)
        {
            isGameOver = true;//게임 오버
            Life = 5;
            HP = 0;
            Time.timeScale = 0.3f;
        }
        if(HP==0)
        {
            HP = 100;
            Life -= 5;
            
        }
        if (isGameOver == false) //시작화면
        {
            if(Input.anyKeyDown)
            {
                SoundManager_.instance.JumpSound_();
                if(Time.timeScale==0)
                {
                    Time.timeScale = 1; 
                    Stop = false;
                }
                rig.velocity = Vector2.zero;
                rig.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
            }
        }
        if (check != score && score % 2 == 0 && score<30)
        {
            if(check!=score)
            {
                Plus = true;
            }
            check = score;
            NeedForSpeed += 0.3f;
            if(NeedForSpeed>3)
            {
                NeedForSpeed = 3;
            }
            if (Plus == true)
            {
                Obstruction.Speed += NeedForSpeed;
                Plus = false;
            }
        }
        
        if(underthesea == true)
        {
            HP -= 0.5f;
            if(HP<0)
            {
                HP = 0;
            }
            Over();
        }
        else if(underthesea == false)
        {
            HP += 0.5f;
            if (HP>100)
            {
                HP = 100;
            }
            Over();
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Bouble(Clone)") 
        {
            SoundManager_.instance.coin_();
            score += 1;
            scoreText.text = ": " + score.ToString();
            HP += 3;
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.name == "Over" || coll.gameObject.name == "Under")
        {
            Time.timeScale = 0.3f;
            StartCoroutine(Over());
            isGameOver = true;
        }
        if(coll.gameObject.name=="Bada")
        {
            SoundManager_.instance.water_();
            underthesea = true;
        }
        else if(coll.gameObject.name=="Sky")
        {
            underthesea = false;
        }
        if(coll.gameObject.name== "Cloud(Clone)")
        {
            Destroy(coll.gameObject);
            HP += 10;
        }
    }
    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Haecho(Clone)")//게임 오버
        {
            Time.timeScale = 0.3f;
            StartCoroutine(Over());
            isGameOver = true;
        }
    }
    IEnumerator Over()
    {
        yield return new WaitForSeconds(1f);
    }

}


