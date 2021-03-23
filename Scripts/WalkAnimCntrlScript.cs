using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimCntrlScript : MonoBehaviour
{
    public Animator animator;
    public float InputX;
    public bool IsMoving;
    Vector3 startPos, finishPos;

    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        IsMoving = false;
        startPos = new Vector3(-84.6f, 0f, 58.5f);
        finishPos = new Vector3(-79.6f, 0f, 58.5f);

        transform.position = startPos;
        InputX = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.P) && !IsMoving)
        {
            transform.position = startPos;
            InputX = 1;
            IsMoving = true;
            animator.SetFloat("InputX", InputX);
        }
      
        if (transform.position.x >= finishPos.x)
        {
            InputX = 0;
            IsMoving = false;
            animator.SetFloat("InputX", InputX);
        }
    }
}
