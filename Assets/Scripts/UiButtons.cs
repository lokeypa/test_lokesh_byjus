using UnityEngine;
using UnityEngine.EventSystems;

public class UiButtons : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{

    private bool isPressed = false;
    public PressedButton pressedButton;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    private void Update()
    {
        if (isPressed)
        {
            CarMotor.instance.PerfromButtonAction(pressedButton);
        }
    }
}
