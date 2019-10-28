using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallexBGEffect : MonoBehaviour
{
    private float lenght, startPosition;
    public GameObject cameraObject;
    public float parallexEffect;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    void FixedUpdate()
    {
        float temp = cameraObject.transform.position.x * (1 - parallexEffect);
        float dist = cameraObject.transform.position.x * parallexEffect;

        transform.position = new Vector3(startPosition + dist, transform.position.y, transform.position.z);

        if (temp > startPosition + lenght) startPosition += lenght;
    }
}
