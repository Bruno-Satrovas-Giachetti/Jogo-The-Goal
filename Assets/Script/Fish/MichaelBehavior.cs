using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MichaelBehavior : MonoBehaviour
{
    [SerializeField] float swimSpeed;
    [SerializeField] private float leftPositionX = -42;
    [SerializeField] private float rightPositionX = 42;
    [SerializeField] public float minPositionY = -4.7f;
    [SerializeField] public float maxPositionY = -0.50f;
    [SerializeField] private AudioSource HeeHee;


    void Update()
    {
        transform.Translate(swimSpeed * Time.deltaTime, 0, 0);

        //if (transform.position.x == -33.4f)
        //{
        //    PlayHeeHee();
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hook"))
        {
            SceneManager.LoadScene("MichaelEnding");
        }

        if (collision.gameObject.CompareTag("Warp Left"))
        {
            Vector2 newPosition =
                new Vector2(rightPositionX, SetRandomYPosition());
            transform.position = newPosition;
        }

        if (collision.gameObject.CompareTag("Warp Right"))
        {
            Vector2 newPosition =
                new Vector2(leftPositionX, SetRandomYPosition());
            transform.position = newPosition;
            PlayHeeHee();
        }

    }
    private float SetRandomYPosition()
    {
        return Random.Range(minPositionY, maxPositionY);
    }

    private void PlayHeeHee()
    {
        HeeHee.Play();
    }
}
