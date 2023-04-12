using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BUTTON : MonoBehaviour {
    void Start()
    {
        EndSound.instance.Ssound();
    }
    void Replaybutton()
    {
        SceneManager.LoadScene("FlappyChicken");
    }
    void Mainbutton()
    {
        SceneManager.LoadScene("GameStart");
    }
}
