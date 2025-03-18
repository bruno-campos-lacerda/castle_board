using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SelectPosition : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject peao;
    public Transform selectPeao;

    public Transform[] grid;

    void Update()
    {
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = -1;
        transform.position = mousePosition;
    }
}
