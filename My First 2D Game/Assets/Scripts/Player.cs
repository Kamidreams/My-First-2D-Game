using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
     public float jumpForce = 10;
     public float xRange;
    public bool isOnGround = false;
    public bool isGameOver = false; 
    private float _horizontalInput;
    private Animator _playerAnim;
    private Collider2D _myCollider;
    private Rigidbody2D _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerRb = GetComponent<Rigidbody2D>();
        _myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FlipSprite();
        Jump();

    }

   void PlayerMovement()
    {
         _horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * _horizontalInput * speed * Time.deltaTime);

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
    void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(_playerRb.velocity.x) > Mathf.Epsilon;

        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(_playerRb.velocity.x), 1f);
        }
    }

    void Jump()
    {
        if(_myCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            isOnGround = true;
        }
        else{
            isOnGround = false;
        }

        if(Input.GetButtonDown("Jump") && isOnGround)
        {
            _playerRb.velocity = new Vector2(_playerRb.velocity.x, jumpForce);
        }
    }
}
