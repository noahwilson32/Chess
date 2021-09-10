using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 5f;
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        controller.SimpleMove(movement * moveSpeed);
        
    }
}
