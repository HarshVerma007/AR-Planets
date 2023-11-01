using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public GameObject PlaneObject;
    public Vector3 RotationVector;

    private void Update()
    {
        PlaneObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}
