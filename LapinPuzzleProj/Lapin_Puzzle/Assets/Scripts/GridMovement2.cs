using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement2 : MonoBehaviour
{
    public float moveSpeed = 2f;

    public Transform movePoint;

    public LayerMask whatStopsMovement;

    private CharacterAnimation animator;

    public TileManager tile;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";

        movePoint.parent = null;

        animator = this.GetComponent<CharacterAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }

                if(Input.GetAxisRaw("Horizontal") > 0)
                {
                    animator.MoveRight();
                }
                else
                {
                    animator.MoveLeft();
                }
            }

            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }

                if (Input.GetAxisRaw("Vertical") > 0)
                {
                    animator.MoveUp();
                }
                else
                {
                    animator.MoveDown();
                }
            }
        }
        
    }
}
