using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Animator anim;
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
