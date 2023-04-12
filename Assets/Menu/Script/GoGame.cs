using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GoGame : MonoBehaviour {

    void GameMenu()
    {
        SceneManager.LoadScene("GameStart");
    }
    void storytelling()
    {
        SceneManager.LoadScene("Story");
    }
    void Gameex()
    {
        SceneManager.LoadScene("GameExplain");
    }
}
