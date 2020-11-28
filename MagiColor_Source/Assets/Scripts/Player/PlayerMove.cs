using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    private SpriteRenderer a;
    Animator animator;
    bool isMoving = false;
    void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
        a = gameObject.GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {

        move();
    }

    void move()
    {
        animator.SetBool("isMoving", false);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1.5f * 15 * Time.deltaTime, 0, 0));
            a.flipX = true;
            animator.SetBool("isMoving", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1.5f * 15 * Time.deltaTime, 0, 0));
            a.flipX = false;
            animator.SetBool("isMoving", true);
        }

    }
}
  
