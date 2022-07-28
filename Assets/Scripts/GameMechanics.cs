using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMechanics : MonoBehaviour
{
    public static bool _playerAlive = true;
    public GameObject _map;
    public int _zPos = 100;
    private int numOfMaps;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_playerAlive)
        {
            StartCoroutine(GenerateMap());
        }
        else if (_playerAlive == false)
        {
            StopCoroutine(GenerateMap());
            SceneManager.LoadScene("Gameover");
        }
    }

    IEnumerator GenerateMap()
    {
        if(numOfMaps <10)
        {
            yield return new WaitForSeconds(3f * Time.deltaTime);
            Instantiate(_map, new Vector3(-0, 0, _zPos), Quaternion.identity);
            _zPos += 100;
            yield return new WaitForSeconds(3f);
            numOfMaps++;
        }
    }

}
