using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour
{
    public AudioClip BackSound;
    AudioSource BAudio;
    public static Audio instance;

    void Awake()
    {
        if (Audio.instance == null)
        {
            Audio.instance = this;
        }
    }
    void Start()
    {
        BAudio = this.gameObject.GetComponent<AudioSource>();
    }
    public void BackAudio()
    {
        BAudio.PlayOneShot(BackSound);
    }
}
