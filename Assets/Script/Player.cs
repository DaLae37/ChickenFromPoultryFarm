using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{

    Rigidbody2D rig;
    public Text scoreText;
    int score = 0;

    void Awake()
    {
        score = 0;
    }
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
        Souneff.instance.PlaySound();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            Time.timeScale = 1;
        }
        transform.Translate(new Vector2(0, -1f) * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            Souneff.instance.JumpSound();
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 5.0f, 0);
        }
        if (Input.GetKeyDown("e"))
        {
            Souneff.instance.JumpSound();
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 5.0f, 0);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "die")
        {
            SceneManager.LoadScene("gameover");
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "die")
        {
            SceneManager.LoadScene("gameover");
        }
        if (coll.gameObject.tag == "food")
        {
            Souneff.instance.CoinSound();
            score += 1;
            block1.instance.speed += 3f;
            scoreText.text = "        : " + score.ToString();
            Destroy(coll.gameObject);
        }
    }
    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "right")
        {
            transform.Translate(new Vector2(3f, 0) * Time.deltaTime);
        }
        if (coll.gameObject.tag == "left")
        {
            transform.Translate(new Vector2(-3f, 0) * Time.deltaTime);
        }
       
    }
    void OnBecameInvisible()
    {
        SceneManager.LoadScene("gameover");
    }
}