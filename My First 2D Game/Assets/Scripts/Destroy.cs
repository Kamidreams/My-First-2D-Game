using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float floor = -15;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < floor)
        {
            Destroy(this.gameObject);
        }
    }
}
