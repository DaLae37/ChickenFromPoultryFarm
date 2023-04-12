using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour {

    void Start()
    {
        LastAudio.instance._Sound();
    }
    void replaybutton()
    {
        SceneManager.LoadScene("game1");
    }
    void mainbutton()
    {
        SceneManager.LoadScene("GameStart");
    }
}
