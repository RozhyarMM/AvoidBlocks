using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGameInfo : MonoBehaviour
{
    public GameObject _coins;
    public GameObject _gems;
    public GameObject _distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _coins.GetComponent<Text>().text = Player._coins.ToString();
        _gems.GetComponent<Text>().text = Player._gems.ToString();
        _distance.GetComponent<Text>().text = Player._distance.ToString();

    }
}
