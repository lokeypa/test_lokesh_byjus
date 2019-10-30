using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMotor : MonoBehaviour
{
    public static float carSpeed = 1f;
    public static CarMotor instance;

    private float carMaxSpeed = 3f;
    private float carMiSpeed = 0.5f;


    private void Awake()
    {
        if (instance == null) instance = this;
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
            if (transform.position.y > 1f) return;
            transform.position += Vector3.up * Time.deltaTime;
         }
        else
        {
            if (transform.position.y < 0f) return;
            transform.position -= Vector3.up * Time.deltaTime;
        }
    }

    public void MoveLeftRight(bool isAccelerating)
    {
        if (isAccelerating)
        {
            carSpeed += 0.25f * Time.deltaTime;
            MoveTransformation(2f);
            if (carSpeed > carMaxSpeed) {
                carSpeed = carMaxSpeed;
            }
        }
        else
        {
            carSpeed -= 0.25f * Time.deltaTime;
            MoveTransformation(-2f);
            if (carSpeed < carMiSpeed)
            {
                carSpeed = carMiSpeed;
            }
        }
    }

    private void MoveTransformation(float rate)
    {
        Vector3 tempPosition = transform.position;
        if (Mathf.Abs(tempPosition.x) < 3)
        {
            tempPosition.x += rate * Time.deltaTime;
            transform.position = tempPosition;
            if(Mathf.Abs(tempPosition.x) > 3)
            {
                tempPosition.x = (rate / 2 * 2.95f);
                transform.position = tempPosition;
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