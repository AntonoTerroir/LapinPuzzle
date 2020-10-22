using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public bool idleUp = false;
    public bool idleLeft = false;
    public bool idleDown = false;
    public bool idleRight = false;

    public bool moveUp1 = false;
    public bool moveUp2 = false;

    public bool moveLeft1 = false;
    public bool moveLeft2 = false;

    public bool moveDown1 = false;
    public bool moveDown2 = false;

    public bool moveRight1 = false;
    public bool moveRight2 = false;

    public string lastMove = null;
    public int lastFoot = 1;
    public bool idle = true;

    private Animator animator;

    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    public void MoveUp()
    {
        if (idle)
        {
            if (lastFoot != 2)
            {
                animator.SetTrigger("moveUp2");
                lastFoot = 2;
            }
            else
            {
                animator.SetTrigger("moveUp1");
                lastFoot = 1;
            }

            idle = false;
        }
        else
        {
            animator.SetTrigger("idleUp");
            idle = true;
        }
    }

    public void MoveLeft()
    {
        if (idle)
        {
            if (lastFoot != 2)
            {
                animator.SetTrigger("moveLeft2");
                lastFoot = 2;
            }
            else
            {
                animator.SetTrigger("moveLeft1");
                lastFoot = 1;
            }

            idle = false;
        }
        else
        {
            animator.SetTrigger("idleLeft");
            idle = true;
        }
    }

    public void MoveDown()
    {
        if (idle)
        {
            if (lastFoot != 2)
            {
                animator.SetTrigger("moveDown2");
                lastFoot = 2;
            }
            else
            {
                animator.SetTrigger("moveDown1");
                lastFoot = 1;
            }

            idle = false;
        }
        else
        {
            animator.SetTrigger("idleDown");
            idle = true;
        }
    }

    public void MoveRight()
    {
        if (idle)
        {
            if (lastFoot != 2)
            {
                animator.SetTrigger("moveRight2");
                lastFoot = 2;
            }
            else
            {
                animator.SetTrigger("moveRight1");
                lastFoot = 1;
            }

            idle = false;
        }
        else
        {
            animator.SetTrigger("idleRight");
            idle = true;
        }
    }
}
