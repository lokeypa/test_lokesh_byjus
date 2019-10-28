using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpinner : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(-Vector3.forward * 10 * CarMotor.carSpeed);
    }
}
