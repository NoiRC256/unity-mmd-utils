using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Rotator : MonoBehaviour
{
    public float speed = 10.0f;
    public bool swingMode = false;
    public float maxRotation = 70f;
    public float swingSpeed = 1f;
    Quaternion targetRotation = Quaternion.identity;
    public bool turningCounterClockwise = false;

    // Update is called once per frame
    void Update()
    {
        if(swingMode)
        {
            if (UnityEditor.TransformUtils.GetInspectorRotation(transform).y < maxRotation - 5f && !turningCounterClockwise)          
            {
                targetRotation = Quaternion.Euler(0f, maxRotation, 0f);
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, swingSpeed * Time.deltaTime);
                //transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion.Euler(0f, maxRotation, 0f), 0.5f * Time.deltaTime);
            }
            else
            {
                turningCounterClockwise = true;
                targetRotation = Quaternion.Euler(0f, -maxRotation, 0f);
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, swingSpeed * Time.deltaTime);
                if (UnityEditor.TransformUtils.GetInspectorRotation(transform).y < -maxRotation + 5f) turningCounterClockwise = false;
            }
        }
        else
        {
            transform.Rotate(0.0f, speed * Time.deltaTime, 0.0f, Space.Self);
        }
    }

    private static float WrapAngle(float angle)
    {
        angle %= 360;
        if (angle > 180)
            return angle - 360;

        return angle;
    }

    private static float UnwrapAngle(float angle)
    {
        if (angle >= 0)
            return angle;

        angle = -angle % 360;

        return 360 - angle;
    }
}
