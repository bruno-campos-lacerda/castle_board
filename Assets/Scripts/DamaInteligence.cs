using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class DamaInteligence : MonoBehaviour
{
    public float speed;
    public Spawner spawner;

    private void Start()
    {
        spawner.NexPos = spawner.Positions[0];
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        if (transform.position == spawner.NexPos.position)
        {
            spawner.nexPosIndex++;
            if (spawner.nexPosIndex >= spawner.Positions.Length)
            {
                spawner.nexPosIndex = 0;
            }
            spawner.NexPos = spawner.Positions[spawner.nexPosIndex];
        }
        else
        {
                transform.position = Vector3.MoveTowards(transform.position, spawner.NexPos.position, speed * Time.deltaTime);
        }

    }
}
