﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_control : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D CharacterRigidbody;
    public float movable = 1;
    public float CharacterSpeed = 5;
    public float LBoundary;
    public float RBoundary;
    public float UBoundary;
    public float DBoundary;
    public Animator ani;
    void Start()
    {
        CharacterRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {
        CharacterRigidbody.velocity = new Vector3(0, 0, 0);
        if (movable == 1)
        {
            if (Input.GetKey(KeyCode.D))
            {
                CharacterRigidbody.velocity=new Vector3(1f, 0, 0);
                ani.SetBool("right", true);
            }
            else
            {
                ani.SetBool("right", false);

            }

            if (Input.GetKey(KeyCode.A))
            {
                CharacterRigidbody.velocity = new Vector3(-1f, 0, 0);
                ani.SetBool("left", true);
            }
            else
            {
                ani.SetBool("left", false);
            }
        
            if (Input.GetKey(KeyCode.W))
            {
                CharacterRigidbody.velocity = new Vector3(0, 1f, 0);
            
                ani.SetBool("back", true);
            }
            else
            {
                ani.SetBool("back", false);
            }
            if (Input.GetKey(KeyCode.S))
            {
                CharacterRigidbody.velocity = new Vector3(0,-1f, 0);
                
            }

            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
                CharacterRigidbody.velocity = new Vector3(1f, 1f, 0);
            }
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
            {
                CharacterRigidbody.velocity = new Vector3(1f, -1f, 0);
            }
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                CharacterRigidbody.velocity = new Vector3(-1f, 1f, 0);
            }
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
            {
                CharacterRigidbody.velocity = new Vector3(-1f, -1f, 0);
            }
            CharacterRigidbody.velocity = CharacterSpeed * CharacterRigidbody.velocity.normalized;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        movable = 1;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (gameObject.transform.position.x <= LBoundary)
        {
            gameObject.transform.position += new Vector3(0.5f, 0, 0);
        }
        if (gameObject.transform.position.x >= RBoundary)
        {
            gameObject.transform.position += new Vector3(-0.5f, 0, 0); 
        }
        if (gameObject.transform.position.y >= UBoundary)
        {
            gameObject.transform.position += new Vector3(0, -0.5f, 0); 
        }
        if (gameObject.transform.position.y <= DBoundary)
        {
            gameObject.transform.position += new Vector3(0, +0.5f, 0); 
        }
    }

}
   
