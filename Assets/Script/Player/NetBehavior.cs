using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetBehavior : MonoBehaviour
{
    [SerializeField] private float netSpeed;
    [SerializeField] private AudioSource trashSFX;
    [SerializeField] private AudioSource regularFishSFX;
    [SerializeField] private AudioSource rareFishSFX;

    private void Update()
    {
        transform.Translate(0, netSpeed * Time.deltaTime * -1, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("trash"))
        {
            trashSFX.Play();
        }

        if (collision.gameObject.CompareTag("regular_fish"))
        {
            regularFishSFX.Play();
        }

        if (collision.gameObject.CompareTag("rare_fish"))
        {
            rareFishSFX.Play();
        }
    }
}
