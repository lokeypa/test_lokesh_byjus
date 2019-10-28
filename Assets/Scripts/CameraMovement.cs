using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject car;
    public static float Offset;

    private void LateUpdate()
    {
        Vector3 newPosition = transform.position;
        if (Offset > 1.5) Offset = 1.5f;
        else if (Offset < -1.5) Offset = -1.5f;
        newPosition.x = car.transform.position.x + Offset;
        transform.position = newPosition;
    }
}
