using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float _sideSpeed = 4f;
    public static int _coins;
    public static int _gems;
    public static float _distance;
    public float _moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        GameMechanics._playerAlive = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameMechanics._playerAlive)
        {
            GameRun();
            PlayerMovement();
            DistancePassed();
        }
        if (GameMechanics._playerAlive == false)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (_coins >= 1000)
        {
            _coins = 1000;
            _gems += 1;
            _moveSpeed *= 1.5f;
        }

    }
    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -3.5)
            {
                transform.Translate(Vector3.left * _sideSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 3.5)
            {
                transform.Translate(Vector3.right * _sideSpeed * Time.deltaTime);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacles")
        {
            GameMechanics._playerAlive = false;
        }
        if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
            _coins++;
        }
    }


    void GameRun()
    {
        transform.Translate(new Vector3(0, 0, 1) * _moveSpeed * Time.deltaTime);

    }

    void DistancePassed()
    {
        if (GameMechanics._playerAlive)
        {
            _distance += _moveSpeed * Time.deltaTime * _moveSpeed;
        }
    }


}
