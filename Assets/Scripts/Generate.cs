using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject peao, bispo, torre;
    public int canSpawn, canSpawBispos, canSpawTower;

    public List<Transform> piecePositions;

    private void Start()
    {
        canSpawn = 3;
        canSpawBispos = 1;
        canSpawTower = 1;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canSpawn > 0)
        {
            canSpawn--;
            Vector3 spawnPosition = GetNearPosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            CreatePiece(spawnPosition);
        }
        if (Input.GetMouseButtonDown(1) && canSpawBispos > 0)
        {
            canSpawBispos--;
            Vector3 spawnPosition = GetNearPosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            CreateBispo(spawnPosition);
        }
        if (Input.GetMouseButtonDown(2) && canSpawTower > 0)
        {
            canSpawTower--;
            Vector3 spawnPosition = GetNearPosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            CreateTower(spawnPosition);
        }
    }

    private Vector3 GetNearPosition(Vector3 pos)
    {
        Vector3 retorno = piecePositions[0].position;
        float distance = Vector2.Distance(retorno, pos);

        foreach (Transform t in piecePositions)
        {
            if (distance > Vector2.Distance(t.position, pos))
            {
                retorno = t.position;
                distance = Vector2.Distance(t.position, pos);
            }
        }
        return retorno;
    }

    public void CreatePiece(Vector3 spawnPos)
    {
        Instantiate(peao, spawnPos, Quaternion.identity);
    }
    public void CreateBispo(Vector3 spawnPos)
    {
        Instantiate(bispo, spawnPos, Quaternion.identity);
    }
    public void CreateTower(Vector3 spawnPos)
    {
        Instantiate(torre, spawnPos, Quaternion.identity);
    }
}
