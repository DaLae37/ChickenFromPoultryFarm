using UnityEngine;
using System.Collections;

public class LastAudio : MonoBehaviour
{

    public AudioClip sound;
    AudioSource _Audio;
    public static LastAudio instance;
    void Awake()
    {
        if (LastAudio.instance == null)
        {
            LastAudio.instance = this;
        }
    }
    void Start()
    {
        _Audio = this.gameObject.GetComponent<AudioSource>();
    }

    public void _Sound()
    {
        _Audio.PlayOneShot(sound);
    }
}
