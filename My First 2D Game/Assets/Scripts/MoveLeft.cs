using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
   public float movespeed = 10;

    private Player _playerScript;

    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Capy").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(_playerScript.isGameOver == false) can also work for below
        if(!_playerScript.isGameOver)
        {
            transform.Translate(Vector2.left * movespeed * Time.deltaTime);
        }
    }
}
