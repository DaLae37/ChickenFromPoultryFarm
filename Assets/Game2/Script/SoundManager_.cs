using UnityEngine;
using System.Collections;
public class SoundManager_ : MonoBehaviour {

    public AudioClip soundChicken;
    public AudioClip soundJump;
    public AudioClip water;
    public AudioClip bird;
    public AudioClip coin;

    AudioSource Audio_;
    public static SoundManager_ instance;
    void Awake()
    {
        if (SoundManager_.instance == null)
        {
            SoundManager_.instance = this;
        }
        Audio_ = this.gameObject.GetComponent<AudioSource>();
    }
	void Start () {
	}
    public void PlaySound_()
    {
        Audio_.PlayOneShot(soundChicken);
    }
    public void JumpSound_()
    {
        Audio_.PlayOneShot(soundJump);
    }
    public void water_()
    {
        Audio_.PlayOneShot(water);
    }
    public void bird_()
    {
        Audio_.PlayOneShot(bird);
    }
    public void coin_()
    {
        Audio_.PlayOneShot(coin);
    }
}
