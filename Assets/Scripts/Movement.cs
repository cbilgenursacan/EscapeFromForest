using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float velocity = 1;
    float xVelocity = 2.5f;
    float leftLimit = -1.5f;
    float rightLimit = 1.5f;

    Vector3 startPos;
    Vector3 endPos;

    
    void Update()
    {
        //transform.Translate(0, 0, velocity * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float x = (endPos.x - startPos.x);
            transform.Translate(x * Time.deltaTime * xVelocity / 100, 0, 0);
            if (transform.position.x > rightLimit)
            {
                transform.position = new Vector3(rightLimit, transform.position.y, transform.position.z);
            }
            if (transform.position.x < leftLimit)
            {
                transform.position = new Vector3(leftLimit, transform.position.y, transform.position.z);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            startPos = Vector3.zero;
            endPos = Vector3.zero;
        }
    }
}
