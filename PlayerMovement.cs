﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    public Inventory inventory;
    public GameObject gameOverText, restartButton;
    public MobileHealthController healthController;



    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;

    private void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            SoundManager.PlaySound("Jump2");
            //Debug.Log("code runs");
            jump = true;
            animator.SetBool("Jumping", true);
        } 
    }
    public void OnLanding ()
    {
        animator.SetBool("Jumping", false);
    }
    
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,crouch,jump);
        jump = false;
    }

    public void killPlayerOnHealth()
    {
        if (healthController.playerHealth <= 0)
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            //place on death effect here

            gameObject.SetActive(false);

        }

        if (collision.gameObject.tag.Equals("MovingPlatform"))
        {
            this.transform.parent = collision.transform;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("MovingPlatform"))
        {
            this.transform.parent = null;
        }
    }



}
