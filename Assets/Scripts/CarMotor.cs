using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMotor : MonoBehaviour
{
    public static float carSpeed = 1f;
    public static CarMotor instance;

    private void Awake()
    {
        if (instance == null) instance = this;
    }


    void Update()
    {
        transform.position += (Vector3.right * Time.deltaTime * carSpeed);

    }

    public void PerfromButtonAction(PressedButton pressedButton)
    {
        switch (pressedButton)
        {
            case PressedButton.Up:
                {
                    Moveupwards(true);
                }
                break;
            case PressedButton.Down:
                {
                    Moveupwards(false);
                }
                break;
            case PressedButton.Left:
                {
                    MoveLeftRight(true);
                }
                break;
            case PressedButton.Right:
                {
                    MoveLeftRight(false);
                }
                break;
        }
    }


    public void Moveupwards(bool isMovingUp)
    {
        if (isMovingUp) {
            if (transform.position.y > 0.5f) return;
            transform.position += Vector3.up * Time.deltaTime;
         }
        else
        {
            if (transform.position.y < -1f) return;
            transform.position -= Vector3.up * Time.deltaTime;
        }
    }

    public void MoveLeftRight(bool isAccelerating)
    {
        if (isAccelerating)
        {
            carSpeed += 0.25f * Time.deltaTime;
            CameraMovement.Offset -= 0.5f * Time.deltaTime;
            if (carSpeed > 2) {
                carSpeed = 2f;
            }
        }
        else
        {
            carSpeed -= 0.25f * Time.deltaTime;
            CameraMovement.Offset += 0.5f * Time.deltaTime;
            if (carSpeed < 0.75f)
            {
                carSpeed = 0.75f;
            }
        }
    }
}


public enum PressedButton
{
    Up,
    Down,
    Left,
    Right
}