using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public static Camera current;
    public GameObject mainBarrel;
    public Vector3 Angle;

    void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(transform.position, mainBarrel.transform.position + Angle, Time.deltaTime);
    }
}
