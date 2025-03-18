using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Generate generate;

    private void Start()
    {
        generate = FindAnyObjectByType<Generate>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            generate.canSpawn++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.layer == 11)
        {
            generate.canSpawBispos++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.layer == 12)
        {
            generate.canSpawTower++;
            Destroy(collision.gameObject);
        }
    }
}
