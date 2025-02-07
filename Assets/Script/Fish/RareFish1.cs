using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RareFish1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hook"))
        {
            GameManagerLevel1.Instance.RareFishCount1();
        }
    }
}
