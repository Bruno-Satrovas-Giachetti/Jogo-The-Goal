using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    float horizontalInput;
    bool facingRight = true;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        SetupDirectionByScale();
    }

    void SetupDirectionByScale()
    {
        if (horizontalInput < 0 && facingRight || horizontalInput > 0  && !facingRight)
        {
            facingRight = !facingRight;
            Vector3 playerScale = transform.localScale;
            playerScale.x *= -1;
            transform.localScale = playerScale;
        }
    }
}
