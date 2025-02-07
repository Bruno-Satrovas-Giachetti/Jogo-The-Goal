using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookBehavior : MonoBehaviour
{
    private float hookSpeed;
    bool canMoveUp = true;
    bool canMoveDown = true;

    float downPositionY = -4.5f;
    float upPositionY = 2f;
    [SerializeField] private AudioSource trashSFX;
    [SerializeField] private AudioSource regularFishSFX;
    [SerializeField] private AudioSource rareFishSFX;

    private void Start()
    {
        hookSpeed = KeepValues.Values.hookSpeed;
        canMoveUp = true;
        canMoveDown = true;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) && canMoveUp)
        {
            transform.Translate(0, hookSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.S) && canMoveDown)
        {
            transform.Translate(0, hookSpeed * Time.deltaTime * -1, 0);
        }

        if (transform.position.y < downPositionY)
        {
            canMoveDown = false;
        }

        else if (transform.position.y > upPositionY)
        {
            canMoveUp = false;
        }

        else
        {
            canMoveUp = true;
            canMoveDown = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
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
