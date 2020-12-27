using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FaceDirectionManager : MonoBehaviour
{
    [SerializeField] private Transform TargetTransform;
    private Renderer r;
    [SerializeField] private string TargetMaterialName = "";
    [SerializeField] private Material targetMat;
    private Vector4 targetDir = Vector4.zero;

    private void Awake()
    {
        // Get renderer;
        r = gameObject.GetComponentInChildren<Renderer>();

        // Get target material;
        foreach (Material mat in r.materials)
        {
            if (mat.name == TargetMaterialName)
            {
                targetMat = mat;
                break;
            }
        }

    }

    private void Update()
    {
        targetDir = UnityEditor.TransformUtils.GetInspectorRotation(TargetTransform.transform);
        SendDirection(targetDir);
    }
    private void FixedUpdate()
    {
        Debug.Log(targetDir);
    }

    private void SendDirection(Vector4 dir)
    {
        targetMat.SetVector("_DirectionVector",dir);
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
