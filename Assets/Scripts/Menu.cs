using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject _play;
    public GameObject _exit;
    public GameObject _nameInput;
    public GameObject _nameError;
    string _playerName;

    public void PlayGame()
    {
        _playerName = _nameInput.GetComponent<Text>().text;

        if (_playerName == null || _playerName == "")
        {
            _nameError.GetComponent<Text>().text = "Please enter a name";
        }
        else if (_playerName != null && name != "")
        {
            SceneManager.LoadScene("MainScene");
        }

    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit Pressed");
    }
}
