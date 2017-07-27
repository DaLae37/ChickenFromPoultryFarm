using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainPass : MonoBehaviour {

	void Update () {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene("MainMenu");
        }
	}
}
