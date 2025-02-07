using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootNet : MonoBehaviour
{
    [SerializeField] private NetBehavior net;
    [SerializeField] private ShootNet Player;
    private int netAmount;

    [SerializeField] private AudioSource audioSource;



    private void Update()
    {
        netAmount = KeepValues.Values.netAmount;
        Vector2 ObjectSpawnPosition = Player.transform.position;
        if (Input.GetKeyDown(KeyCode.Space) && netAmount > 0)
        {
            audioSource.Play();
            Instantiate(net, ObjectSpawnPosition, Quaternion.identity);
            KeepValues.Values.NetAmount();
        }
    }
}
