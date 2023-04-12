using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GOBACK : MonoBehaviour {

    void GoBackTime()
    {
        SceneManager.LoadScene("GameExplain");
    }
}
