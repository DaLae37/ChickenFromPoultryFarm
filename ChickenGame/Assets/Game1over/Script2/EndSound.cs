using UnityEngine;
using System.Collections;

public class EndSound : MonoBehaviour
{

    public AudioClip zsound;
    AudioSource Aaudio;
    public static EndSound instance;
    void Awake()
    {
        if (EndSound.instance == null)
        {
            EndSound.instance = this;
        }
    }
    void Start()
    {
        Aaudio = this.gameObject.GetComponent<AudioSource>();
    }

    public void Ssound()
    {
        Aaudio.PlayOneShot(zsound);
    }
}
