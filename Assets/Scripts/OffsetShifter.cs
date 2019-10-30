using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetShifter : MonoBehaviour
{

    public float shifterfactor;
    private Material appliedMaterial;

    // Start is called before the first frame update
    void Start()
    {
        appliedMaterial = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        appliedMaterial.mainTextureOffset += new Vector2(Time.deltaTime*shifterfactor*CarMotor.carSpeed, 0);
    }
}
