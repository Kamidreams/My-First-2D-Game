using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
     public float jumpForce = 10;
    public bool isOnGround = false;
    public bool isGameOver = false;
    public AudioClip jumpSound;   
    private Animator _playerAnim;
    private AudioSource _playerAudio;
    private Collider2D _myCollider;
    private Rigidbody2D _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerAudio = GetComponent<AudioSource>();
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
        float horizontalInput = Input.GetAxis("Horizontal");
        _playerRb.velocity = new Vector2(horizontalInput = speed, _playerRb.velocity.y);
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
