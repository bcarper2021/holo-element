using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        gameObject.transform.Rotate(Vector3.up * 10 * Time.deltaTime);
    }

}