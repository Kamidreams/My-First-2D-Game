using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }
void OnTriggerEnter(Collider other)
 {
     if (other.gameObject.tag == "Player")
         SceneManager.LoadScene(3);
         Debug.Log("its Colliding!");
 }
    // Update is called once per frame
    void Update()
    {
        
    }
}
