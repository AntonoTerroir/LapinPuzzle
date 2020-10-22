using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    private bool isMoving;

    private CharacterAnimation animator;

    private Vector3 origPos;
    private Vector3 targetPos;

    private float timeToMove = 0.2f;

    private void Start()
    {
        animator = this.GetComponent<CharacterAnimation>();
    }

    void Update()
    {
        if (!isMoving)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                StartCoroutine(MovePlayer(Vector3.up));
                animator.MoveUp();
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                StartCoroutine(MovePlayer(Vector3.left));
                animator.MoveLeft();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                StartCoroutine(MovePlayer(Vector3.down));
                animator.MoveDown();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                StartCoroutine(MovePlayer(Vector3.right));
                animator.MoveRight();
            }
        }
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        if((targetPos - transform.position).sqrMagnitude < (origPos - transform.position).sqrMagnitude)
        {
            transform.position = targetPos;
        }

        isMoving = false;
    }
}
