using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class INGAME : MonoBehaviour {

    void goGame1()
    {
        SceneManager.LoadScene("game1");
    }
    void goGame2()
    {
        SceneManager.LoadScene("FlappyChicken");
    }
    void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
