using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class RegularFishBehavior : MonoBehaviour
{
    [SerializeField] float swimSpeed;
    [SerializeField] private float leftPositionX = -42;
    [SerializeField] private float rightPositionX = 42;
    [SerializeField] public float minPositionY = -4.7f;
    [SerializeField] public float maxPositionY = -0.50f;
    private int quota;

    private void Start()
    {
        quota = GameManagerLevel1.Instance.quota;
    }


    void Update()
    {
        transform.Translate(swimSpeed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hook"))
        {
            if (quota > 0)
            {
                KeepValues.Values.AddScore(100);
                GameManagerLevel1.Instance.FillQuota();
                KeepValues.Values.AddMoney();
                KeepValues.Values.RegularFishUnderQuota();
                GameManagerLevel1.Instance.FishCount();
            }

            if (quota <= 0)
            {
                KeepValues.Values.DecreaseScore(200);
                KeepValues.Values.AddMoney();
                KeepValues.Values.RegularFishAboveQuota();
                GameManagerLevel1.Instance.FishCount();
            }

            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Warp Left"))
        {
                Vector2 newPosition = new Vector2(rightPositionX, SetRandomYPosition());
                transform.position = newPosition;
        }

        if (collision.gameObject.CompareTag("Warp Right"))
        {
            Vector2 newPosition = new Vector2(leftPositionX, SetRandomYPosition());
            transform.position = newPosition;
        }

    }

    private float SetRandomYPosition()
    {
        return Random.Range(minPositionY, maxPositionY);
    }
}
