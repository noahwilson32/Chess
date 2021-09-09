using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    public Animator anim;

    public CharacterController controller;
    public float moveSpeed = 6f;

    public Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Fire();
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            cam.transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            controller.Move(direction * moveSpeed * Time.deltaTime);
        }
    }

    public void Walk()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalk", true);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }
    }
    public void Fire()
    {
        if (Input.GetMouseButton(0))
        {
            anim.SetBool("isFire", true);
        }
        else
        {
            anim.SetBool("isFire", false);
        }
    }
}
