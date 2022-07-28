using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _playagain;
    public GameObject _mainmenu;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PlayAgain()
    {
        Debug.Log("Playagin Pressed");
        SceneManager.LoadScene("MainScene");

    }
}
