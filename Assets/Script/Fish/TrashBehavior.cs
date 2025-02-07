using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hook"))
        {
            KeepValues.Values.TrashCount();
            Destroy(this.gameObject);
        }
    }
}
