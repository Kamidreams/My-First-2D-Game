using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capy : MonoBehaviour
{
    public bool isOnGround = false;
    public bool isGameOver = false; 
    private Animator _capyAnim;
    private Collider2D _Collider;
     private Rigidbody2D _capyRb;
    // Start is called before the first frame update
    void Start()
    {
         _capyAnim = GetComponent<Animator>();
        _capyRb = GetComponent<Rigidbody2D>();
        _Collider = GetComponent<Collider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            _capyAnim.SetBool("IsOnGround", true);
        }
    }
}
