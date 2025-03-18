using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int tempoMin, tempoMax;
    public float tempo;
    private float nextSpawn;
    public GameObject Dama;

    public Transform[] Positions;
    public int nexPosIndex;
    public Transform NexPos;

    public List<DamaInteligence>  damas;

    void Awake()
    {
        damas = new List<DamaInteligence>();   
        nextSpawn = Random.Range(tempoMin, tempoMax);
        tempo = Random.Range(tempoMin, tempoMax);
    }

    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + Random.Range(tempoMin, tempoMax);
            DamaInteligence dama = Instantiate(Dama, transform.position, Quaternion.identity).GetComponent<DamaInteligence>();
            dama.spawner = this;
            damas.Add(dama);
        }
    }

    /*public void Move()
    {
        if (transform.position == NexPos.position)
        {
            nexPosIndex++;
            if (nexPosIndex >= Positions.Length)
            {
                nexPosIndex = 0;
            }
            NexPos = Positions[nexPosIndex];
        }
        else
        {
            foreach (DamaInteligence dama in damas)
            {
                transform.position = Vector3.MoveTowards(transform.position, NexPos.position, dama.speed * Time.deltaTime);
            }
        }

    }*/
}
