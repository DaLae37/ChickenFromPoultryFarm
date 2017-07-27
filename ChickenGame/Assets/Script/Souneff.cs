using UnityEngine;
using System.Collections;

public class Souneff : MonoBehaviour {

    public AudioClip sound;
    public AudioClip coin;
    public AudioClip jump;
    public AudioClip bird;
    AudioSource myAudio;
    public static Souneff instance;
    void Awake()
    {
        if (Souneff.instance == null)
        {
            Souneff.instance = this;
        }
    }
	void Start () {
        myAudio = this.gameObject.GetComponent<AudioSource>();	
	}
	
    public void PlaySound()
    {
        myAudio.PlayOneShot(sound);
    }
    public void CoinSound()
    {
        myAudio.PlayOneShot(coin);
    }
    public void JumpSound()
    {
        myAudio.PlayOneShot(jump);
    }
    public void birdSound()
    {
        myAudio.PlayOneShot(bird);
    }
}
