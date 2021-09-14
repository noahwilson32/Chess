using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;
    public float moveSpeed = 5f;
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        controller.SimpleMove(movement * moveSpeed);

        if(horizontal > .01f || horizontal < -.1f)
        {
            anim.SetBool("isWalk", true);
        }
        
    }

}
