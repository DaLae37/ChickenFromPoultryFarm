using UnityEngine;
using System.Collections;

public class BackgroundAudio : MonoBehaviour {
    public AudioClip BackSound;
    AudioSource BAudio;
    public static BackgroundAudio instance;

    void Awake()
    {
        if (BackgroundAudio.instance == null)
        {
            BackgroundAudio.instance = this;
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
