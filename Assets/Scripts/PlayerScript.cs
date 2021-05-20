using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private const float JumpSpeed = 300f;

    public CharacterController2D controller;
    public float horizontalSpeed = 40f;

    Rigidbody2D body;
    Animator animator;
    bool jump = false;

    float horizontalMove = 0f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * horizontalSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
