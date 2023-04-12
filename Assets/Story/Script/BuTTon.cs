using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BuTTon : MonoBehaviour {

    void Start()
    {
        BackgroundAudio.instance.BackAudio();
    }
    void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
