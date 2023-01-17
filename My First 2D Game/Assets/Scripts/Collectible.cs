using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
  public float VegCollect = 1;
  public GameObject VegIndicator;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            VegIndicator.gameObject.SetActive(true);
            HasCollectible = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
