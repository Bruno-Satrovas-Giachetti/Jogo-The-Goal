using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    bool canMoveRight = true;
    bool canMoveLeft = true;

    float leftPositionX = -34;
    float rightPositionX = 38;

    private void Start()
    {
        moveSpeed = KeepValues.Values.moveSpeed;
        canMoveRight = true;
        canMoveLeft = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) && canMoveLeft)
        {
            transform.Translate(moveSpeed * Time.deltaTime * -1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D) && canMoveRight)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }

        if (transform.position.x < leftPositionX)
        {
            canMoveLeft = false;
        }

        else if (transform.position.x > rightPositionX)
        {
            canMoveRight = false;
        }

        else
        {
            canMoveLeft = true;
            canMoveRight = true;
        }
    }
}
