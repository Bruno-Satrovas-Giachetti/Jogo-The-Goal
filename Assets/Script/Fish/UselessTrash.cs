using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UselessTrash : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hook"))
        {
            Destroy(this.gameObject);
        }
    }
}
